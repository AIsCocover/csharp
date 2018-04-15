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

namespace WinSocketServer
{
	public partial class FormSocketServer : Form
	{
		private static byte[] result = new byte[1024];
		Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

		public FormSocketServer()
		{
			InitializeComponent();
		}

		private void btnListen_Click(object sender, EventArgs e)
		{
			IPAddress serverIP = IPAddress.Parse("127.0.0.1");
			int serverPort = Int32.Parse(tbSPort.Text);
			serverSocket.Bind(new IPEndPoint(serverIP, serverPort));
			serverSocket.Listen(10);
			rtbSMessage.AppendText("Listening " + serverSocket.LocalEndPoint.ToString() + "\n");

			Thread myThread = new Thread(ListenClientConnect);
			myThread.Start();
		}

		private void ListenClientConnect()
		{
			while (true)
			{
				Socket scSocket = serverSocket.Accept();
				string message = "Connect client " + scSocket.RemoteEndPoint.ToString() + " \n";
				AppendText(message);
				message = "Welcome to connect " + serverSocket.LocalEndPoint.ToString() + "\n";
				scSocket.Send(Encoding.ASCII.GetBytes(message));

				Thread recThread = new Thread(ReceiveMessage);
				recThread.Start(scSocket);
			}
		}

		private void ReceiveMessage(object sclientSocket)
		{
			Socket scSocket = (Socket)sclientSocket;

			while (true)
			{
				try
				{
					int recLength = scSocket.Receive(result);
					string message = "Receive " + scSocket.RemoteEndPoint.ToString() + " " + Encoding.ASCII.GetString(result, 0, recLength);
					//					Console.WriteLine(message);
					AppendText(message);
				}
				catch (Exception e)
				{
					//					Console.WriteLine(e.Message);
					AppendText(e.Message);
					scSocket.Shutdown(SocketShutdown.Both);
					scSocket.Close();
					break;
				}
			}
		}

		/*
		 *	问题：
		 *		子线程下不能直接调用主窗体控件
		 *	解决：
		 *		把想对另一线程中的控件实施的操作放到一个函数中，然后使用delegate代理那个函数，并且在那个函数中加入一个判断，
		 *		用InvokeRequired来判断调用这个函数的线程是否与控件线程在同一线程中，如果是则直接执行对控件的操作，否则利用
		 *		控件的Invoke火BeginInvoke方法来执行这个代理.
		 */
		private delegate void AppendTextHandler(string message);

		private void AppendText(string message)
		{
			if (!rtbSMessage.InvokeRequired)
			{
				rtbSMessage.AppendText(message);
			}
			else
			{
				AppendTextHandler at = new AppendTextHandler(AppendText);
				Invoke(at, message);
			}
		}
	}
}
