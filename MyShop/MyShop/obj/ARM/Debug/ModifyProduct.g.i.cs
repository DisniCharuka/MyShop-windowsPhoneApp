﻿#pragma checksum "F:\projects\MyShop-windowsPhoneApp\MyShop\MyShop\ModifyProduct.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F4A81D82AEAF070DCCD11D366C01A17A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace MyShop {
    
    
    public partial class ModifyProduct : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock ProductCode;
        
        internal System.Windows.Controls.TextBox txtProductCode;
        
        internal System.Windows.Controls.TextBlock ProductName;
        
        internal System.Windows.Controls.TextBox tbxProductName;
        
        internal System.Windows.Controls.TextBlock Price;
        
        internal System.Windows.Controls.TextBox txtPrice;
        
        internal System.Windows.Controls.TextBlock QtyOnHand;
        
        internal System.Windows.Controls.TextBox txtQtyOnHAnd;
        
        internal System.Windows.Controls.TextBlock ExpDate;
        
        internal System.Windows.Controls.TextBox txtExpDate;
        
        internal System.Windows.Controls.TextBlock AlertPeriod;
        
        internal System.Windows.Controls.TextBox txtAlertPeriod;
        
        internal System.Windows.Controls.TextBlock BuyOrSell;
        
        internal System.Windows.Controls.TextBox txtBuyOrSell;
        
        internal System.Windows.Controls.TextBlock Quanity;
        
        internal System.Windows.Controls.TextBox txtQuantity;
        
        internal System.Windows.Controls.Button btnOk;
        
        internal System.Windows.Controls.Button btnCancel;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/MyShop;component/ModifyProduct.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.ProductCode = ((System.Windows.Controls.TextBlock)(this.FindName("ProductCode")));
            this.txtProductCode = ((System.Windows.Controls.TextBox)(this.FindName("txtProductCode")));
            this.ProductName = ((System.Windows.Controls.TextBlock)(this.FindName("ProductName")));
            this.tbxProductName = ((System.Windows.Controls.TextBox)(this.FindName("tbxProductName")));
            this.Price = ((System.Windows.Controls.TextBlock)(this.FindName("Price")));
            this.txtPrice = ((System.Windows.Controls.TextBox)(this.FindName("txtPrice")));
            this.QtyOnHand = ((System.Windows.Controls.TextBlock)(this.FindName("QtyOnHand")));
            this.txtQtyOnHAnd = ((System.Windows.Controls.TextBox)(this.FindName("txtQtyOnHAnd")));
            this.ExpDate = ((System.Windows.Controls.TextBlock)(this.FindName("ExpDate")));
            this.txtExpDate = ((System.Windows.Controls.TextBox)(this.FindName("txtExpDate")));
            this.AlertPeriod = ((System.Windows.Controls.TextBlock)(this.FindName("AlertPeriod")));
            this.txtAlertPeriod = ((System.Windows.Controls.TextBox)(this.FindName("txtAlertPeriod")));
            this.BuyOrSell = ((System.Windows.Controls.TextBlock)(this.FindName("BuyOrSell")));
            this.txtBuyOrSell = ((System.Windows.Controls.TextBox)(this.FindName("txtBuyOrSell")));
            this.Quanity = ((System.Windows.Controls.TextBlock)(this.FindName("Quanity")));
            this.txtQuantity = ((System.Windows.Controls.TextBox)(this.FindName("txtQuantity")));
            this.btnOk = ((System.Windows.Controls.Button)(this.FindName("btnOk")));
            this.btnCancel = ((System.Windows.Controls.Button)(this.FindName("btnCancel")));
        }
    }
}
