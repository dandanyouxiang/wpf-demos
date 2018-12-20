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
using Syncfusion.Windows.Shared;
using System.Windows.Input;
using Syncfusion.Windows.Tools.Controls;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows;

namespace HierarchyNavigator_2008
{
    public class ViewModel :NotificationObject
    {
        private ICommand EventLogCommand=null;
        private ObservableCollection<string> eventlog = new ObservableCollection<string>();

        public ObservableCollection<Model> fileItems;

        public ViewModel()
        {
           // EventLogCommand = new DelegateCommand<object>(PropertyChangedHandler);
            fileItems = new ObservableCollection<Model>();
            listBoxItems = new ObservableCollection<Model>();           
            Model fileItem = new Model() { Content = "Desktop"};
            Model MajorDirectory1 = new Model() { Content = "Computer",  FolderImage = new BitmapImage(new Uri("/Images/DesktopOpen.png", UriKind.RelativeOrAbsolute)) };
            Model MajorDirectory2 = new Model() { Content = "Documents", FolderImage = new BitmapImage(new Uri("/Images/DesktopOpen.png", UriKind.RelativeOrAbsolute)) };
            Model MajorDirectory3 = new Model() { Content = "Control Panel", FolderImage = new BitmapImage(new Uri("/Images/DesktopOpen.png", UriKind.RelativeOrAbsolute)) };
            Model MajorDirectory4 = new Model() { Content = "Devices and Printers",FolderImage = new BitmapImage(new Uri("/Images/DesktopOpen.png", UriKind.RelativeOrAbsolute)) } ;
            Model MajorDirectory5 = new Model() { Content = "Default Programs", FolderImage = new BitmapImage(new Uri("/Images/DesktopOpen.png", UriKind.RelativeOrAbsolute)) };
            Model MajorDirectory6 = new Model() { Content = "Help and Support", FolderImage = new BitmapImage(new Uri("/Images/DesktopOpen.png", UriKind.RelativeOrAbsolute)) };

            Model SubDirectory1 = new Model() { Content = "Local Disk (C:)", FolderImage = new BitmapImage(new Uri("/Images/HardDisk.png", UriKind.RelativeOrAbsolute)) };
            SubDirectory1.FolderItems.Add(new Model() { Content = "Program Files", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute))});
            SubDirectory1.FolderItems.Add(new Model() { Content = "Windows", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) });
            SubDirectory1.FolderItems.Add(new Model() { Content = "Syncfusion", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute))});
            SubDirectory1.FolderItems.Add(new Model() { Content = "Drivers", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) });
            SubDirectory1.FolderItems.Add(new Model() { Content = "Perlogs", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) });
            SubDirectory1.FolderItems.Add(new Model() { Content = "Users", FolderImage =  new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) });
            SubDirectory1.FolderItems.Add(new Model() { Content = "Common", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) });
            MajorDirectory1.FolderItems.Add(SubDirectory1);

            Model SubDirectory2 = new Model() { Content = "Local Disk (D:)", FolderImage = new BitmapImage(new Uri("/Images/HardDisk.png", UriKind.RelativeOrAbsolute)) } ;
            SubDirectory2.FolderItems.Add(new Model() { Content = "My Studio", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) });
            MajorDirectory1.FolderItems.Add(SubDirectory2);

            Model SubDirectory3 = new Model() { Content = "Local Disk (E:)", FolderImage = new BitmapImage(new Uri("/Images/HardDisk.png", UriKind.RelativeOrAbsolute)) } ;
            Model SubDirectory4 = new Model() { Content = "Local Disk (F:)", FolderImage = new BitmapImage(new Uri("/Images/HardDisk.png", UriKind.RelativeOrAbsolute)) } ;
            MajorDirectory1.FolderItems.Add(SubDirectory3);
            MajorDirectory1.FolderItems.Add(SubDirectory4);

            Model SubDirectory21 = new Model() { Content = "Pictures", FolderImage = new BitmapImage(new Uri("/Images/Picture.png", UriKind.RelativeOrAbsolute)) };
            SubDirectory21.FolderItems.Add(new Model() { Content = "Windows 7", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) } );
            SubDirectory21.FolderItems.Add(new Model() { Content = "Desert", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) } );
            SubDirectory21.FolderItems.Add(new Model() { Content = "Jelly Fish", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) });
            SubDirectory21.FolderItems.Add(new Model() { Content = "Koala", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) } );
            SubDirectory21.FolderItems.Add(new Model() { Content = "Penguins", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) });

            Model SubDirectory22 = new Model() { Content = "Music", FolderImage = new BitmapImage(new Uri("/Images/Music.png", UriKind.RelativeOrAbsolute)) } ;
            SubDirectory22.FolderItems.Add(new Model() { Content = "Melody", FolderImage = new BitmapImage(new Uri("/Images/Music.png", UriKind.RelativeOrAbsolute)) } );
            SubDirectory22.FolderItems.Add(new Model() { Content = "Pop", FolderImage = new BitmapImage(new Uri("/Images/Music.png", UriKind.RelativeOrAbsolute)) } );

            Model SubDirectory23 = new Model() { Content = "Downloads", FolderImage = new BitmapImage(new Uri("/Images/HDDownloads.png", UriKind.RelativeOrAbsolute)) } ;
            SubDirectory23.FolderItems.Add(new Model() { Content = "Syncfusion Policies", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) } );
            SubDirectory23.FolderItems.Add(new Model() { Content = "Syncfusion Products", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) } );
            SubDirectory23.FolderItems.Add(new Model() { Content = "Syncfusion Guests", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) });

            MajorDirectory2.FolderItems.Add(SubDirectory21);
            MajorDirectory2.FolderItems.Add(SubDirectory22);
            MajorDirectory2.FolderItems.Add(SubDirectory23);

            MajorDirectory3.FolderItems.Add(new Model() { Content = "System and Security", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) } );
            MajorDirectory3.FolderItems.Add(new Model() { Content = "User Accounts", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) } );
            MajorDirectory3.FolderItems.Add(new Model() { Content = "Network and Internet", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) } );
            MajorDirectory3.FolderItems.Add(new Model() { Content = "Appearance and Personalization", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) });
            MajorDirectory3.FolderItems.Add(new Model() { Content = "Hardware and Sound", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) });
            MajorDirectory3.FolderItems.Add(new Model() { Content = "Clock,Languages and Region", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) } );
            MajorDirectory3.FolderItems.Add(new Model() { Content = "Ease of Access", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) } );
            MajorDirectory3.FolderItems.Add(new Model() { Content = "Programs", FolderImage = new BitmapImage(new Uri("/Images/Folder.png", UriKind.RelativeOrAbsolute)) } );
            fileItem.FolderItems.Add(MajorDirectory1);
            fileItem.FolderItems.Add(MajorDirectory2);
            fileItem.FolderItems.Add(MajorDirectory3);
            fileItem.FolderItems.Add(MajorDirectory4);
            fileItem.FolderItems.Add(MajorDirectory5);
            fileItem.FolderItems.Add(MajorDirectory6);
            fileItems.Add(fileItem);
                     SelectedValue = fileItem;
        }
                
        

        public ObservableCollection<string> EventLog
        {
            get { return eventlog; }
            set { eventlog = value; }
        }
        public ICommand SelectedItem
        {
            get
            {
                return EventLogCommand;
            }
        }
        public void PropertyChangedHandler()
        {
            if (SelectedValue != null)
            {
                EventLog.Add("Selection Changed:" + (SelectedValue as Model).Content.ToString());
                ListBoxItems = (SelectedValue as Model).FolderItems;
            }
        }

        private object selectedValue;

        public object SelectedValue 
        { 
            get
            {
                return selectedValue;
            }
            set
            {
                selectedValue = value;
                PropertyChangedHandler();
                RaisePropertyChanged(() => SelectedValue);        
            }
        }

        

        public ObservableCollection<Model> FileItems 
        { 
            get
            {
                return fileItems;
            }
            set
            {
                fileItems = value;               
            }
        }

        private ObservableCollection<Model> listBoxItems;
        public ObservableCollection<Model> ListBoxItems 
        {
            get
            {
                return listBoxItems;
            }
            set
            {
                listBoxItems = value;
                RaisePropertyChanged("ListBoxItems");
            }
        }
    }
}
