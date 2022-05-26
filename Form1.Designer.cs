﻿namespace Guilty_Gear_Strive_Mod_Manager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnMods = new System.Windows.Forms.Button();
            this.BtnGitHub = new System.Windows.Forms.Button();
            this.ModPanel = new System.Windows.Forms.Panel();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.labelDisabled = new System.Windows.Forms.Label();
            this.labelEnabled = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.EnabledModListBox = new System.Windows.Forms.FlowLayoutPanel();
            this.DisabledModListBox = new System.Windows.Forms.FlowLayoutPanel();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.BtnOpen = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.ModPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.BtnPlay);
            this.flowLayoutPanel1.Controls.Add(this.BtnMods);
            this.flowLayoutPanel1.Controls.Add(this.BtnGitHub);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
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
            this.BtnPlay.Location = new System.Drawing.Point(3, 3);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(263, 119);
            this.BtnPlay.TabIndex = 0;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseCompatibleTextRendering = true;
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
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
            this.BtnMods.Location = new System.Drawing.Point(3, 128);
            this.BtnMods.Name = "BtnMods";
            this.BtnMods.Size = new System.Drawing.Size(263, 119);
            this.BtnMods.TabIndex = 1;
            this.BtnMods.Text = "Mods";
            this.BtnMods.UseCompatibleTextRendering = true;
            this.BtnMods.UseVisualStyleBackColor = false;
            this.BtnMods.Click += new System.EventHandler(this.BtnMods_Click);
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
            this.BtnGitHub.Location = new System.Drawing.Point(3, 253);
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
            this.ModPanel.Controls.Add(this.BtnOpen);
            this.ModPanel.Controls.Add(this.BtnRefresh);
            this.ModPanel.Controls.Add(this.BtnRemove);
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
            this.BtnRefresh.Location = new System.Drawing.Point(358, 623);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(197, 46);
            this.BtnRefresh.TabIndex = 8;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseCompatibleTextRendering = true;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemove.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnRemove.ForeColor = System.Drawing.Color.White;
            this.BtnRemove.Location = new System.Drawing.Point(155, 623);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(197, 46);
            this.BtnRemove.TabIndex = 7;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseCompatibleTextRendering = true;
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
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
            this.BtnOpen.Location = new System.Drawing.Point(561, 623);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(255, 46);
            this.BtnOpen.TabIndex = 9;
            this.BtnOpen.Text = "Open Folder";
            this.BtnOpen.UseCompatibleTextRendering = true;
            this.BtnOpen.UseVisualStyleBackColor = false;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ModPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Guilty Gear Strive Mod Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ModPanel.ResumeLayout(false);
            this.ModPanel.PerformLayout();
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
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button BtnOpen;
    }
}

