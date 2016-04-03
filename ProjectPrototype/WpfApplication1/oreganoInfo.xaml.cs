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
    /// Interaction logic for oreganoInfo.xaml
    /// </summary>
    public partial class oreganoInfo : UserControl, Switchable
    {
        public string myNotes = " ";
        public oreganoInfo()
        {
            InitializeComponent();
            _OreganoNotes.Text = myNotes;
        }
        #region Switchable Members

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myNotes = _OreganoNotes.Text;
            if (myNotes != " " && myNotes != "")
            {
                Pages.hList.oreganoNote.Visibility = Visibility.Visible;
                Pages.aHerb2016.oreganoNote.Visibility = Visibility.Visible;
            }
            else
            {
                Pages.hList.oreganoNote.Visibility = Visibility.Hidden;
                Pages.aHerb2016.oreganoNote.Visibility = Visibility.Hidden;
            }
            Switcher.Switch(Pages.hList);
        }
    }
}
