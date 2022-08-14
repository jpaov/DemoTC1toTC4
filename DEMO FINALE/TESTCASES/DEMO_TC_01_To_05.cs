using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace DEMO
{
    [TestClass]
    public class DEMO_TC_01_To_05
    {

        [TestMethod]
        public void OpenBrowserVerifyUserCanAddPayeesVerifyPayeeNameVerifyPayeesCanBeSortedByName()
        {
            //============================= WEB DRIVER INITIATOR ======================================|
            //============================== SCREENSHOT LOCATION ======================================|
            string folderName = "C:\\Users\\johnpaolo.villanueva\\OneDrive - MIMS Pte. Ltd\\Desktop\\DEMO\\Screenshot\\";
            string filename = "demo_tc001_to_tc005.png";

            IWebDriver driver = new ChromeDriver();

            //======================== ENVIRONMENT & LOGIN SETUP ======================================|
            EnvironmentURL environmentURL = new EnvironmentURL(driver);

            //========================== TESTCASE STEPS SETUP =========================================|
            TestObjects Menu = new TestObjects(driver);


            //============================== SCREENSHOT SETUP =========================================|
            ScreenShotHelper screenShotHelper = new ScreenShotHelper(folderName, driver);


            //====================== ENVIRONMENT & LOGIN PROCESS ======================================|
            environmentURL.OpenBrowserDemo();


            //=========================== TESTCASE STEPS PROCESS ======================================|
           Menu.Menu1();
            Menu.Payees1();
            Menu.AddPayees1();
            Menu.PayeesName1(); 
            Menu.PayeesAccountNumber1();
            Menu.ShouldNotShowValidationError();
            Menu.AddButton1();


            environmentURL.OpenBrowserDemo();
            Menu.Menu1();
            Menu.Payees1();
            Menu.AddPayees1();
            Menu.AddButton1();
            Menu.ShouldShowValidationError();

/*            environmentURL.OpenBrowserDemo();
            Menu.Menu1();
            Menu.Payees1();
            Menu.VerifyAscendingList();
            Menu.NavigateToPaymentPage();
            Menu.TransferFromEveryDayAccountToBillsAccount(); */



            //========================== SCREENSHOT PROCESS ===========================================|
            screenShotHelper.ScreenshotResultPage(filename);
            System.Threading.Thread.Sleep(5000);

            //=================== END OF TESTCASE/ CLOSE BROWSER ======================================|
          //  Environment.Exit(0);
           // driver.Quit();


        }
    }
}





