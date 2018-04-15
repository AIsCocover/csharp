namespace Client
{
	partial class BlackHouseClient
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnConnect = new System.Windows.Forms.Button();
			this.tbIP = new System.Windows.Forms.TextBox();
			this.tbPort = new System.Windows.Forms.TextBox();
			this.labelIP = new System.Windows.Forms.Label();
			this.labelPort = new System.Windows.Forms.Label();
			this.rtbClientMessage = new System.Windows.Forms.RichTextBox();
			this.tbSend = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnDisconnect);
			this.panel1.Controls.Add(this.labelPort);
			this.panel1.Controls.Add(this.labelIP);
			this.panel1.Controls.Add(this.tbPort);
			this.panel1.Controls.Add(this.tbIP);
			this.panel1.Controls.Add(this.btnConnect);
			this.panel1.Location = new System.Drawing.Point(13, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(381, 86);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.rtbClientMessage);
			this.panel2.Location = new System.Drawing.Point(13, 106);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(381, 319);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnSend);
			this.panel3.Controls.Add(this.tbSend);
			this.panel3.Location = new System.Drawing.Point(12, 431);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(382, 37);
			this.panel3.TabIndex = 2;
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(265, 21);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 23);
			this.btnConnect.TabIndex = 0;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// tbIP
			// 
			this.tbIP.Location = new System.Drawing.Point(121, 23);
			this.tbIP.Name = "tbIP";
			this.tbIP.Size = new System.Drawing.Size(100, 21);
			this.tbIP.TabIndex = 1;
			this.tbIP.Text = "127.0.0.1";
			// 
			// tbPort
			// 
			this.tbPort.Location = new System.Drawing.Point(121, 51);
			this.tbPort.Name = "tbPort";
			this.tbPort.Size = new System.Drawing.Size(100, 21);
			this.tbPort.TabIndex = 2;
			this.tbPort.Text = "8080";
			// 
			// labelIP
			// 
			this.labelIP.AutoSize = true;
			this.labelIP.Location = new System.Drawing.Point(26, 26);
			this.labelIP.Name = "labelIP";
			this.labelIP.Size = new System.Drawing.Size(29, 12);
			this.labelIP.TabIndex = 3;
			this.labelIP.Text = "IP :";
			// 
			// labelPort
			// 
			this.labelPort.AutoSize = true;
			this.labelPort.Location = new System.Drawing.Point(26, 54);
			this.labelPort.Name = "labelPort";
			this.labelPort.Size = new System.Drawing.Size(41, 12);
			this.labelPort.TabIndex = 4;
			this.labelPort.Text = "Port :";
			// 
			// rtbClientMessage
			// 
			this.rtbClientMessage.Location = new System.Drawing.Point(12, 13);
			this.rtbClientMessage.Name = "rtbClientMessage";
			this.rtbClientMessage.ReadOnly = true;
			this.rtbClientMessage.Size = new System.Drawing.Size(353, 291);
			this.rtbClientMessage.TabIndex = 0;
			this.rtbClientMessage.Text = "";
			this.rtbClientMessage.TextChanged += new System.EventHandler(this.rtbClientMessage_TextChanged);
			// 
			// tbSend
			// 
			this.tbSend.Location = new System.Drawing.Point(3, 9);
			this.tbSend.Name = "tbSend";
			this.tbSend.Size = new System.Drawing.Size(266, 21);
			this.tbSend.TabIndex = 0;
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(291, 7);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 1;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Location = new System.Drawing.Point(265, 50);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
			this.btnDisconnect.TabIndex = 5;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.UseVisualStyleBackColor = true;
			this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
			// 
			// BlackHouseClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(406, 468);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "BlackHouseClient";
			this.Text = "BlackHouseClient";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label labelPort;
		private System.Windows.Forms.Label labelIP;
		private System.Windows.Forms.TextBox tbPort;
		private System.Windows.Forms.TextBox tbIP;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.RichTextBox rtbClientMessage;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox tbSend;
		private System.Windows.Forms.Button btnDisconnect;
	}
}