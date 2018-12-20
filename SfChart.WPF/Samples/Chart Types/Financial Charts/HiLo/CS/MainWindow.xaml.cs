#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.SampleLayout;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace HiloChart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : SampleLayoutWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class Model
    {
        public DateTime Date { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
    }

    public class ViewModel
    {
        public ViewModel()
        {
            this.StockPriceDetails = new ObservableCollection<Model>();
            DateTime date = new DateTime(2012, 4, 1);

            this.StockPriceDetails.Add(new Model() { Date = date.AddDays(0), Open = 873.8, High = 878.85, Low = 855.5, Close = 860.5 });
            this.StockPriceDetails.Add(new Model() { Date = date.AddDays(1), Open = 873.8, High = 878.85, Low = 855.5, Close = 860.5 });
            this.StockPriceDetails.Add(new Model() { Date = date.AddDays(2), Open = 861, High = 868.4, Low = 835.2, Close = 843.45 });
            this.StockPriceDetails.Add(new Model() { Date = date.AddDays(3), Open = 846.15, High = 853, Low = 838.5, Close = 847.5 });
            this.StockPriceDetails.Add(new Model() { Date = date.AddDays(4), Open = 846, High = 860.75, Low = 841, Close = 855 });
            this.StockPriceDetails.Add(new Model() { Date = date.AddDays(5), Open = 841, High = 845, Low = 827.85, Close = 838.65 });
            this.StockPriceDetails.Add(new Model() { Date = date.AddDays(6), Open = 846, High = 874.5, Low = 841, Close = 860.75 });
            this.StockPriceDetails.Add(new Model() { Date = date.AddDays(7), Open = 865, High = 872, Low = 865, Close = 868.9 });
        }

        public ObservableCollection<Model> StockPriceDetails { get; set; }
    }
}
