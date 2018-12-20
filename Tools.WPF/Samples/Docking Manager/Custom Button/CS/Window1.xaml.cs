#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Syncfusion.Windows.Tools.Controls;
using Syncfusion.Windows.Shared;


namespace DockingSampleCustomButton
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>

	public partial class Window1 : Window
    {
        

        #region Constructor
        /// <summary>
        /// Construtor for window1
        /// </summary>
        public Window1()
		{
			InitializeComponent();
            InitializeLog();           
		}

        /// <summary>
        /// Initialization while creating object
        /// </summary>    

        public void InitializeLog()
        {
            window1.Width = System.Windows.SystemParameters.PrimaryScreenWidth * (0.67);
            window1.Height = System.Windows.SystemParameters.PrimaryScreenHeight * (0.67);
            this.DockingManager.ContainerMode = DocumentContainerMode.TDI;
        }
        #endregion 

        
    }
}
