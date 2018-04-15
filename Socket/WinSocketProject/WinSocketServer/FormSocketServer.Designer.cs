namespace WinSocketServer
{
	partial class FormSocketServer
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
			this.rtbSMessage = new System.Windows.Forms.RichTextBox();
			this.labelSPort = new System.Windows.Forms.Label();
			this.tbSPort = new System.Windows.Forms.TextBox();
			this.btnListen = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnListen);
			this.panel1.Controls.Add(this.tbSPort);
			this.panel1.Controls.Add(this.labelSPort);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(214, 76);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.rtbSMessage);
			this.panel2.Location = new System.Drawing.Point(12, 106);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(214, 196);
			this.panel2.TabIndex = 1;
			// 
			// rtbSMessage
			// 
			this.rtbSMessage.Location = new System.Drawing.Point(0, 0);
			this.rtbSMessage.Name = "rtbSMessage";
			this.rtbSMessage.ReadOnly = true;
			this.rtbSMessage.Size = new System.Drawing.Size(214, 196);
			this.rtbSMessage.TabIndex = 0;
			this.rtbSMessage.Text = "";
			// 
			// labelSPort
			// 
			this.labelSPort.AutoSize = true;
			this.labelSPort.Location = new System.Drawing.Point(15, 20);
			this.labelSPort.Name = "labelSPort";
			this.labelSPort.Size = new System.Drawing.Size(29, 12);
			this.labelSPort.TabIndex = 1;
			this.labelSPort.Text = "Port";
			// 
			// tbSPort
			// 
			this.tbSPort.Location = new System.Drawing.Point(66, 17);
			this.tbSPort.Name = "tbSPort";
			this.tbSPort.Size = new System.Drawing.Size(100, 21);
			this.tbSPort.TabIndex = 3;
			// 
			// btnListen
			// 
			this.btnListen.Location = new System.Drawing.Point(62, 44);
			this.btnListen.Name = "btnListen";
			this.btnListen.Size = new System.Drawing.Size(75, 23);
			this.btnListen.TabIndex = 4;
			this.btnListen.Text = "Listen";
			this.btnListen.UseVisualStyleBackColor = true;
			this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
			// 
			// FormSocketServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(237, 307);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FormSocketServer";
			this.Text = "FormSocketServer";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnListen;
		private System.Windows.Forms.TextBox tbSPort;
		private System.Windows.Forms.Label labelSPort;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RichTextBox rtbSMessage;
	}
}