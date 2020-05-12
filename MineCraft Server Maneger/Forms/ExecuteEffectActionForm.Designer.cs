namespace MineCraft_Server_Maneger.Forms
{
    partial class ExecuteEffectActionForm
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
            this.playersComboBox = new System.Windows.Forms.ComboBox();
            this.effectComboBox = new System.Windows.Forms.ComboBox();
            this.powerTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.hideParticlesCheckBox = new System.Windows.Forms.CheckBox();
            this._l1 = new System.Windows.Forms.Label();
            this.playerList = new System.Windows.Forms.ListView();
            this._l2 = new System.Windows.Forms.Label();
            this._l3 = new System.Windows.Forms.Label();
            this._l4 = new System.Windows.Forms.Label();
            this.executeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playersComboBox
            // 
            this.playersComboBox.FormattingEnabled = true;
            this.playersComboBox.Location = new System.Drawing.Point(12, 28);
            this.playersComboBox.Name = "playersComboBox";
            this.playersComboBox.Size = new System.Drawing.Size(140, 21);
            this.playersComboBox.TabIndex = 0;
            // 
            // effectComboBox
            // 
            this.effectComboBox.FormattingEnabled = true;
            this.effectComboBox.Location = new System.Drawing.Point(12, 85);
            this.effectComboBox.Name = "effectComboBox";
            this.effectComboBox.Size = new System.Drawing.Size(140, 21);
            this.effectComboBox.TabIndex = 1;
            this.effectComboBox.SelectedIndexChanged += new System.EventHandler(this.EffectComboBox_SelectedIndexChanged);
            this.effectComboBox.TextUpdate += new System.EventHandler(this.EffectComboBox_SelectedIndexChanged);
            // 
            // powerTextBox
            // 
            this.powerTextBox.Location = new System.Drawing.Point(12, 156);
            this.powerTextBox.Name = "powerTextBox";
            this.powerTextBox.Size = new System.Drawing.Size(47, 20);
            this.powerTextBox.TabIndex = 2;
            this.powerTextBox.Text = "1";
            this.powerTextBox.TextChanged += new System.EventHandler(this.PowerTextBox_timeTextBox_TextChanged);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(65, 156);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(87, 20);
            this.timeTextBox.TabIndex = 3;
            this.timeTextBox.Text = "30";
            this.timeTextBox.TextChanged += new System.EventHandler(this.PowerTextBox_timeTextBox_TextChanged);
            // 
            // hideParticlesCheckBox
            // 
            this.hideParticlesCheckBox.AutoSize = true;
            this.hideParticlesCheckBox.Checked = true;
            this.hideParticlesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideParticlesCheckBox.Location = new System.Drawing.Point(12, 204);
            this.hideParticlesCheckBox.Name = "hideParticlesCheckBox";
            this.hideParticlesCheckBox.Size = new System.Drawing.Size(90, 17);
            this.hideParticlesCheckBox.TabIndex = 4;
            this.hideParticlesCheckBox.Text = "Hide particles";
            this.hideParticlesCheckBox.UseVisualStyleBackColor = true;
            // 
            // _l1
            // 
            this._l1.AutoSize = true;
            this._l1.Location = new System.Drawing.Point(9, 12);
            this._l1.Name = "_l1";
            this._l1.Size = new System.Drawing.Size(36, 13);
            this._l1.TabIndex = 5;
            this._l1.Text = "Player";
            // 
            // playerList
            // 
            this.playerList.HideSelection = false;
            this.playerList.Location = new System.Drawing.Point(158, 12);
            this.playerList.MultiSelect = false;
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(184, 180);
            this.playerList.TabIndex = 6;
            this.playerList.UseCompatibleStateImageBehavior = false;
            this.playerList.View = System.Windows.Forms.View.Tile;
            this.playerList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.PlayerList_ItemSelectionChanged);
            // 
            // _l2
            // 
            this._l2.AutoSize = true;
            this._l2.Location = new System.Drawing.Point(9, 69);
            this._l2.Name = "_l2";
            this._l2.Size = new System.Drawing.Size(35, 13);
            this._l2.TabIndex = 7;
            this._l2.Text = "Effect";
            // 
            // _l3
            // 
            this._l3.AutoSize = true;
            this._l3.Location = new System.Drawing.Point(9, 140);
            this._l3.Name = "_l3";
            this._l3.Size = new System.Drawing.Size(37, 13);
            this._l3.TabIndex = 8;
            this._l3.Text = "Power";
            // 
            // _l4
            // 
            this._l4.AutoSize = true;
            this._l4.Location = new System.Drawing.Point(62, 140);
            this._l4.Name = "_l4";
            this._l4.Size = new System.Drawing.Size(30, 13);
            this._l4.TabIndex = 9;
            this._l4.Text = "Time";
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(108, 198);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(234, 23);
            this.executeButton.TabIndex = 10;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ExecuteEffectActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 233);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this._l4);
            this.Controls.Add(this._l3);
            this.Controls.Add(this._l2);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this._l1);
            this.Controls.Add(this.hideParticlesCheckBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.powerTextBox);
            this.Controls.Add(this.effectComboBox);
            this.Controls.Add(this.playersComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExecuteEffectActionForm";
            this.Text = "Execute Effect Command";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox playersComboBox;
        private System.Windows.Forms.ComboBox effectComboBox;
        private System.Windows.Forms.TextBox powerTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.CheckBox hideParticlesCheckBox;
        private System.Windows.Forms.Label _l1;
        private System.Windows.Forms.ListView playerList;
        private System.Windows.Forms.Label _l2;
        private System.Windows.Forms.Label _l3;
        private System.Windows.Forms.Label _l4;
        private System.Windows.Forms.Button executeButton;
    }
}