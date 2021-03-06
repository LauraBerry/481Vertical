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
    /// Interaction logic for AppleInfoPage.xaml
    /// </summary>
    public partial class AppleInfoPage : UserControl
    {
        public String myNotes = "";
        public AppleInfoPage()
        {
            InitializeComponent();
            _GrannySmithNotes.Text = myNotes;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myNotes = _GrannySmithNotes.Text;
            if(myNotes!=" " && myNotes!="")
            {
                Pages.frList.appleNote.Visibility = Visibility.Visible;
                Pages.g2016._appleNote.Visibility = Visibility.Visible;
                Pages.aFruit2016.appleNote.Visibility = Visibility.Visible;
            } 
            else
            {
                Pages.frList.appleNote.Visibility = Visibility.Hidden;
                Pages.g2016._appleNote.Visibility = Visibility.Hidden;
                Pages.aFruit2016.appleNote.Visibility = Visibility.Hidden;
            }
            Switcher.Switch(Pages.frList);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            myNotes = _GrannySmithNotes.Text;
            if (myNotes != " " && myNotes != "")
            {
                Pages.frList.appleNote.Visibility = Visibility.Visible;
                Pages.g2016._appleNote.Visibility = Visibility.Visible;
                Pages.aFruit2016.appleNote.Visibility = Visibility.Visible;
            }
            else
            {
                Pages.frList.appleNote.Visibility = Visibility.Hidden;
                Pages.g2016._appleNote.Visibility = Visibility.Hidden;
                Pages.aFruit2016.appleNote.Visibility = Visibility.Hidden;
            }
            Switcher.Switch(Pages.gWithCarrot);
        }
    }
}
