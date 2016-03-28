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
    /// Interaction logic for HomeScreen.xaml
    /// </summary>
    public partial class HomeScreen : UserControl, Switchable
    {
        
        public HomeScreen()
        {
            this.InitializeComponent();
        }

        #region Switchable Members

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void PlantCategories_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Pages.pSearch);
        }

        private void _2016Garden_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Pages.g2016);
        }

        private void Create_NewGarden_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Pages.newGarden);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Pages.g2015);
        }
    }
}
