using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace VolumeController
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        VolumeManager volumeManager;

        Settings settings;
        BasicSettings basicSettings;
        public MainWindowViewModel()
        {
            volumeManager = new VolumeManager();

            basicSettings = new BasicSettings();
            //settings = new Settings();

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChange(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        #region CONTROL TAB
        // Current Volume Level
        public string CurrentVolumeLevel
        {
            get { return volumeManager.CurrentLevel + "%"; }
        }


        // Volume Turn Down
        private ICommand volumeTurnDown;
        public ICommand VolumeTurnDown
        {
            get
            {
                return volumeTurnDown ?? (volumeTurnDown = new CommandHandler(() => volumeTurnDown_Execute(), () => volumeTurnDown_CanExecute));
            }
        }
        private bool volumeTurnDown_CanExecute
        {
            get { return volumeManager.CurrentLevel > 0 ? true : false; }
        }

        private void volumeTurnDown_Execute()
        {
            volumeManager.VolumeDown(5);
            RaisePropertyChange("CurrentVolumeLevel");
        }

        // Volume Turn Up
        private ICommand volumeTurnUp;
        public ICommand VolumeTurnUp
        {
            get
            {
                return volumeTurnUp ?? (volumeTurnUp = new CommandHandler(() => volumeTurnUp_Execute(), () => volumeTurnUp_CanExecute));
            }
        }
        private bool volumeTurnUp_CanExecute
        {
            get { return true; }
        }

        private void volumeTurnUp_Execute()
        {
            volumeManager.VolumeUp(5);
            RaisePropertyChange("CurrentVolumeLevel");
        }

        // Volume Mute
        private ICommand volumeMute;



        public ICommand VolumeMute
        {
            get
            {
                return volumeMute ?? (volumeMute = new CommandHandler(() => volumeMute_Execute(), () => volumeMute_CanExecute));
            }
        }
        private bool volumeMute_CanExecute
        {
            get { return true; }
        }

        private void volumeMute_Execute()
        {
            volumeManager.ToogleMute();
        }
        #endregion

        #region SETTINGS TAB


        public bool MinToSysTray
        {
            get { return basicSettings.MinimalizeToSysTray; }
            set
            {
                if (basicSettings.MinimalizeToSysTray == value) return;
                basicSettings.MinimalizeToSysTray = value;
                
            }
        }


        #endregion



    }
}
