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
    /// Interaction logic for CarrotRemoved.xaml
    /// </summary>
    public partial class CarrotRemoved : UserControl, Switchable
    {
        public CarrotRemoved()
        {
            InitializeComponent();
        }
               #region Switchable Members

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion
           private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new HomeScreen());
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new PlantSearch());
        }

        private void Remove_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new RemoveFromGarden());
        }

        private void Add_Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AddPlant2016());
        }
    }
}
