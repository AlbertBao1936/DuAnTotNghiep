﻿#pragma checksum "..\..\..\Views\DialogCustoms.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "338F31FE39F981B16F182043C2EF6475411F46C0F17748A9A85D3A1A1BE2ED4B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DuAn_QuanLiKhachSan.Views;
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


namespace DuAn_QuanLiKhachSan.Views {
    
    
    /// <summary>
    /// DialogCustoms
    /// </summary>
    public partial class DialogCustoms : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Views\DialogCustoms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DialogTitle;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Views\DialogCustoms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txblMess;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\DialogCustoms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnYes;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\DialogCustoms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNo;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Views\DialogCustoms.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOK;
        
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
            System.Uri resourceLocater = new System.Uri("/DuAn_QuanLiKhachSan;component/views/dialogcustoms.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\DialogCustoms.xaml"
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
            this.DialogTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.txblMess = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.btnYes = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Views\DialogCustoms.xaml"
            this.btnYes.Click += new System.Windows.RoutedEventHandler(this.btnYes_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnNo = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Views\DialogCustoms.xaml"
            this.btnNo.Click += new System.Windows.RoutedEventHandler(this.btnNo_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnOK = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Views\DialogCustoms.xaml"
            this.btnOK.Click += new System.Windows.RoutedEventHandler(this.btnOK_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

