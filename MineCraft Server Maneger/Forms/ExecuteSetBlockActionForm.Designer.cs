namespace MineCraft_Server_Maneger.Forms
{
    partial class ExecuteSetBlockActionForm
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
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this._l1 = new System.Windows.Forms.Label();
            this.textBoxMeta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(12, 12);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(124, 21);
            this.comboBox.TabIndex = 0;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(51, 39);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(40, 20);
            this.textBoxX.TabIndex = 1;
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(143, 39);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(40, 20);
            this.textBoxZ.TabIndex = 2;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(97, 39);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(40, 20);
            this.textBoxY.TabIndex = 3;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(12, 65);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(170, 27);
            this.button.TabIndex = 4;
            this.button.Text = "Execute";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // _l1
            // 
            this._l1.AutoSize = true;
            this._l1.Location = new System.Drawing.Point(12, 42);
            this._l1.Name = "_l1";
            this._l1.Size = new System.Drawing.Size(31, 13);
            this._l1.TabIndex = 5;
            this._l1.Text = "XYZ:";
            // 
            // textBoxMeta
            // 
            this.textBoxMeta.Location = new System.Drawing.Point(142, 12);
            this.textBoxMeta.Name = "textBoxMeta";
            this.textBoxMeta.Size = new System.Drawing.Size(40, 20);
            this.textBoxMeta.TabIndex = 6;
            // 
            // ExecuteSetBlockActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 104);
            this.Controls.Add(this.textBoxMeta);
            this.Controls.Add(this._l1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxZ);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.comboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ExecuteSetBlockActionForm";
            this.Text = "Set block";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label _l1;
        private System.Windows.Forms.TextBox textBoxMeta;
    }
}