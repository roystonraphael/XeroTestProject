using System.Windows.Input;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XeroProject.PageObjects.Sales.RepeatingInvoiceCompleteClasses;

namespace XeroProject.PageObjects.Sales.SalesClasses
{
    /// <summary>
    /// is inherited from the Login class as we can then use
    /// the login methods required to get to the Repeating Invoice Component
    /// </summary>
    public partial class Sales : Login.LoginClasses.Login
    {
        #region Public Methods

        /// <summary>
        /// Select The tab on the page and return the current object
        /// </summary>
        public Sales SelectTabOnPage(string linkName)
        {
            var link = FindInnerLinkOnPage(linkName);
            Mouse.Click(link, new Point(66, 16));

            return this;
        }

        /// <summary>
        /// Enter in the information within the Repeating Invoice UI component
        /// </summary>
        public Sales EnterInvoiceInformation(string dateOfInvoice, string invoiceTo, string reference, string dateDue)
        {
            HtmlEdit editInvoiceDate = SelectEditBoxInCell("StartDate");
            Keyboard.SendKeys(editInvoiceDate, dateOfInvoice, ModifierKeys.None);

            HtmlEdit editDueDateDay = SelectEditBoxInCell("DueDateDay");
            Keyboard.SendKeys(editDueDateDay, dateDue, ModifierKeys.None);

            HtmlRadioButton radButtonDraft = SelectRadioButtonOnPage("saveAsDraft");
            Mouse.Click(radButtonDraft);

            HtmlEdit editInvoiceTo = SelectEditBoxInCell("PaidToName");
            Keyboard.SendKeys(editInvoiceTo, invoiceTo, ModifierKeys.None);

            HtmlEdit editReference = SelectEditBoxInCell("Reference");
            Keyboard.SendKeys(editReference, reference, ModifierKeys.None);

            return this;
        }

        /// <summary>
        /// Enter the item within the grid which contains item information
        /// </summary>
        public Sales EnterItemInGrid(string itemToInsertWithinGrid, string rowNumber)
        {
            //have to click on grid first
            EnterItemOnGrid(itemToInsertWithinGrid, "ext-comp", rowNumber);
            return this;
        }

        /// <summary>
        /// Processes the saving of an invoice by clicking the button
        /// </summary>
        public RepeatingInvoiceComplete SaveRepeatingInvoice()
        {
            HtmlButton btnSave = SelectButtonOnPage("Save");
            Mouse.Click(btnSave);
            return new RepeatingInvoiceComplete();
        }

        /// <summary>
        /// Method used to check value of any label.
        /// Has been used only for total but can be reused for any component on screen
        /// by passing in the labelID and the value expected
        /// </summary>
        public bool CheckLabelOnPage(string labelId, string valueOfLabel)
        {
            HtmlEdit valueOnScreen = SelectEditBoxInCell("invoiceTotal");
            Assert.AreEqual(valueOfLabel, valueOnScreen.Text, "Value of " + labelId + "incorrect");
            return true;
        }

        /// <summary>
        /// Enters in the item provided within the grid
        /// </summary>
        private void EnterItemOnGrid(string itemToInsertWithinGrid, string editBoxSearchProperties, string rowNumber)
        {
            //3 is the first row within the grid as it contains 2 headers
            var getTable = SelectRowOnPage(rowNumber);
            var getDivWithinCell = SelectCellOnPage(1, getTable);
            Mouse.Click(getDivWithinCell);
            HtmlEdit editTextBox = SelectEditBoxInCell(editBoxSearchProperties);
            Keyboard.SendKeys(editTextBox, itemToInsertWithinGrid, ModifierKeys.None);
        }

        /// <summary>
        /// Deletes the row from the grid. There are two divs present within the cell
        /// so it is identified by getting the children within the cell
        /// </summary>
        public Sales DeleteRowFromGrid(string rowNumber)
        {
            //3 is the first row
            var getTable = SelectRowOnPage(rowNumber);
            //first div
            var getDivWithinCell = SelectCellOnPage(11, getTable);
            //second div
            var deleteButton = getDivWithinCell.GetChildren();
            //third div is the one which contains the delete icon
            var deleteTip = deleteButton[0].GetChildren();
            
            Mouse.Click(deleteTip[0]);
            return this;
        }
        #endregion

