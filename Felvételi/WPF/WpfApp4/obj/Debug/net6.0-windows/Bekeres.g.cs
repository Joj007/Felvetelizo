﻿#pragma checksum "..\..\..\Bekeres.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C1413D5E7487E165B68CD2FC9F0FA8D14B58762F"
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
using System.Windows.Controls.Ribbon;
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
using WpfApp4;


namespace WpfApp4 {
    
    
    /// <summary>
    /// Bekeres
    /// </summary>
    public partial class Bekeres : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\Bekeres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtOm;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Bekeres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNev;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Bekeres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmail;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Bekeres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txtDatum;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Bekeres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCim;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Bekeres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMatek;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Bekeres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMagyar;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Bekeres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox felvetelizett;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Bekeres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRogzit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp4;component/bekeres.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Bekeres.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\Bekeres.xaml"
            ((WpfApp4.Bekeres)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtOm = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtNev = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtDatum = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.txtCim = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtMatek = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtMagyar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.felvetelizett = ((System.Windows.Controls.CheckBox)(target));
            
            #line 51 "..\..\..\Bekeres.xaml"
            this.felvetelizett.Unchecked += new System.Windows.RoutedEventHandler(this.felvetelizett_UnChecked);
            
            #line default
            #line hidden
            
            #line 51 "..\..\..\Bekeres.xaml"
            this.felvetelizett.Checked += new System.Windows.RoutedEventHandler(this.felvetelizett_Checked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnRogzit = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Bekeres.xaml"
            this.btnRogzit.Click += new System.Windows.RoutedEventHandler(this.txtMagyar_LostFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

