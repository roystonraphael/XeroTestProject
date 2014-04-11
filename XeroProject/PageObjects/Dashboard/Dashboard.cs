namespace XeroProject.PageObjects.Dashboard.DashboardClasses
{
    using System.Drawing;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Sales.SalesClasses;
    
    public partial class Dashboard
    {
        /// <summary>
        /// public method used to navigate to the correct tab
        /// </summary>
        public Sales SelectTab(string tabName, string innerTabName)
        {
            return SelectTabFromItemList(tabName, innerTabName);
        }

        /// <summary>
        /// Searches for the tab name as well as the second level tab name within the dashboard
        /// </summary>
        private Sales SelectTabFromItemList(string tabName, string innerTabName)
        {
            var firstControl = FindControlOnPage(tabName);
            Mouse.Click(firstControl);
            var secondHyperlink = FindHyperLinkOnPage(innerTabName);
            Mouse.Click(secondHyperlink);
            return new Sales();
        }

        /// <summary>
        /// Searches for the control on the page
        /// </summary>
        private HtmlCustom FindControlOnPage(string tabId)
        {
            var list = this.UIXeroDashboardInterneWindow.UIXeroDashboardDocument;
            var customControl = new HtmlCustom(list);
            customControl.SearchProperties.Add(HtmlCustom.PropertyNames.Id, tabId, PropertyExpressionOperator.Contains);
            return customControl;
        }

        /// <summary>
        /// Searches for the hyperlink on the page
        /// </summary>
        private HtmlHyperlink FindHyperLinkOnPage(string innerLink)
        {
            var list = this.UIXeroDashboardInterneWindow.UIXeroDashboardDocument.UIXeronavPane;
            var hyperlink = new HtmlHyperlink(list);
            hyperlink.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, innerLink, PropertyExpressionOperator.Contains);
            return hyperlink;
        }
    }
}
