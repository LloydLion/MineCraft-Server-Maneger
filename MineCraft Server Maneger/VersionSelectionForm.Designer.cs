namespace MineCraft_Server_Maneger
{
    partial class VersionSelectionForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1.12.2"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1.15.2"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "1.1.4.4"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "1.9.4"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            this.versionSelectionList = new System.Windows.Forms.ListView();
            this.selectButton = new System.Windows.Forms.Button();
            this._l4 = new System.Windows.Forms.Label();
            this._l3 = new System.Windows.Forms.Label();
            this.gameVersionLabel = new System.Windows.Forms.Label();
            this._l2 = new System.Windows.Forms.Label();
            this.coreTypeLabel = new System.Windows.Forms.Label();
            this._l1 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.installServerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // versionSelectionList
            // 
            this.versionSelectionList.HideSelection = false;
            this.versionSelectionList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.versionSelectionList.Location = new System.Drawing.Point(12, 60);
            this.versionSelectionList.MultiSelect = false;
            this.versionSelectionList.Name = "versionSelectionList";
            this.versionSelectionList.Size = new System.Drawing.Size(198, 193);
            this.versionSelectionList.TabIndex = 0;
            this.versionSelectionList.UseCompatibleStateImageBehavior = false;
            this.versionSelectionList.View = System.Windows.Forms.View.Tile;
            this.versionSelectionList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.VersionSelectionList_ItemSelectionChanged);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(12, 259);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(312, 32);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // _l4
            // 
            this._l4.AutoSize = true;
            this._l4.Font = new System.Drawing.Font("Meiryo UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._l4.Location = new System.Drawing.Point(12, 9);
            this._l4.Name = "_l4";
            this._l4.Size = new System.Drawing.Size(141, 24);
            this._l4.TabIndex = 2;
            this._l4.Text = "Select Server:";
            // 
            // _l3
            // 
            this._l3.AutoSize = true;
            this._l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._l3.Location = new System.Drawing.Point(217, 60);
            this._l3.Name = "_l3";
            this._l3.Size = new System.Drawing.Size(84, 13);
            this._l3.TabIndex = 3;
            this._l3.Text = "Game version";
            // 
            // gameVersionLabel
            // 
            this.gameVersionLabel.AutoSize = true;
            this.gameVersionLabel.Location = new System.Drawing.Point(217, 84);
            this.gameVersionLabel.Name = "gameVersionLabel";
            this.gameVersionLabel.Size = new System.Drawing.Size(96, 13);
            this.gameVersionLabel.TabIndex = 4;
            this.gameVersionLabel.Text = "No server selected";
            // 
            // _l2
            // 
            this._l2.AutoSize = true;
            this._l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._l2.Location = new System.Drawing.Point(218, 110);
            this._l2.Name = "_l2";
            this._l2.Size = new System.Drawing.Size(61, 13);
            this._l2.TabIndex = 5;
            this._l2.Text = "Core type";
            // 
            // coreTypeLabel
            // 
            this.coreTypeLabel.AutoSize = true;
            this.coreTypeLabel.Location = new System.Drawing.Point(217, 134);
            this.coreTypeLabel.Name = "coreTypeLabel";
            this.coreTypeLabel.Size = new System.Drawing.Size(96, 13);
            this.coreTypeLabel.TabIndex = 6;
            this.coreTypeLabel.Text = "No server selected";
            // 
            // _l1
            // 
            this._l1.AutoSize = true;
            this._l1.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._l1.Location = new System.Drawing.Point(216, 183);
            this._l1.Name = "_l1";
            this._l1.Size = new System.Drawing.Size(50, 19);
            this._l1.TabIndex = 7;
            this._l1.Text = "Error";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.Location = new System.Drawing.Point(218, 206);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(62, 15);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "No errors";
            // 
            // installServerButton
            // 
            this.installServerButton.Location = new System.Drawing.Point(220, 12);
            this.installServerButton.Name = "installServerButton";
            this.installServerButton.Size = new System.Drawing.Size(104, 24);
            this.installServerButton.TabIndex = 11;
            this.installServerButton.Text = "Install Server";
            this.installServerButton.UseVisualStyleBackColor = true;
            this.installServerButton.Click += new System.EventHandler(this.InstallServerButton_Click);
            // 
            // VersionSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 303);
            this.Controls.Add(this.installServerButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this._l1);
            this.Controls.Add(this.coreTypeLabel);
            this.Controls.Add(this._l2);
            this.Controls.Add(this.gameVersionLabel);
            this.Controls.Add(this._l3);
            this.Controls.Add(this._l4);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.versionSelectionList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VersionSelectionForm";
            this.Text = "Version Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView versionSelectionList;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label _l4;
        private System.Windows.Forms.Label _l3;
        private System.Windows.Forms.Label gameVersionLabel;
        private System.Windows.Forms.Label _l2;
        private System.Windows.Forms.Label coreTypeLabel;
        private System.Windows.Forms.Label _l1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button installServerButton;
    }
}