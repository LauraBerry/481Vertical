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
    /// Interaction logic for AddVegetable2016.xaml
    /// </summary>
    public partial class AddVegetable2016 : UserControl, Switchable
    {
        public AddVegetable2016()
        {
            this.InitializeComponent();
        }

        #region Switchable Members

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void Carrot_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Pages.g2016);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Pages.aPlant2016);
        }

        private void Carrot_Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Pages.g2016);
        }

    }
}
