﻿#pragma checksum "..\..\MainFrame.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E085A372F509DEFDA3283A38484F0DA2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DenisVuyka.Controls.PropertyGrid;
using MathMLToCSharp;
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


namespace MathMLToCSharp {
    
    
    /// <summary>
    /// MainFrame
    /// </summary>
    public partial class MainFrame : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\MainFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MathMLToCSharp.MainFrame myWindow;
        
        #line default
        #line hidden
        
        
        #line 217 "..\..\MainFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink lnkPaste;
        
        #line default
        #line hidden
        
        
        #line 218 "..\..\MainFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink lnkFormat;
        
        #line default
        #line hidden
        
        
        #line 223 "..\..\MainFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbIn;
        
        #line default
        #line hidden
        
        
        #line 230 "..\..\MainFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink lnkCopy;
        
        #line default
        #line hidden
        
        
        #line 231 "..\..\MainFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink lnkVerify;
        
        #line default
        #line hidden
        
        
        #line 236 "..\..\MainFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbOut;
        
        #line default
        #line hidden
        
        
        #line 241 "..\..\MainFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView mmlTree;
        
        #line default
        #line hidden
        
        
        #line 248 "..\..\MainFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DenisVuyka.Controls.PropertyGrid.PropertyGrid propGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/MathMLToCSharp;component/mainframe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainFrame.xaml"
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
            this.myWindow = ((MathMLToCSharp.MainFrame)(target));
            
            #line 7 "..\..\MainFrame.xaml"
            this.myWindow.Closing += new System.ComponentModel.CancelEventHandler(this.myWindow_Closing);
            
            #line default
            #line hidden
            
            #line 7 "..\..\MainFrame.xaml"
            this.myWindow.KeyDown += new System.Windows.Input.KeyEventHandler(this.myWindow_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lnkPaste = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 217 "..\..\MainFrame.xaml"
            this.lnkPaste.Click += new System.Windows.RoutedEventHandler(this.lnkPaste_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lnkFormat = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 218 "..\..\MainFrame.xaml"
            this.lnkFormat.Click += new System.Windows.RoutedEventHandler(this.lnkFormat_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbIn = ((System.Windows.Controls.TextBox)(target));
            
            #line 223 "..\..\MainFrame.xaml"
            this.tbIn.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbIn_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lnkCopy = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 230 "..\..\MainFrame.xaml"
            this.lnkCopy.Click += new System.Windows.RoutedEventHandler(this.lnkCopy_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lnkVerify = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 231 "..\..\MainFrame.xaml"
            this.lnkVerify.Click += new System.Windows.RoutedEventHandler(this.lnkVerify_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tbOut = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.mmlTree = ((System.Windows.Controls.TreeView)(target));
            return;
            case 9:
            this.propGrid = ((DenisVuyka.Controls.PropertyGrid.PropertyGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

