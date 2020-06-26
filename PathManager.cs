using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeController
{
    class PathManager
    {

        private const string mainPath_1 = "DawidG06";
        private const string mainPath_2 = "VolumeController";

        private const string settings_basic = "settings.json";
        private const string settings_keyboardShortcuts = "keyboardShortcuts.json";

        public static string MainPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), mainPath_1, mainPath_2);
            //"C:\\Users\\[USER Name]\\AppData\\Roaming\\DawidG06\\VolumeController"
        }


        public static string Settings_basic()
        {
            return Path.Combine(MainPath(), settings_basic);
        }

        public static string Settings_keyboardShortcuts()
        {
            return Path.Combine(MainPath(), settings_keyboardShortcuts);
        }

        public static void Init()
        {
            if (Directory.Exists(MainPath()) == false)
                Directory.CreateDirectory(MainPath());


            if (File.Exists(Settings_basic()) == false)
                File.Create(Settings_basic());

            if (File.Exists(Settings_keyboardShortcuts()) == false)
                File.Create(Settings_keyboardShortcuts());

        }

    }
}
