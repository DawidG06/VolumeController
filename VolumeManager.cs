using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeController
{
    class VolumeManager
    {
        CoreAudioDevice coreAudioDevice;
        public VolumeManager()
        {
            coreAudioDevice = new CoreAudioController().DefaultPlaybackDevice;
        }

        public void VolumeUp(int jump)
        {
            coreAudioDevice.Volume += jump;
        }

        public void VolumeDown(int jump)
        {
            coreAudioDevice.Volume -= jump;
        }

        public void SetVolume(int level)
        {
            coreAudioDevice.Volume = level;
        }

        public void ToogleMute()
        {
            coreAudioDevice.ToggleMute();
        }

        public int CurrentLevel
        {
            get { return Convert.ToInt32(coreAudioDevice.Volume); }
        }
    }
}
