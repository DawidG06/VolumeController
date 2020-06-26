using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VolumeController.View;

namespace VolumeController
{
    /// <summary>
    /// Interaction logic for KeyboardShortcutsWindow.xaml
    /// </summary>
    public partial class KeyboardShortcutsWindow : Window
    {
        public KeyboardShortcutsWindow()
        {
            InitializeComponent();


            List<sourceforlist> lll = new List<sourceforlist>();
            lll.Add(new sourceforlist("Louder", ""));
            lll.Add(new sourceforlist("Quieter", ""));
            lll.Add(new sourceforlist("ToogleMute", ""));
            lll.Add(new sourceforlist("BringUpBasicWindow", ""));


            lv.ItemsSource = lll;
        }

        private void lv_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                SetShortcutWindow setShortcutWindow = new SetShortcutWindow();
                setShortcutWindow.Owner = this;
                setShortcutWindow.ShowDialog();
            }
        }
    }


    class sourceforlist
    {
        public sourceforlist(string f, string s)
        {
            Function = f;
            Shortcut = s;
        }

        public string Function { get; set; }
        public string Shortcut { get; set; }
    }

}
