using System.IO;

namespace Guilty_Gear_Strive_Mod_Manager
{
    internal static class FileManager
    {
        public static void CopyDirectory(string sourceFolder, string destFolder)
        {
            Directory.CreateDirectory(destFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            for (int i = 0; i < files.Length; i++)
            {
                string file = files[i];
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);
                File.Copy(file, dest);
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            for (int x = 0; x < folders.Length; x++)
            {
                string folder = folders[x];
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                CopyDirectory(folder, dest);
            }
        }

        public static void ForceDeleteDirectory(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path) { Attributes = FileAttributes.Normal };

            foreach (FileSystemInfo info in directory.GetFileSystemInfos("*", SearchOption.AllDirectories))
            {
                info.Attributes = FileAttributes.Normal;
            }

            directory.Delete(true);
        }
    }
}