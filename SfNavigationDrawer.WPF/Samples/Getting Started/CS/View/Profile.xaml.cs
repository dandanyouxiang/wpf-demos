#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.UI.Xaml.NavigationDrawer;
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

namespace GettingStarted
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : UserControl
    {
        public SfNavigationDrawer NavigationDrawer { get; set; }
        public Profile()
        {
            InitializeComponent();
        }
        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            if (NavigationDrawer != null)
            {
                if (NavigationDrawer.IsOpen)
                    NavigationDrawer.ToggleDrawer();
                else
                {
                    NavigationDrawer.ToggleDrawer();
                }
            }
        }
    }
}