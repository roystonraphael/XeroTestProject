﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace XeroProject.PageObjects.Login.LoginClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public partial class Login
    {
        
        #region Properties
        public UILoginXeroAccountingSWindow UILoginXeroAccountingSWindow
        {
            get
            {
                if ((this.mUILoginXeroAccountingSWindow == null))
                {
                    this.mUILoginXeroAccountingSWindow = new UILoginXeroAccountingSWindow();
                }
                return this.mUILoginXeroAccountingSWindow;
            }
        }
        #endregion
        
        #region Fields
        private UILoginXeroAccountingSWindow mUILoginXeroAccountingSWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UILoginXeroAccountingSWindow : BrowserWindow
    {
        
        public UILoginXeroAccountingSWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Login | Xero Accounting Software";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Login | Xero Accounting Software");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public HtmlDocument UILoginXeroAccountingSDocument
        {
            get
            {
                if ((this.mUILoginXeroAccountingSDocument == null))
                {
                    this.mUILoginXeroAccountingSDocument = new HtmlDocument(this);
                    #region Search Criteria
                    this.mUILoginXeroAccountingSDocument.SearchProperties[HtmlDocument.PropertyNames.Id] = "login";
                    this.mUILoginXeroAccountingSDocument.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
                    this.mUILoginXeroAccountingSDocument.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
                    this.mUILoginXeroAccountingSDocument.FilterProperties[HtmlDocument.PropertyNames.Title] = "Login | Xero Accounting Software";
                    this.mUILoginXeroAccountingSDocument.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
                    this.mUILoginXeroAccountingSDocument.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "https://login.xero.com/";
                    this.mUILoginXeroAccountingSDocument.WindowTitles.Add("Login | Xero Accounting Software");
                    #endregion
                }
                return this.mUILoginXeroAccountingSDocument;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDocument mUILoginXeroAccountingSDocument;
        #endregion
    }
}