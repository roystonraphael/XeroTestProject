using System;

namespace XeroProject.PageObjects.Sales.RepeatingInvoiceCompleteClasses
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using SalesClasses;
    
    
    public partial class RepeatingInvoiceComplete
    {
        /// <summary>
        /// Checks if the repeating invoice is added to screen.
        /// Identifies it via the invoice name
        /// </summary>
        public bool CheckRepeatingInvoiceAddedToScreen(string invoiceName)
        {
            HtmlHyperlink invoiceNameOnScreen = FindInvoiceName(invoiceName);
            Assert.AreEqual(invoiceName.ToLower(), invoiceNameOnScreen.InnerText.ToLower(), "Invoice name on screen: " + invoiceNameOnScreen.InnerText);
            return true;
        }

        /// <summary>
        /// Checks for validation errors after invoice is saved
        /// </summary>
        public bool CheckForValidationError(Sales salesObject, string nameOfValidationError)
        {
            HtmlDiv validationErrorDiv = salesObject.SelectDivOnPage("notify01");
            var validationErrorCustomControl = validationErrorDiv.GetChildren();

            HtmlDiv currentValidationError = null;
            
            //loop throught the notification div to find if error exists
            foreach (var currentError in validationErrorCustomControl)
            {
                if (currentError.FriendlyName.Contains(nameOfValidationError))
                {
                    currentValidationError = (HtmlDiv)currentError;
                }
            }

            //check if div is present
            if (currentValidationError != null)
            {
                return true;
            }
            else
            {
                Assert.Fail("Validation box not thrown up");
            }

            return false;
        }

        /// <summary>
        /// Searches for the name of the invoice
        /// </summary>
        private HtmlHyperlink FindInvoiceName(string innerLink)
        {
            var list = this.UIXeroInvoicesInternetWindow.UIXeroInvoicesDocument;
            var hyperlink = new HtmlHyperlink(list);
            hyperlink.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, innerLink, PropertyExpressionOperator.EqualTo);
            return hyperlink;
        }

        
    }
}
