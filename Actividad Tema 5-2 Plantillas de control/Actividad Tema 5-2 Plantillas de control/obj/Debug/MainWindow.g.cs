﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6AFE9AFEB4E9D2FE5A4A252AE54E265E2D6D8669D7E084F84B0B1DC2B41D6EF1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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


namespace Actividad_Tema_5_2_Plantillas_de_control {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 62 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stack;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nombrePlato;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox imagenPlato;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Tipo;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkLeche;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkSoja;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkGluten;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkSulfitos;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listbox;
        
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
            System.Uri resourceLocater = new System.Uri("/Actividad Tema 5-2 Plantillas de control;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.stack = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.nombrePlato = ((System.Windows.Controls.TextBox)(target));
            
            #line 64 "..\..\MainWindow.xaml"
            this.nombrePlato.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NombrePlato_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.imagenPlato = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Tipo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.checkLeche = ((System.Windows.Controls.CheckBox)(target));
            
            #line 75 "..\..\MainWindow.xaml"
            this.checkLeche.Checked += new System.Windows.RoutedEventHandler(this.CheckLeche_Checked);
            
            #line default
            #line hidden
            
            #line 75 "..\..\MainWindow.xaml"
            this.checkLeche.Unchecked += new System.Windows.RoutedEventHandler(this.CheckLeche_Unchecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.checkSoja = ((System.Windows.Controls.CheckBox)(target));
            
            #line 76 "..\..\MainWindow.xaml"
            this.checkSoja.Checked += new System.Windows.RoutedEventHandler(this.CheckSoja_Checked);
            
            #line default
            #line hidden
            
            #line 76 "..\..\MainWindow.xaml"
            this.checkSoja.Unchecked += new System.Windows.RoutedEventHandler(this.CheckSoja_Unchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.checkGluten = ((System.Windows.Controls.CheckBox)(target));
            
            #line 77 "..\..\MainWindow.xaml"
            this.checkGluten.Checked += new System.Windows.RoutedEventHandler(this.CheckGluten_Checked);
            
            #line default
            #line hidden
            
            #line 77 "..\..\MainWindow.xaml"
            this.checkGluten.Unchecked += new System.Windows.RoutedEventHandler(this.CheckGluten_Unchecked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.checkSulfitos = ((System.Windows.Controls.CheckBox)(target));
            
            #line 78 "..\..\MainWindow.xaml"
            this.checkSulfitos.Checked += new System.Windows.RoutedEventHandler(this.CheckSulfitos_Checked);
            
            #line default
            #line hidden
            
            #line 78 "..\..\MainWindow.xaml"
            this.checkSulfitos.Unchecked += new System.Windows.RoutedEventHandler(this.CheckSulfitos_Unchecked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.listbox = ((System.Windows.Controls.ListBox)(target));
            
            #line 83 "..\..\MainWindow.xaml"
            this.listbox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Listbox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

