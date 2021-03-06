﻿namespace MineCraft_Server_Maneger
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.filtratedPlayersListView = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.actionsBanPlayerButton = new System.Windows.Forms.Button();
			this.actionsKickPlayerButton = new System.Windows.Forms.Button();
			this.actionsKillPlayerButton = new System.Windows.Forms.Button();
			this.actionsOpPlayerButton = new System.Windows.Forms.Button();
			this.actionsGamemodePlayerButton = new System.Windows.Forms.Button();
			this.actionsTpPlayerButton = new System.Windows.Forms.Button();
			this.filterOnlineButton = new System.Windows.Forms.Button();
			this.filterWhitelistButton = new System.Windows.Forms.Button();
			this.filterBannedButton = new System.Windows.Forms.Button();
			this.filterOperatorButton = new System.Windows.Forms.Button();
			this.filterGamemodeButton = new System.Windows.Forms.Button();
			this.filterFavoriteButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.commandsInputTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.commandsOutputTextBox = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.commandsExecuteDifficultyButton = new System.Windows.Forms.Button();
			this.commandsExecuteWeatherButton = new System.Windows.Forms.Button();
			this.commandsExecuteLocateButton = new System.Windows.Forms.Button();
			this.commandsExecuteXpButton = new System.Windows.Forms.Button();
			this.commandsExecuteGameruleButton = new System.Windows.Forms.Button();
			this.commandsExecuteSayButton = new System.Windows.Forms.Button();
			this.commandsExecuteClearButton = new System.Windows.Forms.Button();
			this.commandsExecuteTimeButton = new System.Windows.Forms.Button();
			this.commandsExecuteEffectButton = new System.Windows.Forms.Button();
			this.commonStartServerButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.commonRestartServerButton = new System.Windows.Forms.Button();
			this.commonStopServerButton = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.settingsOpenPluginManegerButton = new System.Windows.Forms.Button();
			this.settingsOpenWorldManegerButton = new System.Windows.Forms.Button();
			this.settingsOpenServerPropertiesButton = new System.Windows.Forms.Button();
			this.commandsRunButton = new System.Windows.Forms.Button();
			this.otherOpenConsoleButton = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.otherResetSettingsButton = new System.Windows.Forms.Button();
			this.otherOpenServerDirectoryButton = new System.Windows.Forms.Button();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// filtratedPlayersListView
			// 
			this.filtratedPlayersListView.HideSelection = false;
			this.filtratedPlayersListView.Location = new System.Drawing.Point(497, 161);
			this.filtratedPlayersListView.Name = "filtratedPlayersListView";
			this.filtratedPlayersListView.Size = new System.Drawing.Size(195, 200);
			this.filtratedPlayersListView.TabIndex = 0;
			this.filtratedPlayersListView.UseCompatibleStateImageBehavior = false;
			this.filtratedPlayersListView.View = System.Windows.Forms.View.Tile;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(480, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Players";
			// 
			// actionsBanPlayerButton
			// 
			this.actionsBanPlayerButton.Location = new System.Drawing.Point(6, 19);
			this.actionsBanPlayerButton.Name = "actionsBanPlayerButton";
			this.actionsBanPlayerButton.Size = new System.Drawing.Size(75, 23);
			this.actionsBanPlayerButton.TabIndex = 2;
			this.actionsBanPlayerButton.Text = "Ban";
			this.actionsBanPlayerButton.UseVisualStyleBackColor = true;
			// 
			// actionsKickPlayerButton
			// 
			this.actionsKickPlayerButton.Location = new System.Drawing.Point(114, 19);
			this.actionsKickPlayerButton.Name = "actionsKickPlayerButton";
			this.actionsKickPlayerButton.Size = new System.Drawing.Size(75, 23);
			this.actionsKickPlayerButton.TabIndex = 3;
			this.actionsKickPlayerButton.Text = "Kick";
			this.actionsKickPlayerButton.UseVisualStyleBackColor = true;
			// 
			// actionsKillPlayerButton
			// 
			this.actionsKillPlayerButton.Location = new System.Drawing.Point(6, 49);
			this.actionsKillPlayerButton.Name = "actionsKillPlayerButton";
			this.actionsKillPlayerButton.Size = new System.Drawing.Size(75, 23);
			this.actionsKillPlayerButton.TabIndex = 4;
			this.actionsKillPlayerButton.Text = "Kill";
			this.actionsKillPlayerButton.UseVisualStyleBackColor = true;
			// 
			// actionsOpPlayerButton
			// 
			this.actionsOpPlayerButton.Location = new System.Drawing.Point(114, 50);
			this.actionsOpPlayerButton.Name = "actionsOpPlayerButton";
			this.actionsOpPlayerButton.Size = new System.Drawing.Size(75, 23);
			this.actionsOpPlayerButton.TabIndex = 5;
			this.actionsOpPlayerButton.Text = "Operator";
			this.actionsOpPlayerButton.UseVisualStyleBackColor = true;
			// 
			// actionsGamemodePlayerButton
			// 
			this.actionsGamemodePlayerButton.Location = new System.Drawing.Point(114, 79);
			this.actionsGamemodePlayerButton.Name = "actionsGamemodePlayerButton";
			this.actionsGamemodePlayerButton.Size = new System.Drawing.Size(75, 23);
			this.actionsGamemodePlayerButton.TabIndex = 7;
			this.actionsGamemodePlayerButton.Text = "Gamemode";
			this.actionsGamemodePlayerButton.UseVisualStyleBackColor = true;
			// 
			// actionsTpPlayerButton
			// 
			this.actionsTpPlayerButton.Location = new System.Drawing.Point(6, 79);
			this.actionsTpPlayerButton.Name = "actionsTpPlayerButton";
			this.actionsTpPlayerButton.Size = new System.Drawing.Size(75, 23);
			this.actionsTpPlayerButton.TabIndex = 6;
			this.actionsTpPlayerButton.Text = "Teleport";
			this.actionsTpPlayerButton.UseVisualStyleBackColor = true;
			// 
			// filterOnlineButton
			// 
			this.filterOnlineButton.Location = new System.Drawing.Point(6, 19);
			this.filterOnlineButton.Name = "filterOnlineButton";
			this.filterOnlineButton.Size = new System.Drawing.Size(75, 23);
			this.filterOnlineButton.TabIndex = 8;
			this.filterOnlineButton.Text = "Online";
			this.filterOnlineButton.UseVisualStyleBackColor = true;
			// 
			// filterWhitelistButton
			// 
			this.filterWhitelistButton.Location = new System.Drawing.Point(114, 19);
			this.filterWhitelistButton.Name = "filterWhitelistButton";
			this.filterWhitelistButton.Size = new System.Drawing.Size(75, 23);
			this.filterWhitelistButton.TabIndex = 9;
			this.filterWhitelistButton.Text = "Whitelist";
			this.filterWhitelistButton.UseVisualStyleBackColor = true;
			// 
			// filterBannedButton
			// 
			this.filterBannedButton.Location = new System.Drawing.Point(6, 48);
			this.filterBannedButton.Name = "filterBannedButton";
			this.filterBannedButton.Size = new System.Drawing.Size(75, 23);
			this.filterBannedButton.TabIndex = 10;
			this.filterBannedButton.Text = "Banned";
			this.filterBannedButton.UseVisualStyleBackColor = true;
			// 
			// filterOperatorButton
			// 
			this.filterOperatorButton.Location = new System.Drawing.Point(114, 51);
			this.filterOperatorButton.Name = "filterOperatorButton";
			this.filterOperatorButton.Size = new System.Drawing.Size(75, 23);
			this.filterOperatorButton.TabIndex = 11;
			this.filterOperatorButton.Text = "Operators";
			this.filterOperatorButton.UseVisualStyleBackColor = true;
			// 
			// filterGamemodeButton
			// 
			this.filterGamemodeButton.Location = new System.Drawing.Point(6, 80);
			this.filterGamemodeButton.Name = "filterGamemodeButton";
			this.filterGamemodeButton.Size = new System.Drawing.Size(75, 23);
			this.filterGamemodeButton.TabIndex = 12;
			this.filterGamemodeButton.Text = "Gamemode";
			this.filterGamemodeButton.UseVisualStyleBackColor = true;
			// 
			// filterFavoriteButton
			// 
			this.filterFavoriteButton.Location = new System.Drawing.Point(114, 80);
			this.filterFavoriteButton.Name = "filterFavoriteButton";
			this.filterFavoriteButton.Size = new System.Drawing.Size(75, 23);
			this.filterFavoriteButton.TabIndex = 13;
			this.filterFavoriteButton.Text = "Favorite";
			this.filterFavoriteButton.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.filterOnlineButton);
			this.groupBox1.Controls.Add(this.filterFavoriteButton);
			this.groupBox1.Controls.Add(this.filterWhitelistButton);
			this.groupBox1.Controls.Add(this.filterBannedButton);
			this.groupBox1.Controls.Add(this.filterGamemodeButton);
			this.groupBox1.Controls.Add(this.filterOperatorButton);
			this.groupBox1.Location = new System.Drawing.Point(497, 37);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(195, 118);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filter";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.actionsBanPlayerButton);
			this.groupBox2.Controls.Add(this.actionsKickPlayerButton);
			this.groupBox2.Controls.Add(this.actionsTpPlayerButton);
			this.groupBox2.Controls.Add(this.actionsKillPlayerButton);
			this.groupBox2.Controls.Add(this.actionsGamemodePlayerButton);
			this.groupBox2.Controls.Add(this.actionsOpPlayerButton);
			this.groupBox2.Location = new System.Drawing.Point(497, 367);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(195, 118);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Actions";
			// 
			// commandsInputTextBox
			// 
			this.commandsInputTextBox.Location = new System.Drawing.Point(15, 457);
			this.commandsInputTextBox.Name = "commandsInputTextBox";
			this.commandsInputTextBox.Size = new System.Drawing.Size(424, 20);
			this.commandsInputTextBox.TabIndex = 16;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(10, 161);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(175, 25);
			this.label2.TabIndex = 18;
			this.label2.Text = "Execute command";
			// 
			// commandsOutputTextBox
			// 
			this.commandsOutputTextBox.Location = new System.Drawing.Point(15, 311);
			this.commandsOutputTextBox.Multiline = true;
			this.commandsOutputTextBox.Name = "commandsOutputTextBox";
			this.commandsOutputTextBox.ReadOnly = true;
			this.commandsOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.commandsOutputTextBox.Size = new System.Drawing.Size(467, 140);
			this.commandsOutputTextBox.TabIndex = 17;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.commandsExecuteDifficultyButton);
			this.groupBox3.Controls.Add(this.commandsExecuteWeatherButton);
			this.groupBox3.Controls.Add(this.commandsExecuteLocateButton);
			this.groupBox3.Controls.Add(this.commandsExecuteXpButton);
			this.groupBox3.Controls.Add(this.commandsExecuteGameruleButton);
			this.groupBox3.Controls.Add(this.commandsExecuteSayButton);
			this.groupBox3.Controls.Add(this.commandsExecuteClearButton);
			this.groupBox3.Controls.Add(this.commandsExecuteTimeButton);
			this.groupBox3.Controls.Add(this.commandsExecuteEffectButton);
			this.groupBox3.Location = new System.Drawing.Point(15, 192);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(467, 113);
			this.groupBox3.TabIndex = 19;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Commands";
			// 
			// commandsExecuteDifficultyButton
			// 
			this.commandsExecuteDifficultyButton.Location = new System.Drawing.Point(312, 77);
			this.commandsExecuteDifficultyButton.Name = "commandsExecuteDifficultyButton";
			this.commandsExecuteDifficultyButton.Size = new System.Drawing.Size(149, 23);
			this.commandsExecuteDifficultyButton.TabIndex = 8;
			this.commandsExecuteDifficultyButton.Text = "Difficulty";
			this.commandsExecuteDifficultyButton.UseVisualStyleBackColor = true;
			// 
			// commandsExecuteWeatherButton
			// 
			this.commandsExecuteWeatherButton.Location = new System.Drawing.Point(159, 77);
			this.commandsExecuteWeatherButton.Name = "commandsExecuteWeatherButton";
			this.commandsExecuteWeatherButton.Size = new System.Drawing.Size(149, 23);
			this.commandsExecuteWeatherButton.TabIndex = 5;
			this.commandsExecuteWeatherButton.Text = "Weather";
			this.commandsExecuteWeatherButton.UseVisualStyleBackColor = true;
			// 
			// commandsExecuteLocateButton
			// 
			this.commandsExecuteLocateButton.Location = new System.Drawing.Point(312, 48);
			this.commandsExecuteLocateButton.Name = "commandsExecuteLocateButton";
			this.commandsExecuteLocateButton.Size = new System.Drawing.Size(149, 23);
			this.commandsExecuteLocateButton.TabIndex = 7;
			this.commandsExecuteLocateButton.Text = "Locate";
			this.commandsExecuteLocateButton.UseVisualStyleBackColor = true;
			// 
			// commandsExecuteXpButton
			// 
			this.commandsExecuteXpButton.Location = new System.Drawing.Point(312, 19);
			this.commandsExecuteXpButton.Name = "commandsExecuteXpButton";
			this.commandsExecuteXpButton.Size = new System.Drawing.Size(149, 23);
			this.commandsExecuteXpButton.TabIndex = 6;
			this.commandsExecuteXpButton.Text = "Expirience";
			this.commandsExecuteXpButton.UseVisualStyleBackColor = true;
			// 
			// commandsExecuteGameruleButton
			// 
			this.commandsExecuteGameruleButton.Location = new System.Drawing.Point(159, 48);
			this.commandsExecuteGameruleButton.Name = "commandsExecuteGameruleButton";
			this.commandsExecuteGameruleButton.Size = new System.Drawing.Size(149, 23);
			this.commandsExecuteGameruleButton.TabIndex = 4;
			this.commandsExecuteGameruleButton.Text = "Gamerule";
			this.commandsExecuteGameruleButton.UseVisualStyleBackColor = true;
			// 
			// commandsExecuteSayButton
			// 
			this.commandsExecuteSayButton.Location = new System.Drawing.Point(159, 19);
			this.commandsExecuteSayButton.Name = "commandsExecuteSayButton";
			this.commandsExecuteSayButton.Size = new System.Drawing.Size(149, 23);
			this.commandsExecuteSayButton.TabIndex = 3;
			this.commandsExecuteSayButton.Text = "Say";
			this.commandsExecuteSayButton.UseVisualStyleBackColor = true;
			// 
			// commandsExecuteClearButton
			// 
			this.commandsExecuteClearButton.Location = new System.Drawing.Point(7, 77);
			this.commandsExecuteClearButton.Name = "commandsExecuteClearButton";
			this.commandsExecuteClearButton.Size = new System.Drawing.Size(149, 23);
			this.commandsExecuteClearButton.TabIndex = 2;
			this.commandsExecuteClearButton.Text = "Clear";
			this.commandsExecuteClearButton.UseVisualStyleBackColor = true;
			// 
			// commandsExecuteTimeButton
			// 
			this.commandsExecuteTimeButton.Location = new System.Drawing.Point(6, 48);
			this.commandsExecuteTimeButton.Name = "commandsExecuteTimeButton";
			this.commandsExecuteTimeButton.Size = new System.Drawing.Size(150, 23);
			this.commandsExecuteTimeButton.TabIndex = 1;
			this.commandsExecuteTimeButton.Text = "Time";
			this.commandsExecuteTimeButton.UseVisualStyleBackColor = true;
			// 
			// commandsExecuteEffectButton
			// 
			this.commandsExecuteEffectButton.Location = new System.Drawing.Point(7, 19);
			this.commandsExecuteEffectButton.Name = "commandsExecuteEffectButton";
			this.commandsExecuteEffectButton.Size = new System.Drawing.Size(149, 23);
			this.commandsExecuteEffectButton.TabIndex = 0;
			this.commandsExecuteEffectButton.Text = "Effect";
			this.commandsExecuteEffectButton.UseVisualStyleBackColor = true;
			// 
			// commonStartServerButton
			// 
			this.commonStartServerButton.Location = new System.Drawing.Point(6, 19);
			this.commonStartServerButton.Name = "commonStartServerButton";
			this.commonStartServerButton.Size = new System.Drawing.Size(75, 23);
			this.commonStartServerButton.TabIndex = 20;
			this.commonStartServerButton.Text = "Start";
			this.commonStartServerButton.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(10, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 25);
			this.label3.TabIndex = 21;
			this.label3.Text = "Control";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.commonRestartServerButton);
			this.groupBox4.Controls.Add(this.commonStopServerButton);
			this.groupBox4.Controls.Add(this.commonStartServerButton);
			this.groupBox4.Location = new System.Drawing.Point(15, 48);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(87, 110);
			this.groupBox4.TabIndex = 22;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Common";
			// 
			// commonRestartServerButton
			// 
			this.commonRestartServerButton.Location = new System.Drawing.Point(6, 77);
			this.commonRestartServerButton.Name = "commonRestartServerButton";
			this.commonRestartServerButton.Size = new System.Drawing.Size(75, 23);
			this.commonRestartServerButton.TabIndex = 22;
			this.commonRestartServerButton.Text = "Restart";
			this.commonRestartServerButton.UseVisualStyleBackColor = true;
			// 
			// commonStopServerButton
			// 
			this.commonStopServerButton.Location = new System.Drawing.Point(6, 48);
			this.commonStopServerButton.Name = "commonStopServerButton";
			this.commonStopServerButton.Size = new System.Drawing.Size(75, 23);
			this.commonStopServerButton.TabIndex = 21;
			this.commonStopServerButton.Text = "Stop";
			this.commonStopServerButton.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.settingsOpenPluginManegerButton);
			this.groupBox5.Controls.Add(this.settingsOpenWorldManegerButton);
			this.groupBox5.Controls.Add(this.settingsOpenServerPropertiesButton);
			this.groupBox5.Location = new System.Drawing.Point(123, 48);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(189, 110);
			this.groupBox5.TabIndex = 23;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Settings";
			// 
			// settingsOpenPluginManegerButton
			// 
			this.settingsOpenPluginManegerButton.Location = new System.Drawing.Point(6, 77);
			this.settingsOpenPluginManegerButton.Name = "settingsOpenPluginManegerButton";
			this.settingsOpenPluginManegerButton.Size = new System.Drawing.Size(177, 23);
			this.settingsOpenPluginManegerButton.TabIndex = 2;
			this.settingsOpenPluginManegerButton.Text = "Plugin Maneger";
			this.settingsOpenPluginManegerButton.UseVisualStyleBackColor = true;
			// 
			// settingsOpenWorldManegerButton
			// 
			this.settingsOpenWorldManegerButton.Location = new System.Drawing.Point(6, 48);
			this.settingsOpenWorldManegerButton.Name = "settingsOpenWorldManegerButton";
			this.settingsOpenWorldManegerButton.Size = new System.Drawing.Size(177, 23);
			this.settingsOpenWorldManegerButton.TabIndex = 1;
			this.settingsOpenWorldManegerButton.Text = "World Maneger";
			this.settingsOpenWorldManegerButton.UseVisualStyleBackColor = true;
			// 
			// settingsOpenServerPropertiesButton
			// 
			this.settingsOpenServerPropertiesButton.Location = new System.Drawing.Point(6, 19);
			this.settingsOpenServerPropertiesButton.Name = "settingsOpenServerPropertiesButton";
			this.settingsOpenServerPropertiesButton.Size = new System.Drawing.Size(177, 23);
			this.settingsOpenServerPropertiesButton.TabIndex = 0;
			this.settingsOpenServerPropertiesButton.Text = "Open Server Properties";
			this.settingsOpenServerPropertiesButton.UseVisualStyleBackColor = true;
			// 
			// commandsRunButton
			// 
			this.commandsRunButton.Location = new System.Drawing.Point(445, 457);
			this.commandsRunButton.Name = "commandsRunButton";
			this.commandsRunButton.Size = new System.Drawing.Size(37, 20);
			this.commandsRunButton.TabIndex = 25;
			this.commandsRunButton.Text = "Run";
			this.commandsRunButton.UseVisualStyleBackColor = true;
			// 
			// otherOpenConsoleButton
			// 
			this.otherOpenConsoleButton.Location = new System.Drawing.Point(7, 19);
			this.otherOpenConsoleButton.Name = "otherOpenConsoleButton";
			this.otherOpenConsoleButton.Size = new System.Drawing.Size(136, 23);
			this.otherOpenConsoleButton.TabIndex = 0;
			this.otherOpenConsoleButton.Text = "Open Console";
			this.otherOpenConsoleButton.UseVisualStyleBackColor = true;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.otherResetSettingsButton);
			this.groupBox6.Controls.Add(this.otherOpenServerDirectoryButton);
			this.groupBox6.Controls.Add(this.otherOpenConsoleButton);
			this.groupBox6.Location = new System.Drawing.Point(327, 48);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(149, 107);
			this.groupBox6.TabIndex = 24;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Other";
			// 
			// otherResetSettingsButton
			// 
			this.otherResetSettingsButton.Location = new System.Drawing.Point(7, 77);
			this.otherResetSettingsButton.Name = "otherResetSettingsButton";
			this.otherResetSettingsButton.Size = new System.Drawing.Size(136, 23);
			this.otherResetSettingsButton.TabIndex = 2;
			this.otherResetSettingsButton.Text = "Reset Settings";
			this.otherResetSettingsButton.UseVisualStyleBackColor = true;
			// 
			// otherOpenServerDirectoryButton
			// 
			this.otherOpenServerDirectoryButton.Location = new System.Drawing.Point(7, 48);
			this.otherOpenServerDirectoryButton.Name = "otherOpenServerDirectoryButton";
			this.otherOpenServerDirectoryButton.Size = new System.Drawing.Size(136, 23);
			this.otherOpenServerDirectoryButton.TabIndex = 1;
			this.otherOpenServerDirectoryButton.Text = "Open Server Directory";
			this.otherOpenServerDirectoryButton.UseVisualStyleBackColor = true;
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 10000;
			this.timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(704, 489);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.commandsRunButton);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.commandsOutputTextBox);
			this.Controls.Add(this.commandsInputTextBox);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.filtratedPlayersListView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Server Maneger";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView filtratedPlayersListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button actionsBanPlayerButton;
        private System.Windows.Forms.Button actionsKickPlayerButton;
        private System.Windows.Forms.Button actionsKillPlayerButton;
        private System.Windows.Forms.Button actionsOpPlayerButton;
        private System.Windows.Forms.Button actionsGamemodePlayerButton;
        private System.Windows.Forms.Button actionsTpPlayerButton;
        private System.Windows.Forms.Button filterOnlineButton;
        private System.Windows.Forms.Button filterWhitelistButton;
        private System.Windows.Forms.Button filterBannedButton;
        private System.Windows.Forms.Button filterOperatorButton;
        private System.Windows.Forms.Button filterGamemodeButton;
        private System.Windows.Forms.Button filterFavoriteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox commandsInputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox commandsOutputTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button commandsExecuteDifficultyButton;
        private System.Windows.Forms.Button commandsExecuteWeatherButton;
        private System.Windows.Forms.Button commandsExecuteLocateButton;
        private System.Windows.Forms.Button commandsExecuteXpButton;
        private System.Windows.Forms.Button commandsExecuteGameruleButton;
        private System.Windows.Forms.Button commandsExecuteSayButton;
        private System.Windows.Forms.Button commandsExecuteClearButton;
        private System.Windows.Forms.Button commandsExecuteTimeButton;
        private System.Windows.Forms.Button commandsExecuteEffectButton;
        private System.Windows.Forms.Button commonStartServerButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button commonRestartServerButton;
        private System.Windows.Forms.Button commonStopServerButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button settingsOpenPluginManegerButton;
        private System.Windows.Forms.Button settingsOpenWorldManegerButton;
        private System.Windows.Forms.Button settingsOpenServerPropertiesButton;
        private System.Windows.Forms.Button commandsRunButton;
        private System.Windows.Forms.Button otherOpenConsoleButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button otherResetSettingsButton;
        private System.Windows.Forms.Button otherOpenServerDirectoryButton;
        private System.Windows.Forms.Timer timer;
    }
}

