namespace Guilty_Gear_Strive_Mod_Manager.Forms
{
    partial class OptionsControl
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
            this.labelOptions = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OptionsPackFolder = new System.Windows.Forms.TextBox();
            this.labelGamePath = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelHideForm = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProcessRemove = new System.Windows.Forms.Button();
            this.OptionsListStartWith = new System.Windows.Forms.ListBox();
            this.labelStartWith = new System.Windows.Forms.Label();
            this.ProcessAdd = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelBackground = new System.Windows.Forms.Label();
            this.BtnChangeBackground = new System.Windows.Forms.Button();
            this.BtnDefaultBackground = new System.Windows.Forms.Button();
            this.CheckHideModManager = new Guilty_Gear_Strive_Mod_Manager.ScalableCheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.labelOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptions.ForeColor = System.Drawing.Color.White;
            this.labelOptions.Location = new System.Drawing.Point(3, 8);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(110, 33);
            this.labelOptions.TabIndex = 5;
            this.labelOptions.Text = "Options";
            this.labelOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OptionsPackFolder);
            this.panel1.Controls.Add(this.labelGamePath);
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 63);
            this.panel1.TabIndex = 1;
            // 
            // OptionsPackFolder
            // 
            this.OptionsPackFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.OptionsPackFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionsPackFolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OptionsPackFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsPackFolder.ForeColor = System.Drawing.Color.White;
            this.OptionsPackFolder.Location = new System.Drawing.Point(0, 40);
            this.OptionsPackFolder.Name = "OptionsPackFolder";
            this.OptionsPackFolder.Size = new System.Drawing.Size(467, 23);
            this.OptionsPackFolder.TabIndex = 7;
            this.OptionsPackFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OptionsPackFolder.TextChanged += new System.EventHandler(this.OptionsPackPath_TextChanged);
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
            this.panel2.Controls.Add(this.CheckHideModManager);
            this.panel2.Location = new System.Drawing.Point(3, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 64);
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
            this.panel3.Location = new System.Drawing.Point(485, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 272);
            this.panel3.TabIndex = 9;
            // 
            // ProcessRemove
            // 
            this.ProcessRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProcessRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.ProcessRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProcessRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProcessRemove.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ProcessRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.ProcessRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.ProcessRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.ProcessRemove.ForeColor = System.Drawing.Color.White;
            this.ProcessRemove.Location = new System.Drawing.Point(3, 218);
            this.ProcessRemove.Name = "ProcessRemove";
            this.ProcessRemove.Size = new System.Drawing.Size(496, 47);
            this.ProcessRemove.TabIndex = 9;
            this.ProcessRemove.Text = "Remove Seleted";
            this.ProcessRemove.UseCompatibleTextRendering = true;
            this.ProcessRemove.UseVisualStyleBackColor = false;
            this.ProcessRemove.Click += new System.EventHandler(this.ProcessRemove_Click);
            // 
            // OptionsListStartWith
            // 
            this.OptionsListStartWith.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.OptionsListStartWith.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OptionsListStartWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsListStartWith.ForeColor = System.Drawing.Color.White;
            this.OptionsListStartWith.FormattingEnabled = true;
            this.OptionsListStartWith.ItemHeight = 25;
            this.OptionsListStartWith.Location = new System.Drawing.Point(3, 47);
            this.OptionsListStartWith.Name = "OptionsListStartWith";
            this.OptionsListStartWith.Size = new System.Drawing.Size(495, 102);
            this.OptionsListStartWith.TabIndex = 7;
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
            // ProcessAdd
            // 
            this.ProcessAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProcessAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.ProcessAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProcessAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProcessAdd.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ProcessAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.ProcessAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.ProcessAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.ProcessAdd.ForeColor = System.Drawing.Color.White;
            this.ProcessAdd.Location = new System.Drawing.Point(3, 165);
            this.ProcessAdd.Name = "ProcessAdd";
            this.ProcessAdd.Size = new System.Drawing.Size(496, 47);
            this.ProcessAdd.TabIndex = 8;
            this.ProcessAdd.Text = "Add";
            this.ProcessAdd.UseCompatibleTextRendering = true;
            this.ProcessAdd.UseVisualStyleBackColor = false;
            this.ProcessAdd.Click += new System.EventHandler(this.ProcessAdd_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelBackground);
            this.panel4.Controls.Add(this.BtnChangeBackground);
            this.panel4.Controls.Add(this.BtnDefaultBackground);
            this.panel4.Location = new System.Drawing.Point(485, 304);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(502, 152);
            this.panel4.TabIndex = 10;
            // 
            // labelBackground
            // 
            this.labelBackground.AutoSize = true;
            this.labelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.labelBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBackground.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackground.ForeColor = System.Drawing.Color.White;
            this.labelBackground.Location = new System.Drawing.Point(0, 0);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(161, 33);
            this.labelBackground.TabIndex = 6;
            this.labelBackground.Text = "Background";
            this.labelBackground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnChangeBackground
            // 
            this.BtnChangeBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnChangeBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnChangeBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnChangeBackground.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChangeBackground.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnChangeBackground.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnChangeBackground.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnChangeBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnChangeBackground.ForeColor = System.Drawing.Color.White;
            this.BtnChangeBackground.Location = new System.Drawing.Point(3, 44);
            this.BtnChangeBackground.Name = "BtnChangeBackground";
            this.BtnChangeBackground.Size = new System.Drawing.Size(495, 47);
            this.BtnChangeBackground.TabIndex = 10;
            this.BtnChangeBackground.Text = "Change";
            this.BtnChangeBackground.UseCompatibleTextRendering = true;
            this.BtnChangeBackground.UseVisualStyleBackColor = false;
            this.BtnChangeBackground.Click += new System.EventHandler(this.BtnChangeBackground_Click);
            // 
            // BtnDefaultBackground
            // 
            this.BtnDefaultBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDefaultBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnDefaultBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDefaultBackground.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDefaultBackground.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnDefaultBackground.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnDefaultBackground.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.BtnDefaultBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDefaultBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnDefaultBackground.ForeColor = System.Drawing.Color.White;
            this.BtnDefaultBackground.Location = new System.Drawing.Point(3, 97);
            this.BtnDefaultBackground.Name = "BtnDefaultBackground";
            this.BtnDefaultBackground.Size = new System.Drawing.Size(495, 47);
            this.BtnDefaultBackground.TabIndex = 11;
            this.BtnDefaultBackground.Text = "Default";
            this.BtnDefaultBackground.UseCompatibleTextRendering = true;
            this.BtnDefaultBackground.UseVisualStyleBackColor = false;
            this.BtnDefaultBackground.Click += new System.EventHandler(this.BtnDefaultBackground_Click);
            // 
            // CheckHideModManager
            // 
            this.CheckHideModManager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CheckHideModManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckHideModManager.ForeColor = System.Drawing.Color.White;
            this.CheckHideModManager.Location = new System.Drawing.Point(0, 34);
            this.CheckHideModManager.Name = "CheckHideModManager";
            this.CheckHideModManager.Size = new System.Drawing.Size(465, 30);
            this.CheckHideModManager.TabIndex = 0;
            this.CheckHideModManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckHideModManager.UseVisualStyleBackColor = true;
            this.CheckHideModManager.CheckedChanged += new System.EventHandler(this.CheckHideOnPlay_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Location = new System.Drawing.Point(6, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(473, 604);
            this.panel5.TabIndex = 12;
            // 
            // OptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelOptions);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Name = "OptionsControl";
            this.Size = new System.Drawing.Size(991, 681);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelOptions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelGamePath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelHideForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ProcessRemove;
        private System.Windows.Forms.Label labelStartWith;
        private System.Windows.Forms.Button ProcessAdd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.Button BtnChangeBackground;
        private System.Windows.Forms.Button BtnDefaultBackground;
        public System.Windows.Forms.ListBox OptionsListStartWith;
        public ScalableCheckBox CheckHideModManager;
        public System.Windows.Forms.TextBox OptionsPackFolder;
        private System.Windows.Forms.Panel panel5;
    }
}
