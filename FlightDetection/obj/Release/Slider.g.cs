﻿#pragma checksum "..\..\Slider.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F4683462D13C6B4C5106DD22BEBC906F5BC7752F25EA182091DFD92A25950C64"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FlightDetection;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace FlightDetection {
    
    
    /// <summary>
    /// Slider
    /// </summary>
    public partial class Slider : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\Slider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox speed;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Slider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider2;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FlightDetection;component/slider.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Slider.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 13 "..\..\Slider.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Stop);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 17 "..\..\Slider.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.run_back);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 21 "..\..\Slider.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.play);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 25 "..\..\Slider.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.pause);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 29 "..\..\Slider.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.run_forward);
            
            #line default
            #line hidden
            return;
            case 6:
            this.speed = ((System.Windows.Controls.ComboBox)(target));
            
            #line 35 "..\..\Slider.xaml"
            this.speed.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.speed_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 36 "..\..\Slider.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ComboBoxItem_Selected_half);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 37 "..\..\Slider.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ComboBoxItem_Selected_one);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 38 "..\..\Slider.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ComboBoxItem_Selected_oneNhalf);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 39 "..\..\Slider.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ComboBoxItem_Selected_two);
            
            #line default
            #line hidden
            return;
            case 11:
            this.slider2 = ((System.Windows.Controls.Slider)(target));
            
            #line 47 "..\..\Slider.xaml"
            this.slider2.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slider2_ValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
