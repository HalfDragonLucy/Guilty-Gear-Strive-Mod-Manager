using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Guilty_Gear_Strive_Mod_Manager
{
    public partial class Form1 : Form
    {
        private readonly PrivateFontCollection pfc = new PrivateFontCollection();
        private string packsPath = string.Empty;
        private readonly List<string> enabledMods = new List<string>();
        private readonly List<string> disabledMods = new List<string>();
        public Form1()
        {
            InitializeComponent();
            CheckForGame();
            GetInstalledMods();
        }



        private void SendModsToPanel()
        {
            pfc.AddFontFile($@"{AppDomain.CurrentDomain.BaseDirectory}\Resources\Impact - Strive.otf");

            SuspendLayout();
            GenerateUI(EnabledModListBox, enabledMods);
            GenerateUI(DisabledModListBox, disabledMods);
            ResumeLayout();
        }

        private void GenerateUI(FlowLayoutPanel flow, List<string> mods)
        {
            for (int i = 0; i < mods.Count; i++)
            {
                Button btn = new Button
                {
                    Text = mods[i].Replace("_", " ").Replace("-", " "),
                    Font = new Font(pfc.Families[0], 20),
                    Size = new Size(300, 150),
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0, MouseDownBackColor = Color.FromArgb(50, 6, 3), MouseOverBackColor = Color.FromArgb(50, 6, 3) },
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(87, 6, 3),
                    Cursor = Cursors.Hand,
                    Tag = mods[i],
                    BackgroundImageLayout = ImageLayout.None,
                    Padding = new Padding(0, 10, 0, 0),
                };
                btn.Click += new EventHandler(ModButton_Click);

                flow.Controls.Add(btn);
            }
        }

        private void ModButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string tag = btn.Tag.ToString();
            if (Directory.Exists($@"{packsPath}\~disabled\{tag}"))
            {
                Directory.Move($@"{packsPath}\~disabled\{tag}", $@"{packsPath}\~mods\{tag}");
            }
            else
            {
                Directory.Move($@"{packsPath}\~mods\{tag}", $@"{packsPath}\~disabled\{tag}");
            }

            RefreshUI();
            GetInstalledMods();
        }

        private void GetInstalledMods()
        {
            string[] enabledDir = Directory.GetDirectories($@"{packsPath}\~mods");
            for (int i = 0; i < enabledDir.Length; i++)
            {
                string dir = new DirectoryInfo(enabledDir[i]).Name;
                enabledMods.Add(dir);
            }

            string[] DisabledDir = Directory.GetDirectories($@"{packsPath}\~disabled");
            for (int i = 0; i < DisabledDir.Length; i++)
            {
                string dir = new DirectoryInfo(DisabledDir[i]).Name;
                disabledMods.Add(dir);
            }

            SendModsToPanel();
        }

        private void CheckForModFolder()
        {
            if (!Directory.Exists($@"{packsPath}\~mods"))
            {
                Directory.CreateDirectory($@"{packsPath}\~mods");
            }

            if (!Directory.Exists($@"{packsPath}\~disabled"))
            {
                Directory.CreateDirectory($@"{packsPath}\~disabled");
            }
        }

        private void RefreshUI()
        {
            EnabledModListBox.Controls.Clear();
            DisabledModListBox.Controls.Clear();
            enabledMods.Clear();
            disabledMods.Clear();
        }

        private void CheckForGame()
        {
            if (Properties.Settings.Default.PacksPath == string.Empty)
            {
                CommonOpenFileDialog dialog = new CommonOpenFileDialog
                {
                    IsFolderPicker = true,
                    Title = "Select your Guilty Gear Strive installation folder"
                };
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    Properties.Settings.Default.PacksPath = $@"{dialog.FileName}\RED\Content\Paks";
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("You must select your Guilty Gear Strive installation folder before using this program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    Environment.Exit(0);
                }
            }

            packsPath = Properties.Settings.Default.PacksPath;
            CheckForModFolder();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pfc.AddFontFile($@"{AppDomain.CurrentDomain.BaseDirectory}\Resources\Impact - Strive.otf");

            FlickeringFix();
            LoadFont();
        }

        private void LoadFont()
        {
            BtnPlay.Font = new Font(pfc.Families[0], BtnPlay.Font.Size, BtnPlay.Font.Style);
            BtnMods.Font = new Font(pfc.Families[0], BtnMods.Font.Size, BtnMods.Font.Style);
            BtnAdd.Font = new Font(pfc.Families[0], BtnAdd.Font.Size, BtnAdd.Font.Style);
            BtnGitHub.Font = new Font(pfc.Families[0], BtnGitHub.Font.Size, BtnGitHub.Font.Style);
            labelEnabled.Font = new Font(pfc.Families[0], labelEnabled.Font.Size, labelEnabled.Font.Style);
            labelDisabled.Font = new Font(pfc.Families[0], labelDisabled.Font.Size, labelDisabled.Font.Style);
        }

        private void FlickeringFix()
        {
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, ModPanel, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, EnabledModListBox, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, DisabledModListBox, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, labelEnabled, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, labelDisabled, new object[] { true });
        }

        private void BtnPlay_Click(object sender, EventArgs e) => Process.Start(@"steam://rungameid/1384160");

        private void BtnMods_Click(object sender, EventArgs e) => ModPanel.Visible = !ModPanel.Visible;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                Title = "Select your mod folder",
                Multiselect = true,
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string[] selected = dialog.FileNames.Select(p => p).ToArray();
                for (int i = 0; i < 4; i++)
                {
                    DirectoryInfo dir = new DirectoryInfo(selected[i]);
                    CopyFilesRecursively(dir.FullName, $@"{packsPath}\~mods\{dir.Name}");
                }

                RefreshUI();
                GetInstalledMods();
            }
        }

        private static void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            string[] dir = Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories);
            for (int i = 0; i < dir.Length; i++)
            {
                string dirPath = dir[i];
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }
            string[] newDir = Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories);
            for (int i = 0; i < newDir.Length; i++)
            {
                string newPath = newDir[i];
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            for (int i = 0; i < paths.Length; i++)
            {
                DirectoryInfo dir = new DirectoryInfo(paths[i]);
                CopyFilesRecursively(dir.FullName, $@"{packsPath}\~mods\{dir.Name}");
                Console.WriteLine($@"{packsPath}\~mods\{dir.Name}");
            }

            RefreshUI();
            GetInstalledMods();
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

        private void BtnGitHub_Click(object sender, EventArgs e) => Process.Start("https://github.com/HalfDragonLucy/Guilty-Gear-Strive-Mod-Manager");
    }
}
