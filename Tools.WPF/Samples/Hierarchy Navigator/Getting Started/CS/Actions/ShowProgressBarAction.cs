#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Interactivity;
using System.Windows.Controls;
using Syncfusion.Windows.Tools.Controls;
using System.Windows;

namespace HierarchyNavigator_2008
{
    public class ShowProgressBarAction : TargetedTriggerAction<Button>
    {
#if Framework3_5       
        public FrameworkElement TargetObject
        {
            get { return (FrameworkElement)GetValue(TargetObjectProperty); }
            set { SetValue(TargetObjectProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Target.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TargetObjectProperty =
            DependencyProperty.Register("TargetObject", typeof(FrameworkElement), typeof(ShowProgressBarAction), new UIPropertyMetadata(null));
#endif
        protected override void Invoke(object parameter)
        {
            ((HierarchyNavigator)TargetObject).ShowProgressBar(new TimeSpan(0, 0, 0, 0,ShowValue));
        }

        public int ShowValue
        {
            get { return (int)GetValue(ShowValueProperty); }
            set { SetValue(ShowValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ShowValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowValueProperty =
            DependencyProperty.Register("ShowValue", typeof(int), typeof(ShowProgressBarAction), new UIPropertyMetadata(null));

        
    }
}
