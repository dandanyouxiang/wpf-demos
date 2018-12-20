#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interactivity;

namespace GridDropDownAndReadOnlyColumns
{
    public class SfDataGridBehavior : Behavior<SfDataGrid>
    {
        protected override void OnAttached()
        {
            this.AssociatedObject.Loaded += AssociatedObject_Loaded;
        }

        void AssociatedObject_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {            
            this.AssociatedObject.CurrentCellRequestNavigate += AssociatedObject_CurrentCellRequestNavigate;            
        }

        void AssociatedObject_CurrentCellRequestNavigate(object sender, CurrentCellRequestNavigateEventArgs args)
        {
            string str = "http://en.wikipedia.org/wiki/" + args.NavigateText;
            Process.Start(new ProcessStartInfo(str));
        }

        protected override void OnDetaching()
        {
            this.AssociatedObject.CurrentCellRequestNavigate -= AssociatedObject_CurrentCellRequestNavigate;
            this.AssociatedObject.Loaded -= AssociatedObject_Loaded;
        }
    }
}
