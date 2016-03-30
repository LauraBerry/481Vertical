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
    /// Interaction logic for Artichoke.xaml
    /// </summary>
    public partial class Artichoke : UserControl, Switchable
    {
        public string myNotes = " ";
        public Artichoke()
        {
            InitializeComponent();
            _ArtichokeNotes.Text = myNotes;
        }
        #region Switchable Members

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myNotes = _ArtichokeNotes.Text;
            if (myNotes != " " && myNotes != "")
            {
                Pages.veggieList.artichokeNote.Visibility = Visibility.Visible;
            }
            Switcher.Switch(Pages.veggieList);
        }
    }
}
