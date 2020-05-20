namespace MineCraft_Server_Maneger.Forms
{
    partial class ExecuteXpActionForm
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
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(12, 12);
            this.numericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown.TabIndex = 0;
            this.numericUpDown.ThousandsSeparator = true;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(13, 39);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(136, 21);
            this.comboBox.TabIndex = 1;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(97, 13);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(52, 17);
            this.checkBox.TabIndex = 2;
            this.checkBox.Text = "Level";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(13, 67);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(136, 23);
            this.button.TabIndex = 3;
            this.button.Text = "Execute";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // ExecuteXpActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 102);
            this.Controls.Add(this.button);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.numericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ExecuteXpActionForm";
            this.Text = "Xp";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button button;
    }
}