﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "75D13690F4E266732D6E6008770C0316"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace WpfCommonDataAccess {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfCommonDataAccess.MainWindow WPFCommonData;
        
        #line default
        #line hidden
        
        
        #line 6 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtConnectionString;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboProviders;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTest;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSQL;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRun;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtStatus;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfCommonDataAccess;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.WPFCommonData = ((WpfCommonDataAccess.MainWindow)(target));
            
            #line 4 "..\..\MainWindow.xaml"
            this.WPFCommonData.Closing += new System.ComponentModel.CancelEventHandler(this.WPFCommonData_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtConnectionString = ((System.Windows.Controls.TextBox)(target));
            
            #line 6 "..\..\MainWindow.xaml"
            this.txtConnectionString.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtConnectionString_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.comboProviders = ((System.Windows.Controls.ComboBox)(target));
            
            #line 7 "..\..\MainWindow.xaml"
            this.comboProviders.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboProviders_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnTest = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\MainWindow.xaml"
            this.btnTest.Click += new System.Windows.RoutedEventHandler(this.btnTest_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtSQL = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnRun = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\MainWindow.xaml"
            this.btnRun.Click += new System.Windows.RoutedEventHandler(this.btnRun_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtStatus = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

