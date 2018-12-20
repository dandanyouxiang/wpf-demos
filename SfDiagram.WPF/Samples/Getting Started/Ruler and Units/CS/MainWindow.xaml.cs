#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Runtime.Serialization;
using Syncfusion.UI.Xaml.Diagram;
using Syncfusion.UI.Xaml.Diagram.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Syncfusion.Windows.Shared;


namespace RulerAndUnits
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ChromelessWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            //Initialize Nodes and Connectors

            //Initialize PageSettings,Snapping and Constraints
            InitializeDiagram();
            diagramcontrol.CommandManager.View = Application.Current.MainWindow;

            //Info - for Diagram Events and Commands
            IGraphInfo info = diagramcontrol.Info as IGraphInfo;
            //Event to notify the when Items added
            info.ItemAdded += info_ItemAdded;
        }

        //Event to notify the Changes
        void info_ItemAdded(object sender, ItemAddedEventArgs args)
        {
            //Items added due to clipboard operation
            if (args.ItemSource == ItemSource.ClipBoard)
            {
                if (args.Item is INode)
                {
                    NodeVm node = args.Item as NodeVm;
                    if (!node.IsCustomStyle)
                    {
                        node.ShapeStyle = App.Current.Resources["nodeshapestyle"] as Style;
                    }
                    else
                    {
                        node.ShapeStyle = App.Current.Resources["nodeshapestyle1"] as Style;
                    }
                    AnnotationEditorViewModel vm = (node.Annotations as ICollection<IAnnotation>).ToList()[0] as AnnotationEditorViewModel;
                    if (node.IsMultiline)
                    {
                        vm.ViewTemplate = App.Current.Resources["viewtemplate"] as DataTemplate;
                    }
                    else
                    {
                        vm.ViewTemplate = App.Current.Resources["viewtemplate1"] as DataTemplate;
                    }
                }
            }
        }
        private void InitializeDiagram()
        {
            //Undoable Constraints used to enable/disable Undo/Redo the Action.
            diagramcontrol.KnownTypes = GetKnownTypes;
        }

        //Helps to serialize the Shape
        private IEnumerable<Type> GetKnownTypes()
        {
            List<Type> known = new List<Type>()
            {
                typeof(Shapes)
            };
            foreach (var item in known)
            {
                yield return item;
            }
        }

        //To Represent Unit Selection
        private void UnitsBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (diagramcontrol != null)
            {
                switch ((sender as ComboBox).SelectedIndex)
                {
                    case 0:
                        (diagramcontrol.PageSettings.Unit as LengthUnit).Unit = LengthUnits.Pixels;
                        break;
                    case 1:
                        (diagramcontrol.PageSettings.Unit as LengthUnit).Unit = LengthUnits.Inches;
                        break;
                    case 2:
                        (diagramcontrol.PageSettings.Unit as LengthUnit).Unit = LengthUnits.Feets;
                        break;
                    case 3:
                        (diagramcontrol.PageSettings.Unit as LengthUnit).Unit = LengthUnits.Yards;
                        break;
                    case 4:
                        (diagramcontrol.PageSettings.Unit as LengthUnit).Unit = LengthUnits.Millimeters;
                        break;
                    case 5:
                        (diagramcontrol.PageSettings.Unit as LengthUnit).Unit = LengthUnits.Centimeters;
                        break;
                    case 6:
                        (diagramcontrol.PageSettings.Unit as LengthUnit).Unit = LengthUnits.Meters;
                        break;
                }
            }
        }

    }

    #region CustomClasses
    public class AnnotationCollection : ObservableCollection<IAnnotation>
    {

    }

    public class NodeVmCollection : ObservableCollection<NodeVm>
    {

    }

    //Custom NodeViewModel with new properties
    public class NodeVm : NodeViewModel
    {
        private bool _multiline = false;
        private bool _customstyle = false;
        [DataMember]
        public bool IsMultiline
        {
            get { return _multiline; }
            set
            {
                if (_multiline != value)
                {
                    _multiline = value;
                    OnPropertyChanged("IsMultiline");
                }
            }
        }
        [DataMember]
        public bool IsCustomStyle
        {
            get { return _customstyle; }
            set
            {
                if (_customstyle != value)
                {
                    _customstyle = value;
                    OnPropertyChanged("IsCustomStyle");
                }
            }
        }
    }
    #endregion
}
