﻿#pragma checksum "..\..\..\Pages\orderManager.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4CDB7A5CBD818817E659804872A1766E62E399925F81FF15CF86B58938C101A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SemesterProject_WPF_DB;
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


namespace SemesterProject_WPF_DB {
    
    
    /// <summary>
    /// orderManager
    /// </summary>
    public partial class orderManager : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Pages\orderManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid orderDataGrid;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Pages\orderManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_CreateNewOrder;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\orderManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox productIndex;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\orderManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox customerIndex;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\orderManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox workerIndex;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\orderManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox deliveryIndex;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\orderManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button filterByProduct;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\orderManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button filterByCustomer;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\orderManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button filterByWorker;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\orderManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button filterByDelivery;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Pages\orderManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_productCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/SemesterProject_WPF_DB;component/pages/ordermanager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\orderManager.xaml"
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
            
            #line 8 "..\..\..\Pages\orderManager.xaml"
            ((SemesterProject_WPF_DB.orderManager)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.orderDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.button_CreateNewOrder = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Pages\orderManager.xaml"
            this.button_CreateNewOrder.Click += new System.Windows.RoutedEventHandler(this.button_productNewProduct_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.productIndex = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.customerIndex = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.workerIndex = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.deliveryIndex = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 32 "..\..\..\Pages\orderManager.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 32 "..\..\..\Pages\orderManager.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_Unchecked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.filterByProduct = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Pages\orderManager.xaml"
            this.filterByProduct.Click += new System.Windows.RoutedEventHandler(this.SelectByProductID);
            
            #line default
            #line hidden
            return;
            case 10:
            this.filterByCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Pages\orderManager.xaml"
            this.filterByCustomer.Click += new System.Windows.RoutedEventHandler(this.SelectByCustomerID);
            
            #line default
            #line hidden
            return;
            case 11:
            this.filterByWorker = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Pages\orderManager.xaml"
            this.filterByWorker.Click += new System.Windows.RoutedEventHandler(this.SelectByWorkerID);
            
            #line default
            #line hidden
            return;
            case 12:
            this.filterByDelivery = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Pages\orderManager.xaml"
            this.filterByDelivery.Click += new System.Windows.RoutedEventHandler(this.SelectByDeliveryID);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 65 "..\..\..\Pages\orderManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.button_ReloadList);
            
            #line default
            #line hidden
            return;
            case 14:
            this.button_productCancel = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\Pages\orderManager.xaml"
            this.button_productCancel.Click += new System.Windows.RoutedEventHandler(this.button_closeWindow_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

