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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            Switcher.pageSwitcher = this;
            Switcher.Switch(Pages.myHomePage);
        }
 
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
 
        public void Navigate(UserControl nextPage, object state)
        {
            this.Content = nextPage;
            Switchable s = nextPage as Switchable;
 
            if (s != null)
                s.UtilizeState(state);
            else
                throw new ArgumentException("NextPage is not Switchable! "
                  + nextPage.Name.ToString());
        }
    }
}
