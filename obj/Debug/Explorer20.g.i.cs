﻿#pragma checksum "..\..\Explorer20.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "446541F8671EF1C2C3654F1A60C20733F6286742A34AF00FFC8A0B43BBC3D8F3"
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
using Windows_20_Explorer_Concept;


namespace Windows_20_Explorer_Concept {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 302 "..\..\Explorer20.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle TopBar;
        
        #line default
        #line hidden
        
        
        #line 306 "..\..\Explorer20.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closebtn;
        
        #line default
        #line hidden
        
        
        #line 307 "..\..\Explorer20.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button resizebtn;
        
        #line default
        #line hidden
        
        
        #line 308 "..\..\Explorer20.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minimisebtn;
        
        #line default
        #line hidden
        
        
        #line 313 "..\..\Explorer20.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel Tabs;
        
        #line default
        #line hidden
        
        
        #line 314 "..\..\Explorer20.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateTabBtn;
        
        #line default
        #line hidden
        
        
        #line 318 "..\..\Explorer20.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame ExplorerWindow;
        
        #line default
        #line hidden
        
        
        #line 320 "..\..\Explorer20.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border WindowBorder;
        
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
            System.Uri resourceLocater = new System.Uri("/Windows 20 Explorer Concept;component/explorer20.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Explorer20.xaml"
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
            
            #line 8 "..\..\Explorer20.xaml"
            ((Windows_20_Explorer_Concept.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TopBar = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 302 "..\..\Explorer20.xaml"
            this.TopBar.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TopBar_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.closebtn = ((System.Windows.Controls.Button)(target));
            
            #line 306 "..\..\Explorer20.xaml"
            this.closebtn.Click += new System.Windows.RoutedEventHandler(this.closebtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.resizebtn = ((System.Windows.Controls.Button)(target));
            
            #line 307 "..\..\Explorer20.xaml"
            this.resizebtn.Click += new System.Windows.RoutedEventHandler(this.resizebtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.minimisebtn = ((System.Windows.Controls.Button)(target));
            
            #line 308 "..\..\Explorer20.xaml"
            this.minimisebtn.Click += new System.Windows.RoutedEventHandler(this.minimisebtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Tabs = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 7:
            this.CreateTabBtn = ((System.Windows.Controls.Button)(target));
            
            #line 314 "..\..\Explorer20.xaml"
            this.CreateTabBtn.Click += new System.Windows.RoutedEventHandler(this.CreateTab);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ExplorerWindow = ((System.Windows.Controls.Frame)(target));
            return;
            case 9:
            this.WindowBorder = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

