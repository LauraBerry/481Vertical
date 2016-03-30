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
    /// Interaction logic for EdelwiessInfo.xaml
    /// </summary>
    public partial class EdelwiessInfo : UserControl, Switchable
    {
        public String myNotes = "";
        public EdelwiessInfo()
        {
            InitializeComponent();
            _EdelWiessNotes.Text = myNotes;
        }
        #region Switchable Members

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myNotes = _EdelWiessNotes.Text;
            if (myNotes != " " && myNotes != "")
            {
                Pages.fList.edelswiessNote.Visibility = Visibility.Visible;
            }
            Switcher.Switch(Pages.fList);
        }
    }
}
