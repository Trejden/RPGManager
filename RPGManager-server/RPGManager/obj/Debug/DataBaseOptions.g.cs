﻿#pragma checksum "..\..\DataBaseOptions.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "87D91627FAEA8A97D1C337195254B69C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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


namespace RPGManager {
    
    
    /// <summary>
    /// DataBaseOptions
    /// </summary>
    public partial class DataBaseOptions : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\DataBaseOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal RPGManager.DataBaseOptions Opcja_Bazy_Danych;
        
        #line default
        #line hidden
        
        
        #line 6 "..\..\DataBaseOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button newDatabase;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\DataBaseOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loadDatabase;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\DataBaseOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button newDatabaseSQLite;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\DataBaseOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button connecttoSQLserver;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication2;component/databaseoptions.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DataBaseOptions.xaml"
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
            this.Opcja_Bazy_Danych = ((RPGManager.DataBaseOptions)(target));
            return;
            case 2:
            this.newDatabase = ((System.Windows.Controls.Button)(target));
            
            #line 6 "..\..\DataBaseOptions.xaml"
            this.newDatabase.Click += new System.Windows.RoutedEventHandler(this.create_Database);
            
            #line default
            #line hidden
            return;
            case 3:
            this.loadDatabase = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\DataBaseOptions.xaml"
            this.loadDatabase.Click += new System.Windows.RoutedEventHandler(this.load_Database);
            
            #line default
            #line hidden
            return;
            case 4:
            this.newDatabaseSQLite = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\DataBaseOptions.xaml"
            this.newDatabaseSQLite.Click += new System.Windows.RoutedEventHandler(this.create_Database2);
            
            #line default
            #line hidden
            return;
            case 5:
            this.connecttoSQLserver = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\DataBaseOptions.xaml"
            this.connecttoSQLserver.Click += new System.Windows.RoutedEventHandler(this.ConnectToDatabase);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