        #region Private and Internal Methods
        /// <summary>
        /// Selects the row on the page based on the row number provided
        /// </summary>
        private HtmlTable SelectRowOnPage(string rowNumber)
        {
            var list = this.UIXeroSalesWindowsInteWindow.UIXeroNewRepeatingInvoDocument;
            var tableOnScreen = new HtmlTable(list);

            //tag instance identifies which row it's using
            tableOnScreen.SearchProperties.Add(HtmlTable.PropertyNames.TagInstance, rowNumber, PropertyExpressionOperator.EqualTo);
            return tableOnScreen;
        }

        /// <summary>
        /// Selects the cell within the row
        /// Cell number required is passed in as well as the table
        /// </summary>
        private HtmlDiv SelectCellOnPage(int cellNumber, HtmlTable table)
        {
            var cellOnScreen = table.Cells[cellNumber];

            var divWithinCell = cellOnScreen.GetChildren();
            //return the first object found
            return (HtmlDiv)divWithinCell[0];
        }

        /// <summary>
        /// Gets the edit box on the screen based on the ID provided
        /// </summary>
        private HtmlEdit SelectEditBoxInCell(string editBoxName)
        {
            HtmlEdit editBoxWithinCell = new HtmlEdit(this.UIXeroSalesWindowsInteWindow.UIXeroNewRepeatingInvoDocument);
            editBoxWithinCell.SearchProperties.Add(HtmlEdit.PropertyNames.Id, editBoxName, PropertyExpressionOperator.Contains);

            return editBoxWithinCell;
        }

        /// <summary>
        /// Gets the button on the screen based on the ID provided
        /// </summary>
        private HtmlButton SelectButtonOnPage(string innerText)
        {
            HtmlButton button = new HtmlButton(this.UIXeroSalesWindowsInteWindow.UIXeroNewRepeatingInvoDocument);
            button.SearchProperties.Add(HtmlButton.PropertyNames.InnerText, innerText, PropertyExpressionOperator.Contains);
            return button;
        }

        /// <summary>
        /// Gets the radio button on the screen based on the ID provided
        /// </summary>
        private HtmlRadioButton SelectRadioButtonOnPage(string id)
        {
            HtmlRadioButton button = new HtmlRadioButton(this.UIXeroSalesWindowsInteWindow.UIXeroNewRepeatingInvoDocument);
            button.SearchProperties.Add(HtmlRadioButton.PropertyNames.Id, id, PropertyExpressionOperator.Contains);
            return button;
        }

        /// <summary>
        /// Gets the hyperlink on the screen based on the ID provided
        /// </summary>
        private HtmlHyperlink FindInnerLinkOnPage(string innerLink)
        {
            var list = this.UIXeroSalesWindowsInteWindow.UIXeroSalesDocument;
            var hyperlink = new HtmlHyperlink(list);
            hyperlink.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, innerLink, PropertyExpressionOperator.Contains);
            return hyperlink;
        }

        /// <summary>
        /// Gets the custom control on the screen based on the ID provided
        /// </summary>
        internal HtmlCustom FindControlOnPageWithinDiv(string innerText)
        {
            var list = this.UIXeroSalesWindowsInteWindow.UIXeroSalesDocument;
            var customControl = new HtmlCustom(list);
            customControl.SearchProperties.Add(HtmlCustom.PropertyNames.InnerText, innerText, PropertyExpressionOperator.EqualTo);
            return customControl;
        }

        /// <summary>
        /// Gets the div on the screen based on the ID provided
        /// </summary>
        internal HtmlDiv SelectDivOnPage(string divId)
        {
            HtmlDiv divOnPage = new HtmlDiv(this.UIXeroSalesWindowsInteWindow.UIXeroNewRepeatingInvoDocument);
            divOnPage.SearchProperties.Add(HtmlDiv.PropertyNames.Id, divId, PropertyExpressionOperator.Contains);

            return divOnPage;
        }

        #endregion

    }
}
