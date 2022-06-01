namespace Guilty_Gear_Strive_Mod_Manager.Forms
{
    partial class ModsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDisabled = new System.Windows.Forms.Label();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.labelEnabled = new System.Windows.Forms.Label();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.EnabledModListBox = new System.Windows.Forms.FlowLayoutPanel();
            this.DisabledModListBox = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnGameBanana = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDisabled
            // 
            this.labelDisabled.AutoSize = true;
            this.labelDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.labelDisabled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDisabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisabled.ForeColor = System.Drawing.Color.White;
            this.labelDisabled.Location = new System.Drawing.Point(7, 307);
            this.labelDisabled.Name = "labelDisabled";
            this.labelDisabled.Size = new System.Drawing.Size(195, 33);
            this.labelDisabled.TabIndex = 15;
            this.labelDisabled.Text = "Disabled Mods";
            this.labelDisabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnRefresh.ForeColor = System.Drawing.Color.White;
            this.BtnRefresh.Location = new System.Drawing.Point(157, 616);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(203, 46);
            this.BtnRefresh.TabIndex = 16;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseCompatibleTextRendering = true;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // labelEnabled
            // 
            this.labelEnabled.AutoSize = true;
            this.labelEnabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.labelEnabled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEnabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnabled.ForeColor = System.Drawing.Color.White;
            this.labelEnabled.Location = new System.Drawing.Point(7, 4);
            this.labelEnabled.Name = "labelEnabled";
            this.labelEnabled.Size = new System.Drawing.Size(188, 33);
            this.labelEnabled.TabIndex = 14;
            this.labelEnabled.Text = "Enabled Mods";
            this.labelEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnOpen
            // 
            this.BtnOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOpen.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnOpen.ForeColor = System.Drawing.Color.White;
            this.BtnOpen.Location = new System.Drawing.Point(366, 616);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(261, 46);
            this.BtnOpen.TabIndex = 17;
            this.BtnOpen.Text = "Open Folder";
            this.BtnOpen.UseCompatibleTextRendering = true;
            this.BtnOpen.UseVisualStyleBackColor = false;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // EnabledModListBox
            // 
            this.EnabledModListBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EnabledModListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.EnabledModListBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnabledModListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnabledModListBox.Location = new System.Drawing.Point(12, 25);
            this.EnabledModListBox.Name = "EnabledModListBox";
            this.EnabledModListBox.Size = new System.Drawing.Size(956, 279);
            this.EnabledModListBox.TabIndex = 11;
            // 
            // DisabledModListBox
            // 
            this.DisabledModListBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DisabledModListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.DisabledModListBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DisabledModListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisabledModListBox.Location = new System.Drawing.Point(12, 328);
            this.DisabledModListBox.Name = "DisabledModListBox";
            this.DisabledModListBox.Size = new System.Drawing.Size(956, 282);
            this.DisabledModListBox.TabIndex = 12;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(12, 616);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(138, 46);
            this.BtnAdd.TabIndex = 13;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseCompatibleTextRendering = true;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnGameBanana
            // 
            this.BtnGameBanana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGameBanana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnGameBanana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGameBanana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGameBanana.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnGameBanana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnGameBanana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnGameBanana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGameBanana.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnGameBanana.ForeColor = System.Drawing.Color.White;
            this.BtnGameBanana.Location = new System.Drawing.Point(633, 616);
            this.BtnGameBanana.Name = "BtnGameBanana";
            this.BtnGameBanana.Size = new System.Drawing.Size(336, 46);
            this.BtnGameBanana.TabIndex = 18;
            this.BtnGameBanana.Text = "GameBanana";
            this.BtnGameBanana.UseCompatibleTextRendering = true;
            this.BtnGameBanana.UseVisualStyleBackColor = false;
            this.BtnGameBanana.Click += new System.EventHandler(this.BtnGameBanana_Click);
            // 
            // ModsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelDisabled);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.labelEnabled);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.EnabledModListBox);
            this.Controls.Add(this.DisabledModListBox);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnGameBanana);
            this.Name = "ModsControl";
            this.Size = new System.Drawing.Size(991, 681);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDisabled;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Label labelEnabled;
        private System.Windows.Forms.Button BtnOpen;
        public System.Windows.Forms.FlowLayoutPanel EnabledModListBox;
        public System.Windows.Forms.FlowLayoutPanel DisabledModListBox;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnGameBanana;
    }
}
