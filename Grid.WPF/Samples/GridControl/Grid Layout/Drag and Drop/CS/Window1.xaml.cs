#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace DragDropGrid
{
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
    using Syncfusion.Windows.Shared;
    using Syncfusion.Windows.GridCommon;
    using Syncfusion.Windows.Controls.Grid;

    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : ChromelessWindow
    {
        public Window1()
        {
            InitializeComponent();
            this.InitGrid();
            this.grid.QueryAllowDragColumn += grid_QueryAllowDragColumn;
        }

        void grid_QueryAllowDragColumn(object sender, GridQueryDragColumnHeaderEventArgs e)
        {
            //To disable dragging of First column
            if (e.Column == 0 && e.Reason == GridQueryDragColumnHeaderReason.HitTest)
                e.AllowDrag = false;

            //To disable dropping in First column
            if (e.InsertBeforeColumn == 0 &&
                (e.Reason == GridQueryDragColumnHeaderReason.MouseUp || e.Reason == GridQueryDragColumnHeaderReason.MouseMove))
                e.AllowDrag = false;
        }

        private void InitGrid()
        {
            this.grid.AllowDragColumns = true;
            this.grid.Model.RowCount = 35;
            this.grid.Model.ColumnCount = 25;

            for (int i = 1; i < 35; i++)
            {
                for (int j = 1; j < 25; j++)
                {
                    this.grid.Model[i, j].CellValue = string.Format("Row{0} Col{1}", i, j);
                }
            }
        }
    }
}
