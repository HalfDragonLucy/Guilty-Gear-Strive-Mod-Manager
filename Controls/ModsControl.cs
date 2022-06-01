using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static Guilty_Gear_Strive_Mod_Manager.FileManager;
using static Guilty_Gear_Strive_Mod_Manager.FontManager;
using static Guilty_Gear_Strive_Mod_Manager.ModManager;
using static Guilty_Gear_Strive_Mod_Manager.SettingsManager;
using static Guilty_Gear_Strive_Mod_Manager.UIManager;

namespace Guilty_Gear_Strive_Mod_Manager.Forms
{
    public partial class ModsControl : UserControl
    {
        private readonly MainForm m;
        private readonly Settings settings;

        public List<string> EnabledMods { get; set; } = new List<string>();
        public List<string> DisabledMods { get; set; } = new List<string>();
        private readonly PrivateFontCollection pfc = new PrivateFontCollection();
        public ModsControl()
        {
            InitializeComponent();
            m = (MainForm)MainForm.ActiveForm;
            settings = m.settings;
            pfc.AddFontFile($@"{AppDomain.CurrentDomain.BaseDirectory}\Resources\Impact - Strive.otf");
            ChangeUserControlFont(this, pfc.Families[0]);
            DisplayMods();
        }

        #region DoubleBufferForm
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }
        #endregion

        public void DisplayMods()
        {
            ClearUI(this);

            string[] enabledDir = Directory.GetDirectories(settings.PackEnabled);
            for (int i = 0; i < enabledDir.Length; i++)
            {
                string dir = new DirectoryInfo(enabledDir[i]).Name;
                EnabledMods.Add(dir);
            }

            string[] DisabledDir = Directory.GetDirectories(settings.PackDisabled);
            for (int i = 0; i < DisabledDir.Length; i++)
            {
                string dir = new DirectoryInfo(DisabledDir[i]).Name;
                DisabledMods.Add(dir);
            }

            GenerateMods(this, EnabledModListBox, EnabledMods, pfc.Families[0], settings);
            GenerateMods(this, DisabledModListBox, DisabledMods, pfc.Families[0], settings);
        }

        public void ModButton_Click(object sender, EventArgs e) => SwitchModState(this, sender, settings);

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                Title = "Select the mod you want to add",
                Multiselect = false,
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string[] selected = dialog.FileNames.Select(p => p).ToArray();
                for (int i = 0; i < selected.Length; i++)
                {
                    DirectoryInfo dir = new DirectoryInfo(selected[i]);
                    CopyDirectory(dir.FullName, $@"{settings.PackEnabled}\{dir.Name}");
                }

                DisplayMods();
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            for (int i = 0; i < paths.Length; i++)
            {
                DirectoryInfo dir = new DirectoryInfo(paths[i]);
                CopyDirectory(dir.FullName, $@"{settings.PackEnabled}\{dir.Name}");
            }

            DisplayMods();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects effects = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(path))
                {
                    effects = DragDropEffects.Copy;
                }
            }

            e.Effect = effects;
        }

        private void BtnRefresh_Click(object sender, EventArgs e) => DisplayMods();
        
        private void BtnOpen_Click(object sender, EventArgs e) => Process.Start(settings.PackFolder);

        private void BtnGameBanana_Click(object sender, EventArgs e) => Process.Start(m.gameBanana);
    }

}
