namespace XeroProject.PageObjects.Login.LoginClasses
{
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Dashboard.DashboardClasses;
    
    public partial class Login
    {

        /// <summary>
        /// Public method to enter the username and password
        /// </summary>
        public Dashboard EnterUsernameAndPassword(string username, string password)
        {
            //return SelectTabFromItemList(tabName, innerTabName);
            var customControlUsername = FindControlOnPage("userName");
            Mouse.Click(customControlUsername);
            Keyboard.SendKeys(customControlUsername, username, ModifierKeys.None);
            var customControlPassword = FindEditControlOnPage("password");
            Mouse.Click(customControlPassword);
            Keyboard.SendKeys(customControlPassword, password, ModifierKeys.None);
            var loginButton = FindHyperLinkOnPage("Login");
            Mouse.Click(loginButton);
            return new Dashboard();
        }

        /// <summary>
        /// Find the control on the page based on the name
        /// </summary>
        private HtmlCustom FindControlOnPage(string textboxName)
        {
            var list = this.UILoginXeroAccountingSWindow.UILoginXeroAccountingSDocument;
            var customControl = new HtmlCustom(list);
            customControl.SearchProperties.Add(HtmlCustom.PropertyNames.Name, textboxName, PropertyExpressionOperator.Contains);
            return customControl;
        }

        /// <summary>
        /// Find the edit control on page
        /// </summary>
        private HtmlEdit FindEditControlOnPage(string textboxName)
        {
            var list = this.UILoginXeroAccountingSWindow.UILoginXeroAccountingSDocument;
            var customControl = new HtmlEdit(list);
            customControl.SearchProperties.Add(HtmlEdit.PropertyNames.Name, textboxName, PropertyExpressionOperator.Contains);
            return customControl;
        }

        /// <summary>
        /// Find the hyperlink on the page
        /// </summary>
        private HtmlHyperlink FindHyperLinkOnPage(string innerLink)
        {
            var list = this.UILoginXeroAccountingSWindow.UILoginXeroAccountingSDocument;
            var hyperlink = new HtmlHyperlink(list);
            hyperlink.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, innerLink, PropertyExpressionOperator.Contains);
            return hyperlink;
        }
    }
}
