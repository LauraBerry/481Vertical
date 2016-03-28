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
    /// Interaction logic for Garden2016.xaml
    /// </summary>
    public partial class Garden2016 : UserControl, Switchable
    {
        public String myNotes = " ";
        public Garden2016()
        {
            this.InitializeComponent();
            _2016Notes.Text = myNotes;

        }

        #region Switchable Members

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myNotes = _2016Notes.Text;
            Switcher.Switch(Pages.myHomePage);
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            myNotes = _2016Notes.Text;
            Switcher.Switch(new AddPlant2016());
        }

        private void Remove_Button_Click(object sender, RoutedEventArgs e)
        {
            myNotes = _2016Notes.Text;
            Switcher.Switch(new RemoveFromGarden());
        }

        private void Pomegranit_Button_Click(object sender, RoutedEventArgs e)
        {
            myNotes = _2016Notes.Text;
            Switcher.Switch(new CarrotInformationPage());
        }
    }
}
