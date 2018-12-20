#region Copyright Syncfusion Inc. 2001 - 2018
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.Windows.Reports.Viewer;
using Microsoft.Win32;
using System.Windows.Threading;
using System.IO;
using System.Collections;
using Syncfusion.Samples.ViewModel;
using Syncfusion.Windows.Shared;
namespace Syncfusion.Samples
{
    public partial class ReportView : ChromelessWindow
    {
        #region Constructor

        public ReportView()
        {
            InitializeComponent();
            SkinStorage.SetVisualStyle(this, "Metro");
        }

        #endregion
    }
}
