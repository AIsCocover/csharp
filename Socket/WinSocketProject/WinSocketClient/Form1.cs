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

namespace WinSocketClient
{
	public partial class FormSocketClient : Form
	{
		private static byte[] result = new byte[1024];
		Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

		public FormSocketClient()
		{
			InitializeComponent();
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			IPAddress connectIP = IPAddress.Parse(tbCIP.Text);
			int connectPort = Int32.Parse(tbCPort.Text);

			clientSocket.Connect(new IPEndPoint(connectIP, connectPort));
			string message = "Connect server " + clientSocket.RemoteEndPoint.ToString() + " successful.\n";
			rtbCMessage.AppendText(message);

			int recLength = clientSocket.Receive(result);
			string recMessage = Encoding.ASCII.GetString(result, 0, recLength);
			rtbCMessage.AppendText(recMessage);
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
				string message = tbSendMessage.Text + "\n";
				clientSocket.Send(Encoding.ASCII.GetBytes(message));
				rtbCMessage.AppendText("Send Message: " + message);
		}
	}
}
