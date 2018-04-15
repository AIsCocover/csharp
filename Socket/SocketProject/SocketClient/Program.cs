using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SocketClient
{
	class Program
	{
		private static byte[] result = new byte[1024];

		/*
		 *	流程：
		 *		1. 建立clientSocket对指定Server的端口发起Connect请求.
		 *			1.1 Connect成功.
		 *				1.1.1 接收Server发送来的message.
		 *				1.1.2 间断地向Server发送message.
		 *				1.1.3 程序结束,关闭与Server的连接clientSocket.
		 *			1.2 Connect失败, 回车退出程序.
		 */
		static void Main(string[] args)
		{
			IPAddress ip = IPAddress.Parse("127.0.0.1");
			int port = 8888;
			Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

			try
			{
				clientSocket.Connect(new IPEndPoint(ip, port));
				Console.WriteLine("Connect request successful.");
			}
			catch
			{
				Console.WriteLine("Connect request failure, input 'enter' to exit.");
				return;
			}

			int recLength = clientSocket.Receive(result);
			Console.WriteLine("Receive Server Message: {0}", Encoding.ASCII.GetString(result, 0, recLength));

			for (int i = 0; i < 10; i++)
			{
				try
				{
					Thread.Sleep(1000);
					string sendMessage = "Client say i am find." + DateTime.Now;
					clientSocket.Send(Encoding.ASCII.GetBytes(sendMessage));
					Console.WriteLine("Send Message to Server: {0}.", sendMessage);
				}
				catch
				{
					clientSocket.Shutdown(SocketShutdown.Both);
					clientSocket.Close();
					break;
				}
			}

			Console.WriteLine("Finished sending, input 'enter' to exit.");
			Console.ReadLine();
		}
	}
}
