﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VolumeController
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();

            PathManager.Init();
            //BasicSettings basicSettings = new BasicSettings();
            //basicSettings.MinimalizeToSysTray = true;
            //Settings settings = new Settings(basicSettings);

            //var odcz = settings.Read();
            //settings.Save();
            //var odcz2 = settings.Read();

        }

        private void SetKbShortcuts_button_Click(object sender, RoutedEventArgs e)
        {
            KeyboardShortcutsWindow keyboardShortcutsWindow = new KeyboardShortcutsWindow();
            keyboardShortcutsWindow.Owner = this;
            keyboardShortcutsWindow.ShowDialog();
        }
    }
}
