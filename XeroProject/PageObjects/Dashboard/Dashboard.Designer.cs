﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace XeroProject.PageObjects.Dashboard.DashboardClasses
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
    public partial class Dashboard
    {
        
        #region Properties
        public UIXeroDashboardInterneWindow UIXeroDashboardInterneWindow
        {
            get
            {
                if ((this.mUIXeroDashboardInterneWindow == null))
                {
                    this.mUIXeroDashboardInterneWindow = new UIXeroDashboardInterneWindow();
                }
                return this.mUIXeroDashboardInterneWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIXeroDashboardInterneWindow mUIXeroDashboardInterneWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIXeroDashboardInterneWindow : BrowserWindow
    {
        
        public UIXeroDashboardInterneWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Xero | Dashboard - Internet Explorer";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Xero | Dashboard - Internet Explorer");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIXeroDashboardDocument UIXeroDashboardDocument
        {
            get
            {
                if ((this.mUIXeroDashboardDocument == null))
                {
                    this.mUIXeroDashboardDocument = new UIXeroDashboardDocument(this);
                }
                return this.mUIXeroDashboardDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIXeroDashboardDocument mUIXeroDashboardDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIXeroDashboardDocument : HtmlDocument
    {
        
        public UIXeroDashboardDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = "ext-gen5";
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Xero | Dashboard";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Dashboard/Default.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "https://go.xero.com/Dashboard/Default.aspx?redirectCount=0&apToken=4293a009-2d0a-" +
                "450e-93d1-e88ca8eda0ab";
            this.WindowTitles.Add("Xero | Dashboard - Internet Explorer");
            #endregion
        }
        
        #region Properties
        public UIXeronavPane UIXeronavPane
        {
            get
            {
                if ((this.mUIXeronavPane == null))
                {
                    this.mUIXeronavPane = new UIXeronavPane(this);
                }
                return this.mUIXeronavPane;
            }
        }
        #endregion
        
        #region Fields
        private UIXeronavPane mUIXeronavPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIXeronavPane : HtmlDiv
    {
        
        public UIXeronavPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "xero-nav";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "\r\nYou are using a demo of Xero. Set up y";
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"xero-nav\"";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "1";
            this.WindowTitles.Add("Xero | Dashboard - Internet Explorer");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UISalesHyperlink
        {
            get
            {
                if ((this.mUISalesHyperlink == null))
                {
                    this.mUISalesHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUISalesHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUISalesHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUISalesHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUISalesHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Sales";
                    this.mUISalesHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/Accounts/Receivable/Dashboard/";
                    this.mUISalesHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUISalesHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "https://go.xero.com/Accounts/Receivable/Dashboard/";
                    this.mUISalesHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUISalesHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/Accounts/Receivable/Dashboard/\" d";
                    this.mUISalesHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "14";
                    this.mUISalesHyperlink.WindowTitles.Add("Xero | Dashboard - Internet Explorer");
                    #endregion
                }
                return this.mUISalesHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUISalesHyperlink;
        #endregion
    }
}
