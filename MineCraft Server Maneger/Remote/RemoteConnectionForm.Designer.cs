namespace MineCraft_Server_Maneger.Remote
{
	partial class RemoteConnectionForm
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
			this.components = new System.ComponentModel.Container();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.serverPasswordTextbox = new System.Windows.Forms.TextBox();
			this.serverConsoleTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.serverOpenButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.clientConnectButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.clientPasswordTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.clientHostIpTextBox = new System.Windows.Forms.TextBox();
			this.serverUpdateTimer = new System.Windows.Forms.Timer(this.components);
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.serverPasswordTextbox);
			this.groupBox2.Controls.Add(this.serverConsoleTextBox);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.serverOpenButton);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(193, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(525, 347);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Host";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(331, 323);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 13);
			this.label7.TabIndex = 8;
			this.label7.Text = "Password:";
			// 
			// serverPasswordTextbox
			// 
			this.serverPasswordTextbox.Location = new System.Drawing.Point(393, 320);
			this.serverPasswordTextbox.Name = "serverPasswordTextbox";
			this.serverPasswordTextbox.Size = new System.Drawing.Size(126, 20);
			this.serverPasswordTextbox.TabIndex = 7;
			// 
			// serverConsoleTextBox
			// 
			this.serverConsoleTextBox.Location = new System.Drawing.Point(6, 36);
			this.serverConsoleTextBox.Multiline = true;
			this.serverConsoleTextBox.Name = "serverConsoleTextBox";
			this.serverConsoleTextBox.Size = new System.Drawing.Size(513, 275);
			this.serverConsoleTextBox.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(128, 323);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(178, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "Host will be openned on port: 10760";
			// 
			// serverOpenButton
			// 
			this.serverOpenButton.Location = new System.Drawing.Point(7, 317);
			this.serverOpenButton.Name = "serverOpenButton";
			this.serverOpenButton.Size = new System.Drawing.Size(115, 23);
			this.serverOpenButton.TabIndex = 2;
			this.serverOpenButton.Text = "Open Host";
			this.serverOpenButton.UseVisualStyleBackColor = true;
			this.serverOpenButton.Click += new System.EventHandler(this.ServerOpenButton_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(104, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "No host openned";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Current Connect: ";
			// 
			// clientConnectButton
			// 
			this.clientConnectButton.Location = new System.Drawing.Point(6, 318);
			this.clientConnectButton.Name = "clientConnectButton";
			this.clientConnectButton.Size = new System.Drawing.Size(163, 23);
			this.clientConnectButton.TabIndex = 6;
			this.clientConnectButton.Text = "Connect";
			this.clientConnectButton.UseVisualStyleBackColor = true;
			this.clientConnectButton.Click += new System.EventHandler(this.ClientConnectButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.clientPasswordTextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.clientHostIpTextBox);
			this.groupBox1.Controls.Add(this.clientConnectButton);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(175, 347);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Connect";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Password";
			// 
			// clientPasswordTextBox
			// 
			this.clientPasswordTextBox.Location = new System.Drawing.Point(6, 102);
			this.clientPasswordTextBox.Name = "clientPasswordTextBox";
			this.clientPasswordTextBox.Size = new System.Drawing.Size(163, 20);
			this.clientPasswordTextBox.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Host IP";
			// 
			// clientHostIpTextBox
			// 
			this.clientHostIpTextBox.Location = new System.Drawing.Point(6, 53);
			this.clientHostIpTextBox.Name = "clientHostIpTextBox";
			this.clientHostIpTextBox.Size = new System.Drawing.Size(163, 20);
			this.clientHostIpTextBox.TabIndex = 7;
			// 
			// serverUpdateTimer
			// 
			this.serverUpdateTimer.Enabled = true;
			this.serverUpdateTimer.Tick += new System.EventHandler(this.ServerUpdateTimer_Tick);
			// 
			// RemoteConnectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(730, 371);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "RemoteConnectionForm";
			this.Text = "Remote Connection";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox serverConsoleTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button serverOpenButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button clientConnectButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox clientPasswordTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox clientHostIpTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox serverPasswordTextbox;
		private System.Windows.Forms.Timer serverUpdateTimer;
	}
}