﻿#pragma checksum "..\..\Administrator.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B19C51851838D6CE4EF7B5031D61EED4"
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
using Workshop;


namespace Workshop {
    
    
    /// <summary>
    /// Administrator
    /// </summary>
    public partial class Administrator : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\Administrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AttendeeInformation;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Administrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid WorkshopsGrid;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Administrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WriteToJson;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Administrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditMaster;
        
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
            System.Uri resourceLocater = new System.Uri("/Workshop;component/administrator.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Administrator.xaml"
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
            this.AttendeeInformation = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.WorkshopsGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.WriteToJson = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\Administrator.xaml"
            this.WriteToJson.Click += new System.Windows.RoutedEventHandler(this.Btn_Save);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EditMaster = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\Administrator.xaml"
            this.EditMaster.Click += new System.Windows.RoutedEventHandler(this.EditMaster_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

