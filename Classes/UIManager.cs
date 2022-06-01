using Guilty_Gear_Strive_Mod_Manager.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static Guilty_Gear_Strive_Mod_Manager.ModManager;
using static Guilty_Gear_Strive_Mod_Manager.SettingsManager;

namespace Guilty_Gear_Strive_Mod_Manager
{
    internal static class UIManager
    {
        public static void GenerateMods(ModsControl m, FlowLayoutPanel flow, List<string> elements, FontFamily font, Settings settings)
        {
            m.SuspendLayout();
            for (int i = 0; i < elements.Count; i++)
            {
                string currentMod = elements[i];
                Button btn = new Button
                {
                    Text = currentMod.Replace("_", " ").Replace("-", " "),
                    Font = new Font(font, 20),
                    Size = new Size(300, 150),
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 1, BorderColor = Color.Gray, MouseDownBackColor = Color.FromArgb(50, 6, 3), MouseOverBackColor = Color.FromArgb(50, 6, 3) },
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(87, 6, 3),
                    Cursor = Cursors.Hand,
                    Tag = currentMod,
                    BackgroundImageLayout = ImageLayout.None,
                    Padding = new Padding(0, 10, 0, 0),
                    Margin = new Padding(0, 0, 0, 0),

                };
                ContextMenuStrip contextMenu = new ContextMenuStrip();
                ToolStripMenuItem delete = new ToolStripMenuItem("Delete");
                ToolStripMenuItem rename = new ToolStripMenuItem("Rename");
                contextMenu.Items.AddRange(new ToolStripItem[] { delete, rename });
                btn.ContextMenuStrip = contextMenu;

                delete.Click += (sender, e) => DeleteMod(m, settings, btn.Tag.ToString());
                rename.Click += (sender, e) => RenameMod(m, settings, btn.Tag.ToString());
                btn.Click += new EventHandler(m.ModButton_Click);

                flow.Controls.Add(btn);
            }
            m.ResumeLayout();
        }

        public static void ClearUI(ModsControl modsForm)
        {
            modsForm.EnabledModListBox.Controls.Clear();
            modsForm.DisabledModListBox.Controls.Clear();
            modsForm.EnabledMods.Clear();
            modsForm.DisabledMods.Clear();
        }

        public static void ChangeBackground(MainForm m, Settings settings, bool def)
        {
            if (def)
            {
                string filePath = defaultBack;
                m.BackgroundImage = Image.FromFile(filePath);

                settings.BackgroundImage = filePath;
                SaveSettings(settingsPath, settings);
                return;
            }
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                m.BackgroundImage = Image.FromFile(filePath);

                settings.BackgroundImage = filePath;
                SaveSettings(settingsPath, settings);
            }
        }

        public static void LoadBackground(MainForm m, Settings settings)
        {
            string filePath = settings.BackgroundImage;
            m.BackgroundImage = Image.FromFile(filePath);
        }

    }
}
