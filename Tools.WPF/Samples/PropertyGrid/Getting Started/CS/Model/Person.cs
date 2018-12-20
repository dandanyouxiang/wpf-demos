#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using Syncfusion.Windows.PropertyGrid;
using Syncfusion.Windows.Shared;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace PropertyGridConfigurationDemo
{  
   [TypeConverter(typeof(ExpandableObjects))]
    public class Person
    {
        public Person()
        {
            FirstName = "Carl";
            LastName = "Johnson";
            Age = 30;
            Mobile = 91983467382;
            Email = "carljohnson@gta.com";
            ID = "0005A";
            FavoriteColor = Brushes.Gray;
            IsLicensed = true;
            DOB = new DateTime(1987, 10, 16);
            Key = "dasd798@79hiujodsa';psdoiu9*(Uj0JK)(";
            Bank = new Bank() { Name = "Centura Banks", AccountNumber = 00987453721, CustomerID = "carljohnson", Password = "nuttertools" };
        }

        [CategoryAttribute("Identity")]
        [DisplayNameAttribute("First Name")]
        [DescriptionAttribute("First Name of the actual person.")]
        public string FirstName
        {
            get;

            set;
        }

        [CategoryAttribute("Identity")]
        [DisplayNameAttribute("Last Name")]
        [DescriptionAttribute("Last Name of the actual person.")]
        public string LastName
        {
            get;

            set;
        }

        [CategoryAttribute("Identity")]
        [DisplayNameAttribute("ID")]
        [DescriptionAttribute("ID of the actual person.")]
        public string ID
        {
            get;

            set;
        }

        [CategoryAttribute("Identity")]
        [DisplayNameAttribute("Date of Birth")]
        [DescriptionAttribute("Birth date of the actual person.")]
        public DateTime DOB
        {
            get;

            set;
        }

        [CategoryAttribute("Contact Details")]
        [DisplayNameAttribute("Email ID")]
        [DescriptionAttribute("Email address of the actual person.")]
        public string Email
        {
            get;

            set;
        }

        [CategoryAttribute("Contact Details")]
        [DisplayNameAttribute("Mobile Number")]
        [DescriptionAttribute("Contact Number of the actual person.")]
        public long Mobile
        {
            get;

            set;
        }

        [CategoryAttribute("Identity")]
        [DisplayNameAttribute("Age")]
        [DescriptionAttribute("Age of the actual person.")]
        public int Age
        {
            get;

            set;
        }

        [CategoryAttribute("Identity")]
        [DisplayNameAttribute("Image")]
        [DescriptionAttribute("Photo shot of the actual person.")]
        public ImageSource Image
        {
            get;

            set;
        }

        [CategoryAttribute("Favorites")]
        [DisplayNameAttribute("Favorite Color")]
        [DescriptionAttribute("Favorite color of the actual person.")]
        public Brush FavoriteColor
        {
            get;

            set;
        }

        [CategoryAttribute("Identity")]
        [DisplayNameAttribute("Gender")]
        [DescriptionAttribute("Gender information of the actual person.")]
        public Gender Gender
        {
            get;

            set;
        }

        [CategoryAttribute("Location")]
        [DisplayNameAttribute("Country")]
        [DescriptionAttribute("Country where the actual person locating.")]
        public Country Country
        {
            get;

            set;
        }

        [Browsable(false)]
        public string MaritalStatus
        {
            get;

            set;
        }

        [CategoryAttribute("License Details")]
        [DisplayNameAttribute("IsLicensed")]
        [DescriptionAttribute("Determines whether the person is licensed or not.")]
        public bool IsLicensed
        {
            get;

            set;
        }

        [CategoryAttribute("License Details")]
        [DisplayNameAttribute("Key")]
        [DescriptionAttribute("License key value of the person.")]
        public string Key
        {
            get;

            set;
        }

        [CategoryAttribute("Account Details")]
        [DisplayNameAttribute("Bank")]
        [DescriptionAttribute("Bank in which he has account.")]
        public Bank Bank
        {
            get;

            set;
        }
    }  
}
