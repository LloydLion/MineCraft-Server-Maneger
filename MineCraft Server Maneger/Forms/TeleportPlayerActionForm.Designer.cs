namespace MineCraft_Server_Maneger.Forms
{
	partial class TeleportPlayerActionForm
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
			this.playerList = new System.Windows.Forms.ListView();
			this._l1 = new System.Windows.Forms.Label();
			this.playerComboBox = new System.Windows.Forms.ComboBox();
			this.executeButton = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.xPositionTextBox = new System.Windows.Forms.TextBox();
			this.yPositionTextBox = new System.Windows.Forms.TextBox();
			this.zPositionTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// playerList
			// 
			this.playerList.HideSelection = false;
			this.playerList.Location = new System.Drawing.Point(161, 9);
			this.playerList.MultiSelect = false;
			this.playerList.Name = "playerList";
			this.playerList.Size = new System.Drawing.Size(190, 180);
			this.playerList.TabIndex = 7;
			this.playerList.UseCompatibleStateImageBehavior = false;
			this.playerList.View = System.Windows.Forms.View.Tile;
			this.playerList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.PlayerList_ItemSelectionChanged);
			// 
			// _l1
			// 
			this._l1.AutoSize = true;
			this._l1.Location = new System.Drawing.Point(9, 32);
			this._l1.Name = "_l1";
			this._l1.Size = new System.Drawing.Size(36, 13);
			this._l1.TabIndex = 9;
			this._l1.Text = "Player";
			// 
			// playerComboBox
			// 
			this.playerComboBox.FormattingEnabled = true;
			this.playerComboBox.Location = new System.Drawing.Point(12, 48);
			this.playerComboBox.Name = "playerComboBox";
			this.playerComboBox.Size = new System.Drawing.Size(143, 21);
			this.playerComboBox.TabIndex = 8;
			// 
			// executeButton
			// 
			this.executeButton.Location = new System.Drawing.Point(12, 195);
			this.executeButton.Name = "executeButton";
			this.executeButton.Size = new System.Drawing.Size(339, 24);
			this.executeButton.TabIndex = 11;
			this.executeButton.Text = "Teleport";
			this.executeButton.UseVisualStyleBackColor = true;
			this.executeButton.Click += new System.EventHandler(this.ExecuteButton_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(12, 12);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(69, 17);
			this.radioButton1.TabIndex = 16;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "To player";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(12, 85);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(77, 17);
			this.radioButton2.TabIndex = 17;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "To position";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
			// 
			// xPositionTextBox
			// 
			this.xPositionTextBox.Location = new System.Drawing.Point(12, 109);
			this.xPositionTextBox.Name = "xPositionTextBox";
			this.xPositionTextBox.Size = new System.Drawing.Size(143, 20);
			this.xPositionTextBox.TabIndex = 18;
			this.xPositionTextBox.Text = "X";
			// 
			// yPositionTextBox
			// 
			this.yPositionTextBox.Location = new System.Drawing.Point(12, 135);
			this.yPositionTextBox.Name = "yPositionTextBox";
			this.yPositionTextBox.Size = new System.Drawing.Size(143, 20);
			this.yPositionTextBox.TabIndex = 19;
			this.yPositionTextBox.Text = "Y";
			// 
			// zPositionTextBox
			// 
			this.zPositionTextBox.Location = new System.Drawing.Point(12, 161);
			this.zPositionTextBox.Name = "zPositionTextBox";
			this.zPositionTextBox.Size = new System.Drawing.Size(143, 20);
			this.zPositionTextBox.TabIndex = 20;
			this.zPositionTextBox.Text = "Z";
			// 
			// TeleportPlayerActionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 231);
			this.Controls.Add(this.zPositionTextBox);
			this.Controls.Add(this.yPositionTextBox);
			this.Controls.Add(this.xPositionTextBox);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.executeButton);
			this.Controls.Add(this._l1);
			this.Controls.Add(this.playerComboBox);
			this.Controls.Add(this.playerList);
			this.Controls.Add(this.radioButton1);
			this.Name = "TeleportPlayerActionForm";
			this.Text = "Teleport Player";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView playerList;
		private System.Windows.Forms.Label _l1;
		private System.Windows.Forms.ComboBox playerComboBox;
		private System.Windows.Forms.Button executeButton;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.TextBox xPositionTextBox;
		private System.Windows.Forms.TextBox yPositionTextBox;
		private System.Windows.Forms.TextBox zPositionTextBox;
	}
}