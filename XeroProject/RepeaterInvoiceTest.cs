/****************************** Module Header ******************************\ 
* Module Name:  RepeaterInvoiceTest.cs 
* Project:      XeroProject
* Copyright (c) Royston Raphael. 
*  
* This class is designed to test the funtionality of the repeater Invoice
* UI Component
*  
* Tested on IE 10 and all test passed
* 
* History: 
* 08/04/2014 Royston Raphael Created 
\***************************************************************************/

using System.Globalization;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XeroProject.PageObjects.Sales.SalesClasses;


namespace XeroProject
{
    /// <summary>
    /// Tests the UI of the Repeating Invoice component
    /// </summary>
    [CodedUITest]
    public class RepeaterInvoiceTest
    {
        #region Initialisation of fields
        private const int FIRSTROWONCELL = 3;
        private Sales _salesObject;
        #endregion

        #region Main Methods
        /// <summary>
        /// Check the values of the totals on screen once an invoice has been filled in correctly.
        /// Adds two invoices then checks if the total label matches what is expected.
        /// fully working
        /// </summary>
        [TestMethod]
        public void CheckValuesOfLabelsForAInvoice()
        {
            //workflow to get to the page we require
            //Assert.IsTrue(salesObject.EnterUsernameAndPassword("royston.raphael@gmail.com", "lampard8").SelectTab("Accounts", "Sales").SelectTabOnPage("+").SelectTabOnPage("Repeating").EnterInvoiceInformation("GB1-White{Tab}", "3").EnterInvoiceInformation("PR-BR{Tab}", "4").CheckLabelOnPage("invoiceTotal", "293.94"), "Not functioning correctly");
            
            //process to get to the repeating invoice page so we can check the total label
            Assert.IsTrue(_salesObject.EnterUsernameAndPassword("royston.raphael@gmail.com", "tester12")
                       .SelectTab("Accounts", "Sales")
                       .SelectTabOnPage("+")
                       .SelectTabOnPage("Repeating")
                       .EnterInvoiceInformation("15 Apr 2015", "TestCompany", "ReferenceTest", "10")
                       .EnterItemInGrid("GB1-White{Tab}", FIRSTROWONCELL.ToString(CultureInfo.InvariantCulture))
                       .EnterItemInGrid("PR-BR{Tab}", (FIRSTROWONCELL+1).ToString(CultureInfo.InvariantCulture))
                       .CheckLabelOnPage("invoiceTotal", "293.94"), "Test Failed");
        }


        /// <summary>
        /// Created this test to check if the invoice saves correctly
        /// Ulitlised data access method to save 3 invoices into the system.
        /// Data is extracted from CSV file
        /// fully working
        /// </summary>
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
           "|DataDirectory|\\data\\RepeatingInvoice.csv", "RepeatingInvoice#csv", DataAccessMethod.Sequential),
        DeploymentItem("RepeatingInvoice.csv"), TestMethod]
        public void SaveReapeatingInvoices()
        {
            Assert.IsTrue(_salesObject.EnterUsernameAndPassword("royston.raphael@gmail.com", "tester12")
                                       .SelectTab("Accounts", "Sales")
                                       .SelectTabOnPage("+")
                                       .SelectTabOnPage("Repeating")
                                       .EnterInvoiceInformation(TestContext.DataRow["InvoiceDate"].ToString(), 
                                                    TestContext.DataRow["InvoiceTo"].ToString(),
                                                        TestContext.DataRow["reference"].ToString(),
                                                            TestContext.DataRow["DateDue"].ToString())
                                       .EnterItemInGrid(TestContext.DataRow["Item"] + "{Tab}", FIRSTROWONCELL.ToString(CultureInfo.InvariantCulture))
                                       .SaveRepeatingInvoice()
                                       .CheckRepeatingInvoiceAddedToScreen(TestContext.DataRow["InvoiceTo"].ToString()), "Test Failed"); ;
        }

        /// <summary>
        /// Check whether the invoice does not save when a required field like the invoice date is not enetered
        /// does not work doesn't check correct validation field
        /// </summary>
        [TestMethod]
        public void CheckInvoiceDoesNotSaveOnRequiredFieldMissing()
        {
            //workflow to get to the page we require
            //Assert.IsTrue(salesObject.EnterUsernameAndPassword("royston.raphael@gmail.com", "lampard8").SelectTab("Accounts", "Sales").SelectTabOnPage("+").SelectTabOnPage("Repeating").EnterInvoiceInformation("GB1-White{Tab}", "3").EnterInvoiceInformation("PR-BR{Tab}", "4").CheckLabelOnPage("invoiceTotal", "293.94"), "Not functioning correctly");

            //pass in no Invoice company which will cause validation error check if the validation appears
            Assert.IsTrue(_salesObject.EnterUsernameAndPassword("royston.raphael@gmail.com", "tester12")
                                      .SelectTab("Accounts", "Sales")
                                      .SelectTabOnPage("+")
                                      .SelectTabOnPage("Repeating")
                                      .EnterInvoiceInformation("15 Apr 2015", " ", "ReferenceTest", "10")
                                      .EnterItemInGrid("GB1-White{Tab}",
                                                       FIRSTROWONCELL.ToString(CultureInfo.InvariantCulture))
                                      .SaveRepeatingInvoice()
                                      .CheckForValidationError(_salesObject, "error occurred"), "Test Failed");
        }

        /// <summary>
        /// Check whether the invoice does not save when a required field like the invoice date is not enetered
        /// does not work doesn't check correct validation field
        /// </summary>
        [TestMethod]
        public void CheckRowOnCellDeletedAfterPopulated()
        {
            //check the row within the grid is deleted and there causes the total to reduce
            Assert.IsTrue(_salesObject.EnterUsernameAndPassword("royston.raphael@gmail.com", "tester12")
                                      .SelectTab("Accounts", "Sales")
                                      .SelectTabOnPage("+")
                                      .SelectTabOnPage("Repeating")
                                      .EnterInvoiceInformation("15 Apr 2015", "Test Company", "ReferenceTest", "10")
                                      .EnterItemInGrid("GB1-White{Tab}",
                                                       FIRSTROWONCELL.ToString(CultureInfo.InvariantCulture))
                                      .EnterItemInGrid("PR-BR{Tab}",
                                                       (FIRSTROWONCELL + 1).ToString(CultureInfo.InvariantCulture))
                                      .DeleteRowFromGrid(FIRSTROWONCELL.ToString(CultureInfo.InvariantCulture))
                                      .CheckLabelOnPage("invoiceTotal", "287.50"), "Test Failed");
        }
        #endregion

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {        
            //run before every test
            BrowserWindow.ClearCache();
            BrowserWindow.ClearCookies();
            BrowserWindow.Launch("https://login.xero.com");
            _salesObject = new Sales();

        }

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
