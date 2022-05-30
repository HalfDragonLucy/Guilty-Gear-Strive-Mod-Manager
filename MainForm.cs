using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Guilty_Gear_Strive_Mod_Manager
{
    public partial class MainForm : Form
    {
        private readonly PrivateFontCollection pfc = new PrivateFontCollection();
        private string packsPath = string.Empty;
        private readonly List<string> enabledMods = new List<string>();
        private readonly List<string> disabledMods = new List<string>();
        public MainForm()
        {
            InitializeComponent();

            pfc.AddFontFile($@"{AppDomain.CurrentDomain.BaseDirectory}\Resources\Impact - Strive.otf");

            GetSettings();
            GetMods();
        }

        private void FeedUI()
        {
            SuspendLayout();
            GenerateUI(EnabledModListBox, enabledMods);
            GenerateUI(DisabledModListBox, disabledMods);
            ResumeLayout();
        }

        private void GenerateUI(FlowLayoutPanel flow, List<string> mods)
        {
            for (int i = 0; i < mods.Count; i++)
            {
                string currentMod = mods[i];
                Button btn = new Button
                {
                    Text = currentMod.Replace("_", " ").Replace("-", " "),
                    Font = new Font(pfc.Families[0], 20),
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

                delete.Click += (sender, e) => DeleteMod(btn.Tag.ToString());
                rename.Click += (sender, e) => RenameMod(btn.Tag.ToString());
                btn.Click += new EventHandler(ModButton_Click);

                flow.Controls.Add(btn);
            }
        }

        private void RenameMod(string tag)
        {
            string input = tag;
            ShowInputDialog(ref input);

            if (input != tag && input != string.Empty)
            {
                string enabledPath = $@"{packsPath}\~mods\{tag}";
                string disabledPath = $@"{packsPath}\~disabled\{tag}";
                string newEnabledPath = $@"{packsPath}\~mods\{input}";
                string newDisabledPath = $@"{packsPath}\~disabled\{input}";

                if (Directory.Exists(enabledPath))
                {
                    Directory.Move(enabledPath, newEnabledPath);
                    GetMods();
                }
                else if (Directory.Exists(disabledPath))
                {
                    Directory.Move(disabledPath, newDisabledPath);
                    GetMods();
                }
            }
        }

        private static DialogResult ShowInputDialog(ref string input)
        {
            Size size = new Size(200, 70);
            Form inputBox = new Form
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                ClientSize = size,
                Text = "Name"
            };

            TextBox textBox = new TextBox
            {
                Size = new Size(size.Width - 10, 23),
                Location = new Point(5, 5),
                Text = input
            };
            inputBox.Controls.Add(textBox);

            Button okButton = new Button
            {
                DialogResult = DialogResult.OK,
                Name = "okButton",
                Size = new Size(75, 23),
                Text = "&OK",
                Location = new Point(size.Width - 80 - 80, 39)
            };
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button
            {
                DialogResult = DialogResult.Cancel,
                Name = "cancelButton",
                Size = new Size(75, 23),
                Text = "&Cancel",
                Location = new Point(size.Width - 80, 39)
            };
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        private void DeleteMod(string tag)
        {
            string enabledModPath = $@"{packsPath}\~mods\{tag}";
            string disabledModPath = $@"{packsPath}\~disabled\{tag}";

            if (Directory.Exists(enabledModPath))
            {
                Directory.Delete(enabledModPath, true);
                GetMods();
            }
            if (Directory.Exists(disabledModPath))
            {
                Directory.Delete(disabledModPath, true);
                GetMods();
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

            ClearUI();
            GetMods();
        }

        private void GetMods()
        {
            ClearUI();

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

            FeedUI();
        }

        private void GenerateModFolders()
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

        private void ClearUI()
        {
            EnabledModListBox.Controls.Clear();
            DisabledModListBox.Controls.Clear();
            enabledMods.Clear();
            disabledMods.Clear();
        }

        private void GetSettings()
        {
            if (Guilty_Gear_Strive_MM.Properties.Settings.Default.PacksPath == string.Empty)
            {
                CommonOpenFileDialog dialog = new CommonOpenFileDialog
                {
                    IsFolderPicker = true,
                    Title = "Select your Guilty Gear Strive installation folder"
                };
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    Guilty_Gear_Strive_MM.Properties.Settings.Default.PacksPath = $@"{dialog.FileName}\RED\Content\Paks";
                    Guilty_Gear_Strive_MM.Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("You must select your Guilty Gear Strive installation folder before using this program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    Environment.Exit(0);
                }
            }

            FeedOptions();
            GenerateModFolders();
        }

        private void FeedOptions()
        {
            packsPath = Guilty_Gear_Strive_MM.Properties.Settings.Default.PacksPath;
            CheckHideOnPlay.Checked = Guilty_Gear_Strive_MM.Properties.Settings.Default.HideOnPlay;
            OptionsPackPath.Text = packsPath;
            if (Guilty_Gear_Strive_MM.Properties.Settings.Default.ProcessesName != null)
            {
                StringCollection list = Guilty_Gear_Strive_MM.Properties.Settings.Default.ProcessesName;
                for (int i = 0; i < list.Count; i++)
                {
                    string process = list[i];
                    OptionsListStartWith.Items.Add(process);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBufferInitialize();
            SetGuiltyGearFont();
        }

        private void SetGuiltyGearFont()
        {
            BtnPlay.Font = new Font(pfc.Families[0], BtnPlay.Font.Size, BtnPlay.Font.Style);
            BtnMods.Font = new Font(pfc.Families[0], BtnMods.Font.Size, BtnMods.Font.Style);
            BtnAdd.Font = new Font(pfc.Families[0], BtnAdd.Font.Size, BtnAdd.Font.Style);
            BtnOpen.Font = new Font(pfc.Families[0], BtnOpen.Font.Size, BtnOpen.Font.Style);
            BtnRefresh.Font = new Font(pfc.Families[0], BtnRefresh.Font.Size, BtnRefresh.Font.Style);
            BtnGitHub.Font = new Font(pfc.Families[0], BtnGitHub.Font.Size, BtnGitHub.Font.Style);
            BtnPlayWith.Font = new Font(pfc.Families[0], BtnPlayWith.Font.Size, BtnPlayWith.Font.Style);
            BtnOptions.Font = new Font(pfc.Families[0], BtnOptions.Font.Size, BtnOptions.Font.Style);
            BtnGameBanana.Font = new Font(pfc.Families[0], BtnGameBanana.Font.Size, BtnGameBanana.Font.Style);
            
            ProcessAdd.Font = new Font(pfc.Families[0], ProcessAdd.Font.Size, ProcessAdd.Font.Style);
            ProcessRemove.Font = new Font(pfc.Families[0], ProcessRemove.Font.Size, ProcessRemove.Font.Style);

            labelEnabled.Font = new Font(pfc.Families[0], labelEnabled.Font.Size, labelEnabled.Font.Style);
            labelDisabled.Font = new Font(pfc.Families[0], labelDisabled.Font.Size, labelDisabled.Font.Style);
            labelOptions.Font = new Font(pfc.Families[0], labelOptions.Font.Size, labelOptions.Font.Style);
            labelGamePath.Font = new Font(pfc.Families[0], labelGamePath.Font.Size, labelGamePath.Font.Style);
            labelHideForm.Font = new Font(pfc.Families[0], CheckHideOnPlay.Font.Size, CheckHideOnPlay.Font.Style);
            labelStartWith.Font = new Font(pfc.Families[0], labelStartWith.Font.Size, labelStartWith.Font.Style);

            OptionsPackPath.Font = new Font(pfc.Families[0], OptionsPackPath.Font.Size, OptionsPackPath.Font.Style);
            OptionsListStartWith.Font = new Font(pfc.Families[0], OptionsListStartWith.Font.Size, OptionsListStartWith.Font.Style);
        }

        private void DoubleBufferInitialize()
        {
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, ModPanel, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered",
                 BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                 null, OptionsPanel, new object[] { true });

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
            typeof(Panel).InvokeMember("DoubleBuffered",
    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
    null, labelDisabled, new object[] { true });
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Process.Start(@"steam://rungameid/1384160");
            BtnPlay.Text = "Loading...";
            BtnPlay.Font = new Font(pfc.Families[0], 40, FontStyle.Regular);

            if (Guilty_Gear_Strive_MM.Properties.Settings.Default.HideOnPlay)
            {
                Hide();
            }
            while (Process.GetProcessesByName("GGST-Win64-Shipping").Length == 0)
            {
                Thread.Sleep(2000);
            }
            GameTimer.Start();
        }

        private void BtnMods_Click(object sender, EventArgs e)
        {
            ModPanel.Visible = true;
            OptionsPanel.Visible = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                Title = "Select the mods you want to add",
                Multiselect = true,
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string[] selected = dialog.FileNames.Select(p => p).ToArray();
                for (int i = 0; i < selected.Length; i++)
                {
                    DirectoryInfo dir = new DirectoryInfo(selected[i]);
                    CopyFilesRecursively(dir.FullName, $@"{packsPath}\~mods\{dir.Name}");
                }

                GetMods();
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

            GetMods();
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

        private void BtnRefresh_Click(object sender, EventArgs e) => GetMods();

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("GGST-Win64-Shipping").Length == 0)
            {
                GameTimer.Stop();

                BtnPlay.Text = "Play";
                BtnPlay.Font = new Font(pfc.Families[0], 65, FontStyle.Bold);
                if (Guilty_Gear_Strive_MM.Properties.Settings.Default.HideOnPlay)
                {
                    Show();
                    BringToFront();
                }
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e) => Process.Start(packsPath);

        private void BtnPlayWith_Click(object sender, EventArgs e)
        {
            if (Guilty_Gear_Strive_MM.Properties.Settings.Default.ProcessesDirectory != null)
            {
                StringCollection procsDir = Guilty_Gear_Strive_MM.Properties.Settings.Default.ProcessesDirectory;
                StringCollection procsName = Guilty_Gear_Strive_MM.Properties.Settings.Default.ProcessesName;

                for (int i = 0; i < procsDir.Count; i++)
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo(procsName[i])
                    {
                        WorkingDirectory = procsDir[i],
                        UseShellExecute = true
                    };

                    Process proc = Process.Start(startInfo);
                }

                BtnPlay_Click(sender, e);
            }
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            ModPanel.Visible = false;
            OptionsPanel.Visible = true;
        }

        private void CheckHideOnPlay_CheckedChanged(object sender, EventArgs e)
        {
            Guilty_Gear_Strive_MM.Properties.Settings.Default.HideOnPlay = CheckHideOnPlay.Checked;
            Guilty_Gear_Strive_MM.Properties.Settings.Default.Save();
        }

        private void OptionsPackPath_TextChanged(object sender, EventArgs e)
        {
            Guilty_Gear_Strive_MM.Properties.Settings.Default.PacksPath = OptionsPackPath.Text;
            Guilty_Gear_Strive_MM.Properties.Settings.Default.Save();
        }

        private void ProcessAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "Select the executable to add to the list",
                Filter = "Executable files (*.exe)|*.exe",
                Multiselect = false,
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (Guilty_Gear_Strive_MM.Properties.Settings.Default.ProcessesDirectory == null)
                {
                    Guilty_Gear_Strive_MM.Properties.Settings.Default.ProcessesDirectory = new StringCollection();
                }
                if (Guilty_Gear_Strive_MM.Properties.Settings.Default.ProcessesName == null)
                {
                    Guilty_Gear_Strive_MM.Properties.Settings.Default.ProcessesName = new StringCollection();
                }

                string path = Path.GetDirectoryName(dialog.FileName);
                string name = Path.GetFileName(dialog.FileName);
                Guilty_Gear_Strive_MM.Properties.Settings.Default.ProcessesDirectory.Add(path);
                Guilty_Gear_Strive_MM.Properties.Settings.Default.ProcessesName.Add(name);
                Guilty_Gear_Strive_MM.Properties.Settings.Default.Save();
                OptionsListStartWith.Items.Add(name);
            }
        }

        private void ProcessRemove_Click(object sender, EventArgs e)
        {
            if (OptionsListStartWith.SelectedItem != null)
            {
                int index = OptionsListStartWith.SelectedIndex;
                
                OptionsListStartWith.Items.RemoveAt(index); 
                Guilty_Gear_Strive_MM.Properties.Settings.Default.ProcessesDirectory.RemoveAt(index);
                Guilty_Gear_Strive_MM.Properties.Settings.Default.ProcessesName.RemoveAt(index);
                Guilty_Gear_Strive_MM.Properties.Settings.Default.Save();
            }
        }

        private void BtnGameBanana_Click(object sender, EventArgs e) => Process.Start("https://gamebanana.com/games/11534");
    }
}
