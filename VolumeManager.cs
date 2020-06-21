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
        CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;

        public void up()
        {
            defaultPlaybackDevice.ToggleMute();
        }
    }
}
