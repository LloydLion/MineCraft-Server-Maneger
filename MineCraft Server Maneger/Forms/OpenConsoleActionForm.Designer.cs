namespace MineCraft_Server_Maneger.Forms
{
	partial class OpenConsoleActionForm
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
			this.consoleTextBox = new System.Windows.Forms.TextBox();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.runButton = new System.Windows.Forms.Button();
			this.updateConsoleTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// consoleTextBox
			// 
			this.consoleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.consoleTextBox.Location = new System.Drawing.Point(12, 12);
			this.consoleTextBox.Multiline = true;
			this.consoleTextBox.Name = "consoleTextBox";
			this.consoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.consoleTextBox.Size = new System.Drawing.Size(468, 467);
			this.consoleTextBox.TabIndex = 0;
			// 
			// inputTextBox
			// 
			this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inputTextBox.Location = new System.Drawing.Point(13, 485);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(386, 20);
			this.inputTextBox.TabIndex = 1;
			// 
			// runButton
			// 
			this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.runButton.Location = new System.Drawing.Point(405, 485);
			this.runButton.Name = "runButton";
			this.runButton.Size = new System.Drawing.Size(75, 20);
			this.runButton.TabIndex = 2;
			this.runButton.Text = "Run";
			this.runButton.UseVisualStyleBackColor = true;
			this.runButton.Click += new System.EventHandler(this.runButton_Click);
			// 
			// updateConsoleTimer
			// 
			this.updateConsoleTimer.Enabled = true;
			this.updateConsoleTimer.Interval = 500;
			this.updateConsoleTimer.Tick += new System.EventHandler(this.UpdateConsoleTimer_Tick);
			// 
			// OpenConsoleActionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 517);
			this.Controls.Add(this.runButton);
			this.Controls.Add(this.inputTextBox);
			this.Controls.Add(this.consoleTextBox);
			this.Name = "OpenConsoleActionForm";
			this.Text = "Console";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox consoleTextBox;
		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Button runButton;
		private System.Windows.Forms.Timer updateConsoleTimer;
	}
}