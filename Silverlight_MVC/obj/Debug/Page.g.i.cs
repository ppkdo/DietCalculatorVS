﻿#pragma checksum "\\psf\Home\Documents\blogs\porting\Silverlight_MVC\Silverlight_MVC\Page.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "01E3A773B6B2BB21215DDD2CF7D53693"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Silverlight_MVC;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Silverlight_MVC {
    
    
    public partial class Page : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Silverlight_MVC.DietCalculatorView_v1 calculatorView_v1;
        
        internal Silverlight_MVC.DietCalculatorView_v2 calculatorView_v2;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Silverlight_MVC;component/Page.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.calculatorView_v1 = ((Silverlight_MVC.DietCalculatorView_v1)(this.FindName("calculatorView_v1")));
            this.calculatorView_v2 = ((Silverlight_MVC.DietCalculatorView_v2)(this.FindName("calculatorView_v2")));
        }
    }
}
