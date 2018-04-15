namespace Server
{
	partial class BlackHouseServer
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
			this.btnStop = new System.Windows.Forms.Button();
			this.btnListen = new System.Windows.Forms.Button();
			this.tbPort = new System.Windows.Forms.TextBox();
			this.labelPort = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rtbServerMessageBox = new System.Windows.Forms.RichTextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnStop);
			this.panel1.Controls.Add(this.btnListen);
			this.panel1.Controls.Add(this.tbPort);
			this.panel1.Controls.Add(this.labelPort);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(443, 82);
			this.panel1.TabIndex = 0;
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(134, 40);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 23);
			this.btnStop.TabIndex = 3;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnListen
			// 
			this.btnListen.Location = new System.Drawing.Point(23, 40);
			this.btnListen.Name = "btnListen";
			this.btnListen.Size = new System.Drawing.Size(75, 23);
			this.btnListen.TabIndex = 2;
			this.btnListen.Text = "Listen";
			this.btnListen.UseVisualStyleBackColor = true;
			this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
			// 
			// tbPort
			// 
			this.tbPort.Location = new System.Drawing.Point(89, 13);
			this.tbPort.Name = "tbPort";
			this.tbPort.Size = new System.Drawing.Size(100, 21);
			this.tbPort.TabIndex = 1;
			this.tbPort.Text = "8080";
			// 
			// labelPort
			// 
			this.labelPort.AutoSize = true;
			this.labelPort.Location = new System.Drawing.Point(21, 16);
			this.labelPort.Name = "labelPort";
			this.labelPort.Size = new System.Drawing.Size(35, 12);
			this.labelPort.TabIndex = 0;
			this.labelPort.Text = "Port:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.rtbServerMessageBox);
			this.panel2.Location = new System.Drawing.Point(12, 100);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(443, 338);
			this.panel2.TabIndex = 1;
			// 
			// rtbServerMessageBox
			// 
			this.rtbServerMessageBox.Location = new System.Drawing.Point(12, 14);
			this.rtbServerMessageBox.Name = "rtbServerMessageBox";
			this.rtbServerMessageBox.ReadOnly = true;
			this.rtbServerMessageBox.Size = new System.Drawing.Size(415, 306);
			this.rtbServerMessageBox.TabIndex = 0;
			this.rtbServerMessageBox.Text = "";
			this.rtbServerMessageBox.TextChanged += new System.EventHandler(this.rtbServerMessageBox_TextChanged);
			// 
			// BlackHouseServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "BlackHouseServer";
			this.Text = "BlackHouseServer";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnListen;
		private System.Windows.Forms.TextBox tbPort;
		private System.Windows.Forms.Label labelPort;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RichTextBox rtbServerMessageBox;
		private System.Windows.Forms.Button btnStop;
	}
}