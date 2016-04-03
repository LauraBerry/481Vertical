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
    /// Interaction logic for DaisyInfoPage.xaml
    /// </summary>
    public partial class DaffodilInfoPage : UserControl, Switchable
    {
         public String myNotes = "";
        public DaffodilInfoPage()
        {
            InitializeComponent();
            _DaffodilNotes.Text=myNotes;
        }
        
        #region Switchable Members

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myNotes = _DaffodilNotes.Text;
            if (myNotes != " " && myNotes != "")
            {
                Pages.fList.daffodilNote.Visibility = Visibility.Visible;
                Pages.aFlower2016.daffodilNote.Visibility = Visibility.Visible;
            }
            else
            {
                Pages.fList.daffodilNote.Visibility = Visibility.Hidden;
                Pages.aFlower2016.daffodilNote.Visibility = Visibility.Hidden;
            }
            Switcher.Switch(Pages.fList);
        }
    }
}
