using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SocketServer
{
	class Program
	{
		private static byte[] result = new byte[1024];
		private static int port = 8888;						// 服务器端口号
		static Socket serverSocket;                         // 服务器Socket


		/*
		 *	流程：
		 *		1. 建立serverSocket来监听Server某个端口.
		 *		2. 创建myThread线程和各外部Client进行通信.
		 *			2.1	建立scSocket来接收外部Client的Connect请求.
		 *			2.2 接收到Request请求后,scSocket发送message给外部Client.
		 *			2.3 创建recThread线程等待、接收外部Client的message.
		 *				2.3.1 接收到message后输出message.
		 *				2.3.2 与外部Client连接断开后关闭与该Client连接的scSocket.
		 *			2.4 创建recThread后直接建立新的scSocket来接收下一个外部Client的Connet请求, 如此循环.
		 */
		static void Main(string[] args)
		{
			IPAddress ip = IPAddress.Parse("127.0.0.1");
			serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			serverSocket.Bind(new IPEndPoint(ip, port));
			serverSocket.Listen(10);
			Console.WriteLine("Listening {0} Successfuly.", serverSocket.LocalEndPoint.ToString());

			Thread myThread = new Thread(ListenClientConnect);
			myThread.Start();
			Console.ReadLine();
		}

		private static void ListenClientConnect()
		{
			while (true)
			{
				Socket scSocket = serverSocket.Accept();
				scSocket.Send(Encoding.ASCII.GetBytes("Server-client say hello"));
				Thread recThread = new Thread(ReceiveMessage);
				recThread.Start(scSocket);
			}
		}

		private static void ReceiveMessage(object sclientSocket)
		{
			Socket scSocket = sclientSocket as Socket;

			while(true)
			{
				try
				{
					int recNumber = scSocket.Receive(result);
					Console.WriteLine("Receive client {0} 's message {1}..", scSocket.RemoteEndPoint.ToString(), Encoding.ASCII.GetString(result, 0, recNumber));
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					scSocket.Shutdown(SocketShutdown.Both);
					scSocket.Close();
					break;
				}
			}
		}
	}
}
