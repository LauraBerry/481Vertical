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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class AfricanVioletInformation : UserControl, Switchable
    {
        public String myNotes = "";
        public AfricanVioletInformation()
        {
            InitializeComponent();
            _AfricanVioletNotes.Text = myNotes;
        }
        #region Switchable Members

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myNotes = _AfricanVioletNotes.Text;
            Switcher.Switch(Pages.fList);
        }
    }
}
