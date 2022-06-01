using System;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using static Guilty_Gear_Strive_Mod_Manager.FontManager;
using static Guilty_Gear_Strive_Mod_Manager.SettingsManager;
using static Guilty_Gear_Strive_Mod_Manager.UIManager; 

namespace Guilty_Gear_Strive_Mod_Manager.Forms
{
    public partial class OptionsControl : UserControl
    {
        private readonly MainForm m;
        private readonly Settings settings;
        private readonly PrivateFontCollection pfc = new PrivateFontCollection();
        public OptionsControl()
        {
            InitializeComponent();
            m = (MainForm)MainForm.ActiveForm;
            settings = m.settings;
            pfc.AddFontFile($@"{AppDomain.CurrentDomain.BaseDirectory}\Resources\Impact - Strive.otf");
            ChangeUserControlFont(this, pfc.Families[0]);
            FeedOptions();
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

        public void FeedOptions()
        {
            CheckHideModManager.Checked = settings.HideModManager;
            OptionsPackFolder.Text = settings.PackFolder;

            if (!IsNullorEmpty(settings.PlayWithNames) && settings.PlayWithNames.Count > 0)
            {
                string[] playWithNames = settings.PlayWithNames.ToArray();
                for (int i = 0; i < playWithNames.Length; i++)
                {
                    string process = playWithNames[i];
                    OptionsListStartWith.Items.Add(process);
                }
            }
            else
            {
                Visible = false;
            }
        }

        private void CheckHideOnPlay_CheckedChanged(object sender, EventArgs e)
        {
            m.settings.HideModManager = CheckHideModManager.Checked;
            SaveSettings(settingsPath, m.settings);
        }

        private void OptionsPackPath_TextChanged(object sender, EventArgs e)
        {
            m.settings.PackFolder = OptionsPackFolder.Text;
            SaveSettings(settingsPath, m.settings);
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
                string fileName = dialog.SafeFileName;
                string directory = Path.GetFullPath(dialog.FileName);

                m.settings.PlayWithDirectories.Add(directory);
                m.settings.PlayWithNames.Add(fileName);
                OptionsListStartWith.Items.Add(fileName);
                SaveSettings(settingsPath, m.settings);

                if (OptionsListStartWith.Items.Count > 0) m.BtnPlayWith.Visible = true;
            }
        }

        private void ProcessRemove_Click(object sender, EventArgs e)
        {
            if (OptionsListStartWith.SelectedItem != null)
            {
                int index = OptionsListStartWith.SelectedIndex;

                OptionsListStartWith.Items.RemoveAt(index);
                m.settings.PlayWithDirectories.RemoveAt(index);
                m.settings.PlayWithNames.RemoveAt(index);
                SaveSettings(settingsPath, m.settings);
            }

            if (OptionsListStartWith.Items.Count == 0) m.BtnPlayWith.Visible = false;
        }

        private void BtnChangeBackground_Click(object sender, EventArgs e) => ChangeBackground(m, settings, false);

        private void BtnDefaultBackground_Click(object sender, EventArgs e) => ChangeBackground(m, settings, true);
    }
}
