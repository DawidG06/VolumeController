using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VolumeController
{

    //struct KeyboardShortcutsFrame
    //{
    //    public int Louder;
    //    public int Quieter;
    //    public int ToogleMute;
    //    public int BringUpBasicWindow;
    //}

    
    class Settings
    {

        Dictionary<string, string> settingsValues;

        string filePath;
        public Settings(ISettingsFrame settings)
        {
            this.settingsValues = settings.GetSettingsDictionary();
            filePath = settings.GetFilePath();
        }

        public void Save()
        {
            string jsonString = JsonConvert.SerializeObject(settingsValues,Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }

        public Dictionary<string, string> Read()
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
        }

        //public Settings SetInt(this ISettingsFrame settings)
        //{
        //    this.settingsValues = settings.GetSettingsDictionary();
        //    filePath = settings.GetFilePath();
        //    return this;
        //}

    }
}
