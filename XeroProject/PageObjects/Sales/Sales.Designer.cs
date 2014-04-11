﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace XeroProject.PageObjects.Sales.SalesClasses
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
    public partial class Sales
    {
        
        /// <summary>
        /// RecordedMethod1
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            HtmlDiv uIItemPane = this.UIXeroSalesWindowsInteWindow.UIXeroNewRepeatingInvoDocument1.UIExtgen21Pane.UIItemPane;
            #endregion

            // Click pane
            Mouse.Click(uIItemPane, new Point(9, 5));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Mouse hover  pane at (12, 7)
            Mouse.Hover(uIItemPane, new Point(12, 7));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click pane
            Mouse.Click(uIItemPane, new Point(11, 6));
        }
        
        #region Properties
        public UIXeroSalesWindowsInteWindow UIXeroSalesWindowsInteWindow
        {
            get
            {
                if ((this.mUIXeroSalesWindowsInteWindow == null))
                {
                    this.mUIXeroSalesWindowsInteWindow = new UIXeroSalesWindowsInteWindow();
                }
                return this.mUIXeroSalesWindowsInteWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIXeroSalesWindowsInteWindow mUIXeroSalesWindowsInteWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIXeroSalesWindowsInteWindow : BrowserWindow
    {
        
        public UIXeroSalesWindowsInteWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Xero | Sales";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Xero | Sales");
            this.WindowTitles.Add("Xero | New Repeating Invoice");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public HtmlDocument UIXeroSalesDocument
        {
            get
            {
                if ((this.mUIXeroSalesDocument == null))
                {
                    this.mUIXeroSalesDocument = new HtmlDocument(this);
                    #region Search Criteria
                    this.mUIXeroSalesDocument.SearchProperties[HtmlDocument.PropertyNames.Id] = "ext-gen1018";
                    this.mUIXeroSalesDocument.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
                    this.mUIXeroSalesDocument.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
                    this.mUIXeroSalesDocument.FilterProperties[HtmlDocument.PropertyNames.Title] = "Xero | Sales";
                    this.mUIXeroSalesDocument.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Accounts/Receivable/Dashboard/";
                    this.mUIXeroSalesDocument.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "https://go.xero.com/Accounts/Receivable/Dashboard/";
                    this.mUIXeroSalesDocument.WindowTitles.Add("Xero | Sales");
                    #endregion
                }
                return this.mUIXeroSalesDocument;
            }
        }
        
        public HtmlDocument UIXeroNewRepeatingInvoDocument
        {
            get
            {
                if ((this.mUIXeroNewRepeatingInvoDocument == null))
                {
                    this.mUIXeroNewRepeatingInvoDocument = new HtmlDocument(this);
                    #region Search Criteria
                    this.mUIXeroNewRepeatingInvoDocument.SearchProperties[HtmlDocument.PropertyNames.Id] = "ext-gen9";
                    this.mUIXeroNewRepeatingInvoDocument.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
                    this.mUIXeroNewRepeatingInvoDocument.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
                    this.mUIXeroNewRepeatingInvoDocument.FilterProperties[HtmlDocument.PropertyNames.Title] = "Xero | New Repeating Invoice";
                    this.mUIXeroNewRepeatingInvoDocument.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/RepeatTransactions/Edit.aspx";
                    this.mUIXeroNewRepeatingInvoDocument.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "https://go.xero.com/RepeatTransactions/Edit.aspx?type=AR";
                    this.mUIXeroNewRepeatingInvoDocument.WindowTitles.Add("Xero | New Repeating Invoice");
                    #endregion
                }
                return this.mUIXeroNewRepeatingInvoDocument;
            }
        }
        
        public UIXeroNewRepeatingInvoDocument1 UIXeroNewRepeatingInvoDocument1
        {
            get
            {
                if ((this.mUIXeroNewRepeatingInvoDocument1 == null))
                {
                    this.mUIXeroNewRepeatingInvoDocument1 = new UIXeroNewRepeatingInvoDocument1(this);
                }
                return this.mUIXeroNewRepeatingInvoDocument1;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDocument mUIXeroSalesDocument;
        
        private HtmlDocument mUIXeroNewRepeatingInvoDocument;
        
        private UIXeroNewRepeatingInvoDocument1 mUIXeroNewRepeatingInvoDocument1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIXeroNewRepeatingInvoDocument1 : HtmlDocument
    {
        
        public UIXeroNewRepeatingInvoDocument1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = "ext-gen9";
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Xero | New Repeating Invoice";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/RepeatTransactions/Edit.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "https://go.xero.com/RepeatTransactions/Edit.aspx?type=AR&redirectCount=0&apToken=" +
                "44030513-382d-4f0c-b911-a4417784acad";
            this.WindowTitles.Add("Xero | New Repeating Invoice");
            #endregion
        }
        
        #region Properties
        public UIExtgen21Pane UIExtgen21Pane
        {
            get
            {
                if ((this.mUIExtgen21Pane == null))
                {
                    this.mUIExtgen21Pane = new UIExtgen21Pane(this);
                }
                return this.mUIExtgen21Pane;
            }
        }
        #endregion
        
        #region Fields
        private UIExtgen21Pane mUIExtgen21Pane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIExtgen21Pane : HtmlDiv
    {
        
        public UIExtgen21Pane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "ext-gen21";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "x-grid3-body";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"x-grid3-body\" id=\"ext-gen21\" style=\"width: 905px;\"";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "183";
            this.WindowTitles.Add("Xero | New Repeating Invoice");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIItemPane
        {
            get
            {
                if ((this.mUIItemPane == null))
                {
                    this.mUIItemPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIItemPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIItemPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "ux-row-action-item icons delete-small ";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"ux-row-action-item icons delete-small \" qtip=\"Delete line item\"";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "198";
                    this.mUIItemPane.WindowTitles.Add("Xero | New Repeating Invoice");
                    #endregion
                }
                return this.mUIItemPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIItemPane;
        #endregion
    }
}