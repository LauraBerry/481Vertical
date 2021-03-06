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
    /// Interaction logic for Ginger.xaml
    /// </summary>
    public partial class Ginger : UserControl, Switchable
    {
        public string myNotes = " ";
        public Ginger()
        {
            InitializeComponent();
            _GingerNotes.Text = myNotes;
        }
        #region Switchable Members

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myNotes = _GingerNotes.Text;
            if (myNotes != " " && myNotes != "")
            {
                Pages.hList._gingerNote.Visibility = Visibility.Visible;
                Pages.g2015._gingerNote.Visibility = Visibility.Visible;
                Pages.aHerb2016._gingerNote.Visibility = Visibility.Visible;
            }
            else
            {
                Pages.hList._gingerNote.Visibility = Visibility.Hidden;
                Pages.g2015._gingerNote.Visibility = Visibility.Hidden;
                Pages.aHerb2016._gingerNote.Visibility = Visibility.Hidden;
            }
            Switcher.Switch(Pages.hList);
        }
    }
}
