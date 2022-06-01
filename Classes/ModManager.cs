using Guilty_Gear_Strive_Mod_Manager.Forms;
using System.IO;
using System.Windows.Forms;
using static Guilty_Gear_Strive_Mod_Manager.FileManager;
using static Guilty_Gear_Strive_Mod_Manager.SettingsManager;
using static Guilty_Gear_Strive_Mod_Manager.UIManager;

namespace Guilty_Gear_Strive_Mod_Manager
{
    internal static class ModManager
    {
        public static void DeleteMod(ModsControl m, Settings settings, string tag)
        {
            string enabledModPath = $@"{settings.PackEnabled}\{tag}";
            string disabledModPath = $@"{settings.PackEnabled}\{tag}";

            DirectoryInfo enabledDir = new DirectoryInfo(enabledModPath);
            DirectoryInfo disabledDir = new DirectoryInfo(disabledModPath);

            if (enabledDir.Exists)
            {
                ForceDeleteDirectory(enabledDir.FullName);
                m.DisplayMods();
            }
            else if (disabledDir.Exists)
            {
                ForceDeleteDirectory(disabledDir.FullName);
                m.DisplayMods();
            }
        }
        public static void RenameMod(ModsControl m, Settings settings, string tag)
        {
            string input = tag;
            InputDialog.ShowInputDialog(ref input);

            if (input != tag && input != string.Empty)
            {
                string enabledPath = $@"{settings.PackEnabled}\{tag}";
                string disabledPath = $@"{settings.PackDisabled}\{tag}";
                string newEnabledPath = $@"{settings.PackEnabled}\{input}";
                string newDisabledPath = $@"{settings.PackDisabled}\{input}";

                if (Directory.Exists(enabledPath))
                {
                    Directory.Move(enabledPath, newEnabledPath);
                    m.DisplayMods();
                }
                else if (Directory.Exists(disabledPath))
                {
                    Directory.Move(disabledPath, newDisabledPath);
                    m.DisplayMods();
                }
            }
        }

        public static void SwitchModState(ModsControl m, object sender, Settings settings)
        {
            Button btn = (Button)sender;
            string tag = btn.Tag.ToString();

            string enabledModPath = $@"{settings.PackEnabled}\{tag}";
            string disabledModPath = $@"{settings.PackDisabled}\{tag}";

            if (Directory.Exists(disabledModPath))
            {
                DirectoryInfo di = new DirectoryInfo(disabledModPath);
                di.MoveTo(enabledModPath);
                m.DisplayMods();
            }
            else if (Directory.Exists(enabledModPath))
            {
                DirectoryInfo di = new DirectoryInfo(enabledModPath);
                di.MoveTo(disabledModPath);
                m.DisplayMods();
            }

            ClearUI(m);
            m.DisplayMods();
        }
    }
}
