﻿#pragma checksum "..\..\..\PedirPrestamo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6C6D5F5344EF6C6B4ADDFF1CF9DC923ECFFBC424"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using BibliotaWPF;
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


namespace BibliotaWPF {
    
    
    /// <summary>
    /// PedirPrestamo
    /// </summary>
    public partial class PedirPrestamo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\..\PedirPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCerrarPrestamo;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\PedirPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgvListarPrestamos;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\PedirPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbDni;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\PedirPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbTitulo;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\PedirPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPedirLibro;
        
        #line default
        #line hidden
        
        
        #line 202 "..\..\..\PedirPrestamo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDevolver;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BibliotaWPF;V1.0.0.0;component/pedirprestamo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PedirPrestamo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\..\PedirPrestamo.xaml"
            ((BibliotaWPF.PedirPrestamo)(target)).Loaded += new System.Windows.RoutedEventHandler(this.PedirPrestamo_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnCerrarPrestamo = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\PedirPrestamo.xaml"
            this.btnCerrarPrestamo.Click += new System.Windows.RoutedEventHandler(this.btnCerrarPrestamo_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dgvListarPrestamos = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.txbDni = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txbTitulo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnPedirLibro = ((System.Windows.Controls.Button)(target));
            
            #line 173 "..\..\..\PedirPrestamo.xaml"
            this.btnPedirLibro.Click += new System.Windows.RoutedEventHandler(this.btnPedirLibro_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnDevolver = ((System.Windows.Controls.Button)(target));
            
            #line 211 "..\..\..\PedirPrestamo.xaml"
            this.btnDevolver.Click += new System.Windows.RoutedEventHandler(this.btnDevolver_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

