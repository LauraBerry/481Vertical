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
    /// Interaction logic for PeachInfo.xaml
    /// </summary>
    public partial class PeachInfo : UserControl, Switchable
    {
        public string myNotes = " ";
        public PeachInfo()
        {
            InitializeComponent();
            _PeachNotes.Text = myNotes;
        }
        #region Switchable Members

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myNotes = _PeachNotes.Text;
            if (myNotes != " " && myNotes != "")
            {
                Pages.frList.peachNote.Visibility = Visibility.Visible;
            }
            else
            {
                Pages.frList.peachNote.Visibility = Visibility.Hidden;
            }
            Switcher.Switch(Pages.frList);
        }
    }
}
