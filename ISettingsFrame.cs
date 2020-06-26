using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeController
{
    interface ISettingsFrame
    {
        Dictionary<string, string> GetSettingsDictionary();
        string GetFilePath();
        void DoChanges();
    }
}
