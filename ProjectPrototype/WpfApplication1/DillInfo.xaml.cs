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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for DillInfo.xaml
    /// </summary>
    public partial class DillInfo : UserControl, Switchable
    {
        public string myNotes = " ";
        public DillInfo()
        {
            InitializeComponent();
            _DillNotes.Text = myNotes;
        }
        #region Switchable Members

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myNotes = _DillNotes.Text;
            if (myNotes != " " && myNotes != "")
            {
                Pages.hList.dillNote.Visibility = Visibility.Visible;
                Pages.aHerb2016.dillNote.Visibility = Visibility.Visible;
            }
            else
            {
                Pages.hList.dillNote.Visibility = Visibility.Hidden;
                Pages.aHerb2016.dillNote.Visibility = Visibility.Hidden;
            }
            Switcher.Switch(Pages.hList);
        }
    }
}
