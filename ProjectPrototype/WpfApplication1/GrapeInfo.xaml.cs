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
    /// Interaction logic for GrapeInfo.xaml
    /// </summary>
    public partial class GrapeInfo : UserControl, Switchable
    {
        public string myNotes = " ";
        public GrapeInfo()
        {
            InitializeComponent();
            _GrapeNotes.Text = myNotes;
        }
        #region Switchable Members

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myNotes = _GrapeNotes.Text;
            if (myNotes != " " && myNotes != "")
            {
                Pages.frList.grapeNote.Visibility = Visibility.Visible;
                Pages.aFruit2016.grapeNote.Visibility = Visibility.Visible;
            }
            else
            {
                Pages.frList.grapeNote.Visibility = Visibility.Hidden;
                Pages.aFruit2016.grapeNote.Visibility = Visibility.Hidden;
            }
            Switcher.Switch(Pages.frList);
        }
    }
}
