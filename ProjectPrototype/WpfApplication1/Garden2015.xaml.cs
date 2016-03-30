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
    /// Interaction logic for Garden2015.xaml
    /// </summary>
    public partial class Garden2015 : UserControl,Switchable
    {
        public String myNotes = "Never plant Ginger again, it takes over everything and is very hard to get rid of!";
        public Garden2015()
        {
            this.InitializeComponent();
            _2015Notes.Text = myNotes;
        }

        #region Switchable Members

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myNotes = _2015Notes.Text;
            if (myNotes != " " && myNotes != "")
            {
                Pages.myHomePage._2015Note.Visibility = Visibility.Visible;
            }
            else
            {
                Pages.myHomePage._2015Note.Visibility = Visibility.Hidden;
            }
            Switcher.Switch(Pages.myHomePage);
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            myNotes = _2015Notes.Text;
            if (myNotes != " " && myNotes != "")
            {
                Pages.myHomePage._2015Note.Visibility = Visibility.Visible;
            }
            else
            {
                Pages.myHomePage._2015Note.Visibility = Visibility.Hidden;
            }
        }

        private void Remove_Button_Click(object sender, RoutedEventArgs e)
        {
            myNotes = _2015Notes.Text;
            if (myNotes != " " && myNotes != "")
            {
                Pages.myHomePage._2015Note.Visibility = Visibility.Visible;
            }
            else
            {
                Pages.myHomePage._2015Note.Visibility = Visibility.Hidden;
            }
            
        }

        private void Mint_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(Pages.gingInfo);
            if (myNotes != " " && myNotes != "")
            {
                Pages.myHomePage._2015Note.Visibility = Visibility.Visible;
            }
            else
            {
                Pages.myHomePage._2015Note.Visibility = Visibility.Hidden;
            }
        }
    }
}
