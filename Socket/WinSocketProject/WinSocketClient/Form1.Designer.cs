namespace WinSocketClient
{
	partial class FormSocketClient
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnSend = new System.Windows.Forms.Button();
			this.rtbCMessage = new System.Windows.Forms.RichTextBox();
			this.tbCIP = new System.Windows.Forms.TextBox();
			this.tbCPort = new System.Windows.Forms.TextBox();
			this.tbSendMessage = new System.Windows.Forms.TextBox();
			this.labelCIP = new System.Windows.Forms.Label();
			this.labelCPort = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.labelCPort);
			this.panel1.Controls.Add(this.labelCIP);
			this.panel1.Controls.Add(this.tbCPort);
			this.panel1.Controls.Add(this.tbCIP);
			this.panel1.Controls.Add(this.btnConnect);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(263, 103);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.rtbCMessage);
			this.panel2.Location = new System.Drawing.Point(13, 132);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(262, 175);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.tbSendMessage);
			this.panel3.Controls.Add(this.btnSend);
			this.panel3.Location = new System.Drawing.Point(13, 322);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(262, 22);
			this.panel3.TabIndex = 2;
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(198, 41);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(62, 23);
			this.btnConnect.TabIndex = 0;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(172, -1);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 0;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// rtbCMessage
			// 
			this.rtbCMessage.Location = new System.Drawing.Point(-1, 0);
			this.rtbCMessage.Name = "rtbCMessage";
			this.rtbCMessage.ReadOnly = true;
			this.rtbCMessage.Size = new System.Drawing.Size(263, 175);
			this.rtbCMessage.TabIndex = 0;
			this.rtbCMessage.Text = "";
			// 
			// tbCIP
			// 
			this.tbCIP.Location = new System.Drawing.Point(92, 23);
			this.tbCIP.Name = "tbCIP";
			this.tbCIP.Size = new System.Drawing.Size(100, 21);
			this.tbCIP.TabIndex = 1;
			// 
			// tbCPort
			// 
			this.tbCPort.Location = new System.Drawing.Point(92, 61);
			this.tbCPort.Name = "tbCPort";
			this.tbCPort.Size = new System.Drawing.Size(100, 21);
			this.tbCPort.TabIndex = 2;
			// 
			// tbSendMessage
			// 
			this.tbSendMessage.Location = new System.Drawing.Point(-1, 0);
			this.tbSendMessage.Name = "tbSendMessage";
			this.tbSendMessage.Size = new System.Drawing.Size(160, 21);
			this.tbSendMessage.TabIndex = 1;
			// 
			// labelCIP
			// 
			this.labelCIP.AutoSize = true;
			this.labelCIP.Location = new System.Drawing.Point(9, 26);
			this.labelCIP.Name = "labelCIP";
			this.labelCIP.Size = new System.Drawing.Size(65, 12);
			this.labelCIP.TabIndex = 3;
			this.labelCIP.Text = "Server IP:";
			// 
			// labelCPort
			// 
			this.labelCPort.AutoSize = true;
			this.labelCPort.Location = new System.Drawing.Point(9, 64);
			this.labelCPort.Name = "labelCPort";
			this.labelCPort.Size = new System.Drawing.Size(77, 12);
			this.labelCPort.TabIndex = 4;
			this.labelCPort.Text = "Server Port:";
			// 
			// FormSocketClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(287, 357);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FormSocketClient";
			this.Text = "SocketClient";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelCPort;
		private System.Windows.Forms.Label labelCIP;
		private System.Windows.Forms.TextBox tbCPort;
		private System.Windows.Forms.TextBox tbCIP;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RichTextBox rtbCMessage;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox tbSendMessage;
		private System.Windows.Forms.Button btnSend;
	}
}

