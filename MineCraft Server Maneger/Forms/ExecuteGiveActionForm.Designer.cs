namespace MineCraft_Server_Maneger.Forms
{
    partial class ExecuteGiveActionForm
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
            this.textBoxMeta = new System.Windows.Forms.TextBox();
            this._l1 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.comboBoxPlayers = new System.Windows.Forms.ComboBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxMeta
            // 
            this.textBoxMeta.Location = new System.Drawing.Point(142, 12);
            this.textBoxMeta.Name = "textBoxMeta";
            this.textBoxMeta.Size = new System.Drawing.Size(40, 20);
            this.textBoxMeta.TabIndex = 13;
            // 
            // _l1
            // 
            this._l1.AutoSize = true;
            this._l1.Location = new System.Drawing.Point(12, 42);
            this._l1.Name = "_l1";
            this._l1.Size = new System.Drawing.Size(36, 13);
            this._l1.TabIndex = 12;
            this._l1.Text = "Player";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(12, 65);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(170, 27);
            this.button.TabIndex = 11;
            this.button.Text = "Execute";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(12, 11);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(124, 21);
            this.comboBoxItems.TabIndex = 7;
            // 
            // comboBoxPlayers
            // 
            this.comboBoxPlayers.FormattingEnabled = true;
            this.comboBoxPlayers.Location = new System.Drawing.Point(54, 38);
            this.comboBoxPlayers.Name = "comboBoxPlayers";
            this.comboBoxPlayers.Size = new System.Drawing.Size(82, 21);
            this.comboBoxPlayers.TabIndex = 14;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(142, 39);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(40, 20);
            this.textBoxCount.TabIndex = 15;
            // 
            // ExecuteGiveActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 104);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.comboBoxPlayers);
            this.Controls.Add(this.textBoxMeta);
            this.Controls.Add(this._l1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.comboBoxItems);
            this.Name = "ExecuteGiveActionForm";
            this.Text = "Give";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMeta;
        private System.Windows.Forms.Label _l1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.ComboBox comboBoxPlayers;
        private System.Windows.Forms.TextBox textBoxCount;
    }
}