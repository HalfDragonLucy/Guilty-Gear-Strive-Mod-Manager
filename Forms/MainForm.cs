using Guilty_Gear_Strive_Mod_Manager.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using static Guilty_Gear_Strive_Mod_Manager.SettingsManager;
using static Guilty_Gear_Strive_Mod_Manager.UIManager;

namespace Guilty_Gear_Strive_Mod_Manager
{
    public partial class MainForm : Form
    {
        private const string gitHub = "https://github.com/HalfDragonLucy/Guilty-Gear-Strive-Mod-Manager";
        private const string guiltyGearStrive = @"steam://rungameid/1384160";
        public string gameBanana = "https://gamebanana.com/games/11534";

        public Settings settings = new Settings();
        private readonly PrivateFontCollection pfc = new PrivateFontCollection();

        private static readonly ModsControl modsForm = new ModsControl();
        private static readonly OptionsControl optionsForm = new OptionsControl();

        public MainForm()
        {
            InitializeComponent();

            pfc.AddFontFile($@"{AppDomain.CurrentDomain.BaseDirectory}\Resources\Impact - Strive.otf");
            FontManager.ChangeFormFont(this, pfc.Families[0]);

            GetSettings();
            LoadBackground(this, settings);
        }

        private void GetSettings()
        {
            if (!SettingsExists(settingsPath))
            {
                CommonOpenFileDialog dialog = new CommonOpenFileDialog
                {
                    IsFolderPicker = true,
                    Title = "Select your Guilty Gear Strive Packs folder"
                };
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    CreateSettings(settingsPath);
                    settings = LoadSettings(settingsPath);
                    settings.PackFolder = dialog.FileName;
                    settings.PackEnabled = $@"{dialog.FileName}\~mods";
                    settings.PackDisabled = $@"{dialog.FileName}\~disabled";
                    SaveSettings(settingsPath, settings);
                }
                else
                {
                    MessageBox.Show("You must select your Guilty Gear Strive Packs folder before using this program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GetSettings();
                }
            }
            else
            {
                settings = LoadSettings(settingsPath);
            }

            GenerateModStructure();
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

        private void GenerateModStructure()
        {
            Directory.CreateDirectory(settings.PackEnabled);
            Directory.CreateDirectory(settings.PackDisabled);
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Process.Start(guiltyGearStrive);
            while (Process.GetProcessesByName("GGST-Win64-Shipping").Length == 0) Thread.Sleep(1000);
            if (settings.HideModManager)
            {
                Application.Exit();
            }
        }

        private void BtnMods_Click(object sender, EventArgs e)
        {
            if (DisplayPanel.Controls.Count > 0)
            {
                DisplayPanel.Controls.Clear();
            }
            DisplayPanel.Controls.Add(modsForm);
            modsForm.Dock = DockStyle.Fill;
            modsForm.Show();
        }

        private void BtnGitHub_Click(object sender, EventArgs e) => Process.Start(gitHub);

        private void BtnPlayWith_Click(object sender, EventArgs e)
        {
            if (!IsNullorEmpty(settings.PlayWithDirectories) && settings.PlayWithDirectories.Count > 0)
            {
                string[] playWithDirectories = settings.PlayWithDirectories.ToArray();
                for (int i = 0; i < playWithDirectories.Length; i++)
                {
                    string process = playWithDirectories[i];
                    Process.Start(process);
                }
            }

            BtnPlay_Click(sender, e);
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            if (DisplayPanel.Controls.Count > 0)
            {
                DisplayPanel.Controls.Clear();
            }

            DisplayPanel.Controls.Add(optionsForm);
            optionsForm.Dock = DockStyle.Fill;
            optionsForm.Show();
            optionsForm.BringToFront();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SettingsExists(settingsPath))
            {
                SaveSettings(settingsPath, settings);
            }
        }
    }
}
