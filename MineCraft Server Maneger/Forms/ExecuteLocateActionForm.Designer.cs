namespace MineCraft_Server_Maneger.Forms
{
    partial class ExecuteLocateActionForm
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(13, 13);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(169, 21);
            this.comboBox.TabIndex = 0;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(13, 41);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(169, 23);
            this.button.TabIndex = 1;
            this.button.Text = "Execute";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // ExecuteLocateActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 74);
            this.Controls.Add(this.button);
            this.Controls.Add(this.comboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ExecuteLocateActionForm";
            this.Text = "Locate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button button;
    }
}