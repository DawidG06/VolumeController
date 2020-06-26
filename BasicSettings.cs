using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeController
{
    class BasicSettings : ISettingsFrame
    {
        public int Language;
        public bool MinimalizeToSysTray;
        public bool FloatWind;
        public bool StartUp;
        public bool ShowNotifications;
        public int VolumeJump;
        public bool GlobalShortcuts;


        public string GetFilePath()
        {
            return PathManager.Settings_basic();
        }

        public Dictionary<string, string> GetSettingsDictionary()
        {
            return new Dictionary<string, string>()
            {
                { nameof(Language), Language.ToString() },
                { nameof(MinimalizeToSysTray), MinimalizeToSysTray.ToString() },
                { nameof(FloatWind), FloatWind.ToString() },
                { nameof(StartUp), StartUp.ToString() },
                { nameof(ShowNotifications), ShowNotifications.ToString() },
                { nameof(VolumeJump), VolumeJump.ToString() },
                { nameof(GlobalShortcuts), GlobalShortcuts.ToString() }
            };
        }

        public void DoChanges()
        {
            throw new NotImplementedException();
        }

    }
}
