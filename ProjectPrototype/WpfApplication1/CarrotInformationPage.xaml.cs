﻿using System;
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
    /// Interaction logic for CarrotInformationPage.xaml
    /// </summary>
    public partial class CarrotInformationPage : UserControl, Switchable
    {
        public String myNotes = "";
        public CarrotInformationPage()
        {
            InitializeComponent();
            _CarrotNotes.Text = myNotes;
        }

        #region Switchable Members

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myNotes = _CarrotNotes.Text;
            if (myNotes != " " && myNotes != "")
            {
                Pages.veggieList.carrotNote.Visibility = Visibility.Visible;
                Pages.g2016._carrotNote.Visibility = Visibility.Visible;
                Pages.aVeggie2016.carrotNote.Visibility = Visibility.Visible;
            }
            else
            {
                Pages.veggieList.carrotNote.Visibility = Visibility.Hidden;
                Pages.g2016._carrotNote.Visibility = Visibility.Hidden;
                Pages.aVeggie2016.carrotNote.Visibility = Visibility.Hidden;
            }
            Switcher.Switch(Pages.veggieList);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            myNotes = _CarrotNotes.Text;
            if (myNotes != " " && myNotes != "")
            {
                Pages.veggieList.carrotNote.Visibility = Visibility.Visible;
                Pages.g2016._carrotNote.Visibility = Visibility.Visible;
                Pages.aVeggie2016.carrotNote.Visibility = Visibility.Visible;
            }
            else
            {
                Pages.veggieList.carrotNote.Visibility = Visibility.Hidden;
                Pages.g2016._carrotNote.Visibility = Visibility.Hidden;
                Pages.aVeggie2016.carrotNote.Visibility = Visibility.Hidden;
            }
            Switcher.Switch(Pages.gWithCarrot);
        }
    }
}
