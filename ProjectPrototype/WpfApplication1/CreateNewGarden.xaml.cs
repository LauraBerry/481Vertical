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
    /// Interaction logic for CreateNewGarden.xaml
    /// </summary>
    public partial class CreateNewGarden : UserControl, Switchable
    {
        bool clickTitle = false;
        public CreateNewGarden()
        {
            this.InitializeComponent();
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
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new HomeScreen());
        }

        private void GardenName_Focus(object sender, RoutedEventArgs e)
        {
               if(!clickTitle)
               {
                   TextBox name = sender as TextBox;
                   name.Text = String.Empty;
                   clickTitle = true;
               }
        }
    }
}
