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


namespace Client
{
	public partial class BlackHouseClient : Form
	{
		public static byte[] result = new byte[1024];
		private static Socket clientSocket;

		public BlackHouseClient()
		{
			InitializeComponent();
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			/*
			 *	1.绑定并监听指定主机指定端口
			 *	2.向屏幕输出正在连接
			 *	3.接收server发送过来的欢迎信息
			 */
			IPAddress ip = IPAddress.Parse(tbIP.Text);
			int port = Int32.Parse(tbPort.Text);
			clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

			try
			{
				string message = "Connect to " + ip + ": " + port + "...\n";
				AppendText(message);

				clientSocket.Connect(new IPEndPoint(ip, port));

				int recLength = clientSocket.Receive(result);
				message = Encoding.ASCII.GetString(result);
				AppendText(message);

				Thread recThread = new Thread(ReceiveMessage);
				recThread.Start();
			}
			catch (Exception ex)
			{
				string message = ex.Message + "\n";
				AppendText(message);
			}
		}

		private void ReceiveMessage()
		{
			while(true)
			{
				try
				{
					int recLength = clientSocket.Receive(result);
					string message = Encoding.ASCII.GetString(result, 0, recLength);
					Console.WriteLine("Client get message: " + message);
					AppendText(message);
				}
				catch(Exception ex)
				{
					string message = ex.Message + "\n";
					AppendText(message);
					break;
				}
			}
		}

		private void btnDisconnect_Click(object sender, EventArgs e)
		{
			/*
			 *	1.关闭连接
			 *	2.输出断开连接的对象
			 */
			if (clientSocket.Connected == false)
			{
				AppendText("No Connection to disconnect.\n");
			}

			string message = "Connection with " + clientSocket.RemoteEndPoint.ToString() + " is broken.\n";
			clientSocket.Close();

			AppendText(message);
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			/*
			 *	发送信息到server上
			 */
			try
			{
				string message = tbSend.Text;
				clientSocket.Send(Encoding.ASCII.GetBytes(message));
			}
			catch(Exception ex)
			{
				string message = ex.Message + "\n";
				AppendText(message);
			}
		}

		private delegate void AppendTextHandler(string message);

		private void AppendText(string message)
		{
			if (!rtbClientMessage.InvokeRequired)
			{
				rtbClientMessage.AppendText(message);
			}
			else
			{
				AppendTextHandler at = new AppendTextHandler(AppendText);
				Invoke(at, message);
			}
		}

		private void rtbClientMessage_TextChanged(object sender, EventArgs e)
		{
			rtbClientMessage.SelectionStart = rtbClientMessage.Text.Length;
			rtbClientMessage.ScrollToCaret();
		}
	}
}
