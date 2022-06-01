using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Guilty_Gear_Strive_Mod_Manager
{
    public class SettingsManager
    {
        public const string settingsPath = @"configs\config.json";
        public const string defaultBack = @"resources\Background.jpg";
        public static void CreateSettings(string PathToJson, bool overwrite = true)
        {
            if (overwrite && File.Exists(PathToJson)) File.Delete(PathToJson);

            if (!File.Exists(PathToJson))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(PathToJson));
                File.Create(PathToJson).Close();
            }

            Settings settings = new Settings
            {
                PackFolder = "",
                PackEnabled = "",
                PackDisabled = "",
                HideModManager = true,
                PlayWithDirectories = new List<string>(),
                PlayWithNames = new List<string>(),
                BackgroundImage = defaultBack
            };

            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(PathToJson, json);
        }

        public static void SaveSettings(string PathToJson, Settings settings)
        {
            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(PathToJson, json);
        }

        public static Settings LoadSettings(string PathToJson)
        {
            string json = File.ReadAllText(PathToJson);
            Settings settings = JsonConvert.DeserializeObject<Settings>(json);

            return settings;
        }

        public static void RemoveSettings(string PathToJson)
        {
            if (File.Exists(PathToJson)) File.Delete(PathToJson);
        }
        public static bool SettingsExists(string PathToJson) => File.Exists(PathToJson);

        public static bool IsNullorEmpty(object setting)
        {
            if (setting == null) return true;
            if (setting is string)
            {
                if (string.IsNullOrEmpty(setting as string)) return true;
            }
            else if (setting is int @int)
            {
                if (@int == 0) return true;
            }
            else if (setting is bool boolean)
            {
                if (!boolean) return true;
            }
            else if (setting is string[])
            {
                if ((setting as string[]).Length == 0) return true;
            }
            else if (setting is int[])
            {
                if ((setting as int[]).Length == 0) return true;
            }
            else if (setting is bool[] && (setting as bool[]).Length == 0)
            {
                return true;
            }

            return false;
        }


        public class Settings
        {
            public string PackFolder { get; set; }
            public string PackEnabled { get; set; }
            public string PackDisabled { get; set; }
            public bool HideModManager { get; set; }
            public List<string> PlayWithDirectories { get; set; }
            public List<string> PlayWithNames { get; set; }
            public string BackgroundImage { get; set; }
        }
    }
}
