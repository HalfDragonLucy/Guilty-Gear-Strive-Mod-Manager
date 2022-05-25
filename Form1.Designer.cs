namespace Guilty_Gear_Strive_Mod_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnMods = new System.Windows.Forms.Button();
            this.ModPanel = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DisabledModListBox = new System.Windows.Forms.FlowLayoutPanel();
            this.EnabledModListBox = new System.Windows.Forms.FlowLayoutPanel();
            this.labelEnabled = new System.Windows.Forms.Label();
            this.labelDisabled = new System.Windows.Forms.Label();
            this.BtnGitHub = new System.Windows.Forms.Button();
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
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
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
            this.BtnPlay.Location = new System.Drawing.Point(3, 53);
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
            this.BtnMods.Location = new System.Drawing.Point(3, 178);
            this.BtnMods.Name = "BtnMods";
            this.BtnMods.Size = new System.Drawing.Size(263, 119);
            this.BtnMods.TabIndex = 1;
            this.BtnMods.Text = "Mods";
            this.BtnMods.UseCompatibleTextRendering = true;
            this.BtnMods.UseVisualStyleBackColor = false;
            this.BtnMods.Click += new System.EventHandler(this.BtnMods_Click);
            // 
            // ModPanel
            // 
            this.ModPanel.BackColor = System.Drawing.Color.Transparent;
            this.ModPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            this.BtnAdd.Location = new System.Drawing.Point(17, 609);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(132, 46);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseCompatibleTextRendering = true;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DisabledModListBox
            // 
            this.DisabledModListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.DisabledModListBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DisabledModListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisabledModListBox.Location = new System.Drawing.Point(17, 321);
            this.DisabledModListBox.Name = "DisabledModListBox";
            this.DisabledModListBox.Size = new System.Drawing.Size(956, 282);
            this.DisabledModListBox.TabIndex = 0;
            // 
            // EnabledModListBox
            // 
            this.EnabledModListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.EnabledModListBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnabledModListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnabledModListBox.Location = new System.Drawing.Point(17, 18);
            this.EnabledModListBox.Name = "EnabledModListBox";
            this.EnabledModListBox.Size = new System.Drawing.Size(956, 279);
            this.EnabledModListBox.TabIndex = 0;
            // 
            // labelEnabled
            // 
            this.labelEnabled.AutoSize = true;
            this.labelEnabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.labelEnabled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEnabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnabled.ForeColor = System.Drawing.Color.White;
            this.labelEnabled.Location = new System.Drawing.Point(12, -3);
            this.labelEnabled.Name = "labelEnabled";
            this.labelEnabled.Size = new System.Drawing.Size(188, 33);
            this.labelEnabled.TabIndex = 5;
            this.labelEnabled.Text = "Enabled Mods";
            this.labelEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDisabled
            // 
            this.labelDisabled.AutoSize = true;
            this.labelDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.labelDisabled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDisabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisabled.ForeColor = System.Drawing.Color.White;
            this.labelDisabled.Location = new System.Drawing.Point(12, 300);
            this.labelDisabled.Name = "labelDisabled";
            this.labelDisabled.Size = new System.Drawing.Size(195, 33);
            this.labelDisabled.TabIndex = 6;
            this.labelDisabled.Text = "Disabled Mods";
            this.labelDisabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BtnGitHub.Location = new System.Drawing.Point(3, 303);
            this.BtnGitHub.Name = "BtnGitHub";
            this.BtnGitHub.Size = new System.Drawing.Size(263, 119);
            this.BtnGitHub.TabIndex = 2;
            this.BtnGitHub.Text = "Github";
            this.BtnGitHub.UseCompatibleTextRendering = true;
            this.BtnGitHub.UseVisualStyleBackColor = false;
            this.BtnGitHub.Click += new System.EventHandler(this.BtnGitHub_Click);
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
    }
}

