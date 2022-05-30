namespace Guilty_Gear_Strive_Mod_Manager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnPlayWith = new System.Windows.Forms.Button();
            this.BtnMods = new System.Windows.Forms.Button();
            this.BtnOptions = new System.Windows.Forms.Button();
            this.BtnGitHub = new System.Windows.Forms.Button();
            this.ModPanel = new System.Windows.Forms.Panel();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.labelDisabled = new System.Windows.Forms.Label();
            this.labelEnabled = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.EnabledModListBox = new System.Windows.Forms.FlowLayoutPanel();
            this.DisabledModListBox = new System.Windows.Forms.FlowLayoutPanel();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.labelOptions = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OptionsPackPath = new System.Windows.Forms.TextBox();
            this.labelGamePath = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelHideForm = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelStartWith = new System.Windows.Forms.Label();
            this.OptionsListStartWith = new System.Windows.Forms.ListBox();
            this.ProcessAdd = new System.Windows.Forms.Button();
            this.ProcessRemove = new System.Windows.Forms.Button();
            this.CheckHideOnPlay = new Guilty_Gear_Strive_MM.MyCheckBox();
            this.BtnGameBanana = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.ModPanel.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.BtnPlay);
            this.flowLayoutPanel1.Controls.Add(this.BtnPlayWith);
            this.flowLayoutPanel1.Controls.Add(this.BtnMods);
            this.flowLayoutPanel1.Controls.Add(this.BtnOptions);
            this.flowLayoutPanel1.Controls.Add(this.BtnGitHub);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(267, 681);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // BtnPlay
            // 
            this.BtnPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPlay.FlatAppearance.BorderSize = 0;
            this.BtnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F);
            this.BtnPlay.ForeColor = System.Drawing.Color.White;
            this.BtnPlay.Location = new System.Drawing.Point(3, 23);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(263, 119);
            this.BtnPlay.TabIndex = 0;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseCompatibleTextRendering = true;
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnPlayWith
            // 
            this.BtnPlayWith.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnPlayWith.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnPlayWith.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPlayWith.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPlayWith.FlatAppearance.BorderSize = 0;
            this.BtnPlayWith.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnPlayWith.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnPlayWith.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.BtnPlayWith.ForeColor = System.Drawing.Color.White;
            this.BtnPlayWith.Location = new System.Drawing.Point(3, 148);
            this.BtnPlayWith.Name = "BtnPlayWith";
            this.BtnPlayWith.Size = new System.Drawing.Size(263, 119);
            this.BtnPlayWith.TabIndex = 3;
            this.BtnPlayWith.Text = "Play With";
            this.BtnPlayWith.UseCompatibleTextRendering = true;
            this.BtnPlayWith.UseVisualStyleBackColor = false;
            this.BtnPlayWith.Click += new System.EventHandler(this.BtnPlayWith_Click);
            // 
            // BtnMods
            // 
            this.BtnMods.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnMods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnMods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMods.FlatAppearance.BorderSize = 0;
            this.BtnMods.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnMods.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnMods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMods.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F);
            this.BtnMods.ForeColor = System.Drawing.Color.White;
            this.BtnMods.Location = new System.Drawing.Point(3, 273);
            this.BtnMods.Name = "BtnMods";
            this.BtnMods.Size = new System.Drawing.Size(263, 119);
            this.BtnMods.TabIndex = 1;
            this.BtnMods.Text = "Mods";
            this.BtnMods.UseCompatibleTextRendering = true;
            this.BtnMods.UseVisualStyleBackColor = false;
            this.BtnMods.Click += new System.EventHandler(this.BtnMods_Click);
            // 
            // BtnOptions
            // 
            this.BtnOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOptions.FlatAppearance.BorderSize = 0;
            this.BtnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 49F);
            this.BtnOptions.ForeColor = System.Drawing.Color.White;
            this.BtnOptions.Location = new System.Drawing.Point(3, 398);
            this.BtnOptions.Name = "BtnOptions";
            this.BtnOptions.Size = new System.Drawing.Size(263, 119);
            this.BtnOptions.TabIndex = 4;
            this.BtnOptions.Text = "Options";
            this.BtnOptions.UseCompatibleTextRendering = true;
            this.BtnOptions.UseVisualStyleBackColor = false;
            this.BtnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // BtnGitHub
            // 
            this.BtnGitHub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnGitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGitHub.FlatAppearance.BorderSize = 0;
            this.BtnGitHub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnGitHub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 56F);
            this.BtnGitHub.ForeColor = System.Drawing.Color.White;
            this.BtnGitHub.Location = new System.Drawing.Point(3, 523);
            this.BtnGitHub.Name = "BtnGitHub";
            this.BtnGitHub.Size = new System.Drawing.Size(263, 119);
            this.BtnGitHub.TabIndex = 2;
            this.BtnGitHub.Text = "Github";
            this.BtnGitHub.UseCompatibleTextRendering = true;
            this.BtnGitHub.UseVisualStyleBackColor = false;
            this.BtnGitHub.Click += new System.EventHandler(this.BtnGitHub_Click);
            // 
            // ModPanel
            // 
            this.ModPanel.BackColor = System.Drawing.Color.Transparent;
            this.ModPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ModPanel.Controls.Add(this.BtnGameBanana);
            this.ModPanel.Controls.Add(this.BtnOpen);
            this.ModPanel.Controls.Add(this.BtnRefresh);
            this.ModPanel.Controls.Add(this.labelDisabled);
            this.ModPanel.Controls.Add(this.labelEnabled);
            this.ModPanel.Controls.Add(this.BtnAdd);
            this.ModPanel.Controls.Add(this.EnabledModListBox);
            this.ModPanel.Controls.Add(this.DisabledModListBox);
            this.ModPanel.Location = new System.Drawing.Point(273, 0);
            this.ModPanel.Name = "ModPanel";
            this.ModPanel.Size = new System.Drawing.Size(991, 681);
            this.ModPanel.TabIndex = 1;
            this.ModPanel.Visible = false;
            // 
            // BtnOpen
            // 
            this.BtnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOpen.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnOpen.ForeColor = System.Drawing.Color.White;
            this.BtnOpen.Location = new System.Drawing.Point(358, 623);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(255, 46);
            this.BtnOpen.TabIndex = 9;
            this.BtnOpen.Text = "Open Folder";
            this.BtnOpen.UseCompatibleTextRendering = true;
            this.BtnOpen.UseVisualStyleBackColor = false;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnRefresh.ForeColor = System.Drawing.Color.White;
            this.BtnRefresh.Location = new System.Drawing.Point(155, 623);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(197, 46);
            this.BtnRefresh.TabIndex = 8;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseCompatibleTextRendering = true;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // labelDisabled
            // 
            this.labelDisabled.AutoSize = true;
            this.labelDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.labelDisabled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDisabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisabled.ForeColor = System.Drawing.Color.White;
            this.labelDisabled.Location = new System.Drawing.Point(12, 314);
            this.labelDisabled.Name = "labelDisabled";
            this.labelDisabled.Size = new System.Drawing.Size(195, 33);
            this.labelDisabled.TabIndex = 6;
            this.labelDisabled.Text = "Disabled Mods";
            this.labelDisabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEnabled
            // 
            this.labelEnabled.AutoSize = true;
            this.labelEnabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.labelEnabled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEnabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnabled.ForeColor = System.Drawing.Color.White;
            this.labelEnabled.Location = new System.Drawing.Point(12, 11);
            this.labelEnabled.Name = "labelEnabled";
            this.labelEnabled.Size = new System.Drawing.Size(188, 33);
            this.labelEnabled.TabIndex = 5;
            this.labelEnabled.Text = "Enabled Mods";
            this.labelEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(17, 623);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(132, 46);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseCompatibleTextRendering = true;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // EnabledModListBox
            // 
            this.EnabledModListBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EnabledModListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.EnabledModListBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnabledModListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnabledModListBox.Location = new System.Drawing.Point(17, 32);
            this.EnabledModListBox.Name = "EnabledModListBox";
            this.EnabledModListBox.Size = new System.Drawing.Size(956, 279);
            this.EnabledModListBox.TabIndex = 0;
            // 
            // DisabledModListBox
            // 
            this.DisabledModListBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DisabledModListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.DisabledModListBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DisabledModListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisabledModListBox.Location = new System.Drawing.Point(17, 335);
            this.DisabledModListBox.Name = "DisabledModListBox";
            this.DisabledModListBox.Size = new System.Drawing.Size(956, 282);
            this.DisabledModListBox.TabIndex = 0;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 500;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.OptionsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OptionsPanel.Controls.Add(this.labelOptions);
            this.OptionsPanel.Controls.Add(this.flowLayoutPanel2);
            this.OptionsPanel.Location = new System.Drawing.Point(273, 0);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(991, 681);
            this.OptionsPanel.TabIndex = 10;
            this.OptionsPanel.Visible = false;
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.labelOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptions.ForeColor = System.Drawing.Color.White;
            this.labelOptions.Location = new System.Drawing.Point(12, 11);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(110, 33);
            this.labelOptions.TabIndex = 5;
            this.labelOptions.Text = "Options";
            this.labelOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(17, 32);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(956, 439);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OptionsPackPath);
            this.panel1.Controls.Add(this.labelGamePath);
            this.panel1.Location = new System.Drawing.Point(3, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 63);
            this.panel1.TabIndex = 1;
            // 
            // OptionsPackPath
            // 
            this.OptionsPackPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.OptionsPackPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionsPackPath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OptionsPackPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsPackPath.ForeColor = System.Drawing.Color.White;
            this.OptionsPackPath.Location = new System.Drawing.Point(0, 40);
            this.OptionsPackPath.Name = "OptionsPackPath";
            this.OptionsPackPath.Size = new System.Drawing.Size(939, 23);
            this.OptionsPackPath.TabIndex = 7;
            this.OptionsPackPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OptionsPackPath.TextChanged += new System.EventHandler(this.OptionsPackPath_TextChanged);
            // 
            // labelGamePath
            // 
            this.labelGamePath.AutoSize = true;
            this.labelGamePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.labelGamePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGamePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGamePath.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelGamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGamePath.ForeColor = System.Drawing.Color.White;
            this.labelGamePath.Location = new System.Drawing.Point(0, 0);
            this.labelGamePath.Name = "labelGamePath";
            this.labelGamePath.Size = new System.Drawing.Size(145, 33);
            this.labelGamePath.TabIndex = 6;
            this.labelGamePath.Text = "Mods Path";
            this.labelGamePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelHideForm);
            this.panel2.Controls.Add(this.CheckHideOnPlay);
            this.panel2.Location = new System.Drawing.Point(3, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 64);
            this.panel2.TabIndex = 8;
            // 
            // labelHideForm
            // 
            this.labelHideForm.AutoSize = true;
            this.labelHideForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.labelHideForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHideForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHideForm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelHideForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHideForm.ForeColor = System.Drawing.Color.White;
            this.labelHideForm.Location = new System.Drawing.Point(0, 0);
            this.labelHideForm.Name = "labelHideForm";
            this.labelHideForm.Size = new System.Drawing.Size(175, 33);
            this.labelHideForm.TabIndex = 6;
            this.labelHideForm.Text = "Hide On Play";
            this.labelHideForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ProcessRemove);
            this.panel3.Controls.Add(this.OptionsListStartWith);
            this.panel3.Controls.Add(this.labelStartWith);
            this.panel3.Controls.Add(this.ProcessAdd);
            this.panel3.Location = new System.Drawing.Point(3, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 272);
            this.panel3.TabIndex = 9;
            // 
            // labelStartWith
            // 
            this.labelStartWith.AutoSize = true;
            this.labelStartWith.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.labelStartWith.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStartWith.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelStartWith.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelStartWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartWith.ForeColor = System.Drawing.Color.White;
            this.labelStartWith.Location = new System.Drawing.Point(0, 0);
            this.labelStartWith.Name = "labelStartWith";
            this.labelStartWith.Size = new System.Drawing.Size(159, 33);
            this.labelStartWith.TabIndex = 6;
            this.labelStartWith.Text = "Start With...";
            this.labelStartWith.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OptionsListStartWith
            // 
            this.OptionsListStartWith.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.OptionsListStartWith.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionsListStartWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsListStartWith.ForeColor = System.Drawing.Color.White;
            this.OptionsListStartWith.FormattingEnabled = true;
            this.OptionsListStartWith.ItemHeight = 25;
            this.OptionsListStartWith.Location = new System.Drawing.Point(3, 54);
            this.OptionsListStartWith.Name = "OptionsListStartWith";
            this.OptionsListStartWith.Size = new System.Drawing.Size(933, 100);
            this.OptionsListStartWith.TabIndex = 7;
            // 
            // ProcessAdd
            // 
            this.ProcessAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.ProcessAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProcessAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProcessAdd.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ProcessAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.ProcessAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.ProcessAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.ProcessAdd.ForeColor = System.Drawing.Color.White;
            this.ProcessAdd.Location = new System.Drawing.Point(0, 165);
            this.ProcessAdd.Name = "ProcessAdd";
            this.ProcessAdd.Size = new System.Drawing.Size(936, 47);
            this.ProcessAdd.TabIndex = 8;
            this.ProcessAdd.Text = "Add";
            this.ProcessAdd.UseCompatibleTextRendering = true;
            this.ProcessAdd.UseVisualStyleBackColor = false;
            this.ProcessAdd.Click += new System.EventHandler(this.ProcessAdd_Click);
            // 
            // ProcessRemove
            // 
            this.ProcessRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.ProcessRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProcessRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProcessRemove.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ProcessRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.ProcessRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.ProcessRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.ProcessRemove.ForeColor = System.Drawing.Color.White;
            this.ProcessRemove.Location = new System.Drawing.Point(0, 218);
            this.ProcessRemove.Name = "ProcessRemove";
            this.ProcessRemove.Size = new System.Drawing.Size(936, 47);
            this.ProcessRemove.TabIndex = 9;
            this.ProcessRemove.Text = "Remove Seleted";
            this.ProcessRemove.UseCompatibleTextRendering = true;
            this.ProcessRemove.UseVisualStyleBackColor = false;
            this.ProcessRemove.Click += new System.EventHandler(this.ProcessRemove_Click);
            // 
            // CheckHideOnPlay
            // 
            this.CheckHideOnPlay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CheckHideOnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckHideOnPlay.ForeColor = System.Drawing.Color.White;
            this.CheckHideOnPlay.Location = new System.Drawing.Point(0, 34);
            this.CheckHideOnPlay.Name = "CheckHideOnPlay";
            this.CheckHideOnPlay.Size = new System.Drawing.Size(939, 30);
            this.CheckHideOnPlay.TabIndex = 0;
            this.CheckHideOnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckHideOnPlay.UseVisualStyleBackColor = true;
            this.CheckHideOnPlay.CheckedChanged += new System.EventHandler(this.CheckHideOnPlay_CheckedChanged);
            // 
            // BtnGameBanana
            // 
            this.BtnGameBanana.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGameBanana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnGameBanana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGameBanana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGameBanana.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnGameBanana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnGameBanana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnGameBanana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGameBanana.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnGameBanana.ForeColor = System.Drawing.Color.White;
            this.BtnGameBanana.Location = new System.Drawing.Point(619, 623);
            this.BtnGameBanana.Name = "BtnGameBanana";
            this.BtnGameBanana.Size = new System.Drawing.Size(354, 46);
            this.BtnGameBanana.TabIndex = 10;
            this.BtnGameBanana.Text = "GameBanana";
            this.BtnGameBanana.UseCompatibleTextRendering = true;
            this.BtnGameBanana.UseVisualStyleBackColor = false;
            this.BtnGameBanana.Click += new System.EventHandler(this.BtnGameBanana_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ModPanel);
            this.Controls.Add(this.OptionsPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Guilty Gear Strive Mod Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ModPanel.ResumeLayout(false);
            this.ModPanel.PerformLayout();
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnMods;
        private System.Windows.Forms.Panel ModPanel;
        private System.Windows.Forms.FlowLayoutPanel EnabledModListBox;
        private System.Windows.Forms.FlowLayoutPanel DisabledModListBox;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label labelEnabled;
        private System.Windows.Forms.Label labelDisabled;
        private System.Windows.Forms.Button BtnGitHub;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnPlayWith;
        private System.Windows.Forms.Button BtnOptions;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.Label labelOptions;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guilty_Gear_Strive_MM.MyCheckBox CheckHideOnPlay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox OptionsPackPath;
        private System.Windows.Forms.Label labelGamePath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelHideForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelStartWith;
        private System.Windows.Forms.ListBox OptionsListStartWith;
        private System.Windows.Forms.Button ProcessAdd;
        private System.Windows.Forms.Button ProcessRemove;
        private System.Windows.Forms.Button BtnGameBanana;
    }
}

