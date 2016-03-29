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
    /// Interaction logic for HerbsList.xaml
    /// </summary>
    public partial class HerbsList : UserControl
    {
        public HerbsList()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Pages.pSearch);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Pages.BasilInfo);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Pages.dillInfo);
        }

        private void Ginger_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Pages.gingInfo);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Pages.oregInfo);
        }
    }
}
