using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
	public partial class BlackHouseServer : Form
	{
		private static byte[] result = new byte[1024];
		private static Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		private static List<Socket> connectSockets = new List<Socket>();
		private static List<Thread> connectThreads = new List<Thread>();
//		private string message = "";
//		private int id = 0;

		public BlackHouseServer()
		{
			InitializeComponent();

			btnListen.Enabled = true;
			btnStop.Enabled = false;
		}

		private void btnListen_Click(object sender, EventArgs e)
		{
			btnListen.Enabled = false;
			btnStop.Enabled = true;

			/*
			 *	绑定并监听本机8080端口，并显示监听信息
			 */
			IPAddress ip = IPAddress.Parse("127.0.0.1");
			int port = Int32.Parse(tbPort.Text);
			string message = "Begining isten port: " + port + ".\n";
			serverSocket.Bind(new IPEndPoint(ip, port));
			serverSocket.Listen(10);
			rtbServerMessageBox.AppendText(message);

			/*
			 *  建立进程处理server与各client的通信
			 */
			Thread serverThread = new Thread(ListenClientConnect);
			serverThread.Start();
		}

		private void ListenClientConnect()
		{
			while(true)
			{
				try
				{
					/*
					 *	1.建立connSocket后将其添加进connectSockets方便统一管理.
					 *	2.向所有client发送新client加入信息
					 *	3.向新加入的client发送欢迎信息
					 *	4.建立新client的监听进程用于接收client发送过来的信息
 					 */
					Socket connSocket = serverSocket.Accept();
					connectSockets.Add(connSocket);

					string message = "Welcome to connect " + serverSocket.LocalEndPoint.ToString() + "\n";
					connSocket.Send(Encoding.ASCII.GetBytes(message));

					message = connSocket.RemoteEndPoint.ToString() + " join in.";
					AppendText(message + "\n");
					SendMessage(message);					

					Thread recThread = new Thread(ReceiveMessage);
					connectThreads.Add(recThread);
					recThread.Start(connSocket);
				}
				catch(Exception ex)
				{
					string exMessage = ex.Message + "\n";
					AppendText(exMessage);
				}
			}
		}

		private void ReceiveMessage(object cSocket)
		{
			Socket connSocket = (Socket)cSocket;

			/*
			 *	1. 接收client的信息并将其打印到server上
			 *	2.将接收的信息发送到所有client上
			 */
			while(true)
			{
				try
				{
					int recLength = connSocket.Receive(result);
					string recMessage = connSocket.RemoteEndPoint.ToString() + " : " + Encoding.ASCII.GetString(result, 0, recLength);
					AppendText(recMessage);
					SendMessage(recMessage);
				}
				catch(Exception ex)
				{
					string exMessage = ex.Message + "\n";
					AppendText(exMessage);
					connectSockets.Remove(connSocket);
					exMessage = connSocket.RemoteEndPoint.ToString() + " has exit.";
					SendMessage(exMessage);

					Thread.CurrentThread.Abort();
					connSocket.Shutdown(SocketShutdown.Both);
					connSocket.Close();
					break;
				}
			}
		}

		private void SendMessage(string message)
		{
			Console.WriteLine("SendMessage Function running...");
			string recMessage = message + "\n";
			for(int i=0; i<connectSockets.Count; i++)
			{
				try
				{
					connectSockets[i].Send(Encoding.ASCII.GetBytes(recMessage));
					Console.WriteLine("Server send message: " + recMessage);
				}
				catch(Exception ex)
				{
					string exMessage = ex.Message + "\n";
					AppendText(exMessage);
				}
			}
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			string message = "Stop listen : " + serverSocket.LocalEndPoint.ToString() + "\n";
			btnStop.Enabled = false;
			serverSocket.Shutdown(SocketShutdown.Both);
			serverSocket.Close();
			
			for(int i=0; i<connectSockets.Count; i++)
			{
				connectSockets[i].Close();
			}

			connectSockets.Clear();
			AppendText(message);
		}

		private delegate void AppendTextHandler(string message);

		private void AppendText(string message)
		{
			if(!rtbServerMessageBox.InvokeRequired)
			{
				rtbServerMessageBox.AppendText(message);
			}
			else
			{
				AppendTextHandler at = new AppendTextHandler(AppendText);
				Invoke(at, message);
			}
		}

		private void rtbServerMessageBox_TextChanged(object sender, EventArgs e)
		{
			rtbServerMessageBox.SelectionStart = rtbServerMessageBox.Text.Length;
			rtbServerMessageBox.ScrollToCaret();
		}
	}
}
