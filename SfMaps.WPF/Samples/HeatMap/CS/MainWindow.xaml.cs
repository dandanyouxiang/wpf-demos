#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace HeatMap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ChromelessWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
    public class Country : INotifyPropertyChanged
    {
        public string NAME { get; set; }

        private Visibility itemsvisibility = Visibility.Visible;
        public Visibility ItemsVisibility
        {
            get { return itemsvisibility; }
            set { itemsvisibility = value; }
        }

        private double weather { get; set; }
        public double Weather
        {
            get
            {
                return weather;
            }
            set
            {
                weather = value;
            }
        }

        private double population { get; set; }
        public double Population
        {
            get
            {
                return population;
            }
            set
            {
                population = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Population"));
            }

        }
        public string PopulationFormat { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            this.PopulationFormat = (String.Format("{0:0,0}", this.Population).Trim('$'));
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }
    public class MapViewModel
    {
        public ObservableCollection<Country> Countries { get; set; }
        public MapViewModel()
        {
            Countries = new ObservableCollection<Country>();
            Countries = GetCountriesAndPopulation();
        }
        private ObservableCollection<Country> GetCountriesAndPopulation()
        {
            ObservableCollection<Country> countries = new ObservableCollection<Country>();
            countries.Add(new Country() { NAME = "Kazakhstan", Population = 3706690 });
            countries.Add(new Country() { NAME = "India", Population = 1210193422 });
            countries.Add(new Country() { NAME = "United States", Population = 314623000 });
            countries.Add(new Country() { NAME = "Australia", Population = 22789701 });
            countries.Add(new Country() { NAME = "Mexico", Population = 112336538 });
            countries.Add(new Country() { NAME = "Russia", Population = 143228300 });
            countries.Add(new Country() { NAME = "Canada", Population = 34955100 });
            countries.Add(new Country() { NAME = "Brazil", Population = 193946886 });
            countries.Add(new Country() { NAME = "Algeria", Population = 37100000 });
            return countries;
        }
    }
}
