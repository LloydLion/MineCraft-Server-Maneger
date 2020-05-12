namespace MineCraft_Server_Maneger
{
    partial class InstallServerForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("13634516541342134");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("531464353241");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("15351324532");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("13461234efderdsfg");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("fdgdfsgdfhydfgdf");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("hrthrwftdgfds");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gameVersionLabel = new System.Windows.Forms.Label();
            this.downloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.coreTypeLabel = new System.Windows.Forms.Label();
            this.serverNameATextBox = new System.Windows.Forms.TextBox();
            this._l3 = new System.Windows.Forms.Label();
            this._l2 = new System.Windows.Forms.Label();
            this._l1 = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.versionSelectionListView = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.createServerButton = new System.Windows.Forms.Button();
            this.selectServerFileButton = new System.Windows.Forms.Button();
            this._l6 = new System.Windows.Forms.Label();
            this._l5 = new System.Windows.Forms.Label();
            this._l4 = new System.Windows.Forms.Label();
            this.serverNameMTextBox = new System.Windows.Forms.TextBox();
            this.serverCoreTypeMTextBox = new System.Windows.Forms.TextBox();
            this.serverGameVersionMTextBox = new System.Windows.Forms.TextBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gameVersionLabel);
            this.groupBox1.Controls.Add(this.downloadProgressBar);
            this.groupBox1.Controls.Add(this.coreTypeLabel);
            this.groupBox1.Controls.Add(this.serverNameATextBox);
            this.groupBox1.Controls.Add(this._l3);
            this.groupBox1.Controls.Add(this._l2);
            this.groupBox1.Controls.Add(this._l1);
            this.groupBox1.Controls.Add(this.downloadButton);
            this.groupBox1.Controls.Add(this.versionSelectionListView);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automaticly";
            // 
            // gameVersionLabel
            // 
            this.gameVersionLabel.AutoSize = true;
            this.gameVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gameVersionLabel.Location = new System.Drawing.Point(20, 73);
            this.gameVersionLabel.Name = "gameVersionLabel";
            this.gameVersionLabel.Size = new System.Drawing.Size(96, 13);
            this.gameVersionLabel.TabIndex = 15;
            this.gameVersionLabel.Text = "No server selected";
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Location = new System.Drawing.Point(6, 347);
            this.downloadProgressBar.Maximum = 2000;
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(312, 23);
            this.downloadProgressBar.TabIndex = 14;
            // 
            // coreTypeLabel
            // 
            this.coreTypeLabel.AutoSize = true;
            this.coreTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.coreTypeLabel.Location = new System.Drawing.Point(20, 123);
            this.coreTypeLabel.Name = "coreTypeLabel";
            this.coreTypeLabel.Size = new System.Drawing.Size(96, 13);
            this.coreTypeLabel.TabIndex = 12;
            this.coreTypeLabel.Text = "No server selected";
            // 
            // serverNameATextBox
            // 
            this.serverNameATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.serverNameATextBox.Location = new System.Drawing.Point(6, 218);
            this.serverNameATextBox.Name = "serverNameATextBox";
            this.serverNameATextBox.Size = new System.Drawing.Size(110, 20);
            this.serverNameATextBox.TabIndex = 11;
            // 
            // _l3
            // 
            this._l3.AutoSize = true;
            this._l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this._l3.Location = new System.Drawing.Point(3, 202);
            this._l3.Name = "_l3";
            this._l3.Size = new System.Drawing.Size(39, 13);
            this._l3.TabIndex = 9;
            this._l3.Text = "Name";
            // 
            // _l2
            // 
            this._l2.AutoSize = true;
            this._l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this._l2.Location = new System.Drawing.Point(3, 104);
            this._l2.Name = "_l2";
            this._l2.Size = new System.Drawing.Size(61, 13);
            this._l2.TabIndex = 9;
            this._l2.Text = "Core type";
            // 
            // _l1
            // 
            this._l1.AutoSize = true;
            this._l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this._l1.Location = new System.Drawing.Point(3, 57);
            this._l1.Name = "_l1";
            this._l1.Size = new System.Drawing.Size(84, 13);
            this._l1.TabIndex = 9;
            this._l1.Text = "Game version";
            // 
            // downloadButton
            // 
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.downloadButton.Location = new System.Drawing.Point(6, 304);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(312, 37);
            this.downloadButton.TabIndex = 1;
            this.downloadButton.Text = "Download and Install";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // versionSelectionListView
            // 
            this.versionSelectionListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.versionSelectionListView.HideSelection = false;
            this.versionSelectionListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.versionSelectionListView.Location = new System.Drawing.Point(122, 33);
            this.versionSelectionListView.MultiSelect = false;
            this.versionSelectionListView.Name = "versionSelectionListView";
            this.versionSelectionListView.Size = new System.Drawing.Size(196, 265);
            this.versionSelectionListView.TabIndex = 13;
            this.versionSelectionListView.UseCompatibleStateImageBehavior = false;
            this.versionSelectionListView.View = System.Windows.Forms.View.Tile;
            this.versionSelectionListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.VersionSelectionListView_ItemSelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.createServerButton);
            this.groupBox2.Controls.Add(this.selectServerFileButton);
            this.groupBox2.Controls.Add(this._l6);
            this.groupBox2.Controls.Add(this._l5);
            this.groupBox2.Controls.Add(this._l4);
            this.groupBox2.Controls.Add(this.serverNameMTextBox);
            this.groupBox2.Controls.Add(this.serverCoreTypeMTextBox);
            this.groupBox2.Controls.Add(this.serverGameVersionMTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(343, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 376);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manually";
            // 
            // createServerButton
            // 
            this.createServerButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createServerButton.Location = new System.Drawing.Point(0, 333);
            this.createServerButton.Name = "createServerButton";
            this.createServerButton.Size = new System.Drawing.Size(228, 37);
            this.createServerButton.TabIndex = 8;
            this.createServerButton.Text = "Create";
            this.createServerButton.UseVisualStyleBackColor = true;
            this.createServerButton.Click += new System.EventHandler(this.CreateServerButton_Click);
            // 
            // selectServerFileButton
            // 
            this.selectServerFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.selectServerFileButton.Location = new System.Drawing.Point(6, 218);
            this.selectServerFileButton.Name = "selectServerFileButton";
            this.selectServerFileButton.Size = new System.Drawing.Size(102, 37);
            this.selectServerFileButton.TabIndex = 7;
            this.selectServerFileButton.Text = "Select server file";
            this.selectServerFileButton.UseVisualStyleBackColor = true;
            this.selectServerFileButton.Click += new System.EventHandler(this.SelectServerFileButton_Click);
            // 
            // _l6
            // 
            this._l6.AutoSize = true;
            this._l6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this._l6.Location = new System.Drawing.Point(6, 150);
            this._l6.Name = "_l6";
            this._l6.Size = new System.Drawing.Size(39, 13);
            this._l6.TabIndex = 6;
            this._l6.Text = "Name";
            // 
            // _l5
            // 
            this._l5.AutoSize = true;
            this._l5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this._l5.Location = new System.Drawing.Point(6, 104);
            this._l5.Name = "_l5";
            this._l5.Size = new System.Drawing.Size(61, 13);
            this._l5.TabIndex = 5;
            this._l5.Text = "Core type";
            // 
            // _l4
            // 
            this._l4.AutoSize = true;
            this._l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this._l4.Location = new System.Drawing.Point(6, 57);
            this._l4.Name = "_l4";
            this._l4.Size = new System.Drawing.Size(84, 13);
            this._l4.TabIndex = 4;
            this._l4.Text = "Game version";
            // 
            // serverNameMTextBox
            // 
            this.serverNameMTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.serverNameMTextBox.Location = new System.Drawing.Point(6, 166);
            this.serverNameMTextBox.Name = "serverNameMTextBox";
            this.serverNameMTextBox.Size = new System.Drawing.Size(222, 20);
            this.serverNameMTextBox.TabIndex = 3;
            // 
            // serverCoreTypeMTextBox
            // 
            this.serverCoreTypeMTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.serverCoreTypeMTextBox.Location = new System.Drawing.Point(6, 120);
            this.serverCoreTypeMTextBox.Name = "serverCoreTypeMTextBox";
            this.serverCoreTypeMTextBox.Size = new System.Drawing.Size(222, 20);
            this.serverCoreTypeMTextBox.TabIndex = 2;
            // 
            // serverGameVersionMTextBox
            // 
            this.serverGameVersionMTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.serverGameVersionMTextBox.Location = new System.Drawing.Point(6, 73);
            this.serverGameVersionMTextBox.Name = "serverGameVersionMTextBox";
            this.serverGameVersionMTextBox.Size = new System.Drawing.Size(223, 20);
            this.serverGameVersionMTextBox.TabIndex = 0;
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // InstallServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InstallServerForm";
            this.Text = "Install Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox serverNameMTextBox;
        private System.Windows.Forms.TextBox serverCoreTypeMTextBox;
        private System.Windows.Forms.TextBox serverGameVersionMTextBox;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.ListView versionSelectionListView;
        private System.Windows.Forms.Label coreTypeLabel;
        private System.Windows.Forms.TextBox serverNameATextBox;
        private System.Windows.Forms.Label _l3;
        private System.Windows.Forms.Label _l2;
        private System.Windows.Forms.Label _l1;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button createServerButton;
        private System.Windows.Forms.Button selectServerFileButton;
        private System.Windows.Forms.Label _l6;
        private System.Windows.Forms.Label _l5;
        private System.Windows.Forms.Label _l4;
        private System.Windows.Forms.Label gameVersionLabel;
        private System.Windows.Forms.ProgressBar downloadProgressBar;
    }
}