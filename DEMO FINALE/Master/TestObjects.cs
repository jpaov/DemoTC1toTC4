using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace DEMO

{

    public class TestObjects
    {
        private IWebDriver _webdriver { get; set; }

        public TestObjects(IWebDriver webDriver)
        {
            _webdriver = webDriver;
        }

        public void Menu1()
        {
            IJavaScriptExecutor js = _webdriver as IJavaScriptExecutor;
            System.Threading.Thread.Sleep(5000);
            js.ExecuteScript("window.scrollBy(0, 950);");
            System.Threading.Thread.Sleep(5000);

            //xpath texts --------------------------------------------------------|
            By MenuLeftSide = By.XPath("/html/body/div[2]/div/div/div[3]/div[2]/div[2]/div/div[1]/div/button");


            //act ----------------------------------------------------------------|
            _webdriver.FindElement(MenuLeftSide).Click();
            System.Threading.Thread.Sleep(3000);


        }
        public void Payees1()
        {

            //xpath texts --------------------------------------------------------|
            By PayeesMenu = By.XPath("/html/body/div[2]/div/div/div[3]/div[2]/div[2]/div/div[1]/div/div[3]/section/div[2]/nav[1]/ul/li[3]/a");

            //act ----------------------------------------------------------------|
            _webdriver.FindElement(PayeesMenu).Click();
            System.Threading.Thread.Sleep(3000);
            _webdriver.Url.Contains("https://www.demo.bnz.co.nz/client/payees");
            System.Threading.Thread.Sleep(8000);


        }
        public void AddPayees1()
        {


            //xpath texts --------------------------------------------------------|
            By AddButton = By.XPath("/html/body/div[2]/div/div/div[3]/section/section/div/div[2]/header[2]/div/div[3]/button");

            //act ----------------------------------------------------------------|
            _webdriver.FindElement(AddButton).Click();
            System.Threading.Thread.Sleep(3000);



        }
        public void PayeesName1()
        {

            //xpath texts --------------------------------------------------------|
            By TextfieldPayeeName = By.XPath("/html/body/div[2]/div/div/div[1]/div/div/div[4]/div/form/div[1]/div[1]/div[2]/div/div[1]/input");

            //act ----------------------------------------------------------------|
            _webdriver.FindElement(TextfieldPayeeName).SendKeys("AAA AAA");
            System.Threading.Thread.Sleep(3000);
            _webdriver.FindElement(TextfieldPayeeName).SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(3000);



        }
        public void PayeesAccountNumber1()
        {


            //xpath texts --------------------------------------------------------|
            By textbox1 = By.XPath("/html/body/div[2]/div/div/div[1]/div/div/div[4]/div/form/div[1]/div[1]/div[3]/input[1]");
            By textbox2 = By.XPath("/html/body/div[2]/div/div/div[1]/div/div/div[4]/div/form/div[1]/div[1]/div[3]/input[2]");
            By textbox3 = By.XPath("/html/body/div[2]/div/div/div[1]/div/div/div[4]/div/form/div[1]/div[1]/div[3]/input[3]");
            By textbox4 = By.XPath("/html/body/div[2]/div/div/div[1]/div/div/div[4]/div/form/div[1]/div[1]/div[3]/input[4]");

            //act ----------------------------------------------------------------|
            _webdriver.FindElement(textbox1).SendKeys("42");
            _webdriver.FindElement(textbox2).SendKeys("3423");
            _webdriver.FindElement(textbox3).SendKeys("3234333");
            _webdriver.FindElement(textbox4).SendKeys("001");

            System.Threading.Thread.Sleep(3000);


        }

        public void AddButton1()
        {

            //xpath texts --------------------------------------------------------|
            By ButtonAdd1 = By.XPath("/html/body/div[2]/div/div/div[1]/div/div/div[4]/div/form/div[2]/button[3]");

            //act ----------------------------------------------------------------|
            _webdriver.FindElement(ButtonAdd1).Click();
            System.Threading.Thread.Sleep(5000);
            _webdriver.PageSource.Contains("Payee added");
            System.Threading.Thread.Sleep(3000);
            _webdriver.PageSource.Contains("Test Name1");


        }
        public void ShouldShowValidationError()
        {

            System.Threading.Thread.Sleep(5000);
            _webdriver.PageSource.Contains("A problem was found. Please correct the field highlighted below.");
            _webdriver.PageSource.Contains("Payee Name is a required field. Please Complete to continue.");


        }
        public void ShouldNotShowValidationError()
        {
            try
            {
                _webdriver.PageSource.Contains("A problem was found. Please correct the field highlighted below.");
                _webdriver.PageSource.Contains("Payee Name is a required field. Please Complete to continue.");

                Console.WriteLine("Error Message Has Been Detected");
                Assert.Fail();
                _webdriver.Quit();
            }
            catch
            {
                Console.WriteLine("No Error Message Detected");

            }

        }
        public void VerifyAscendingList()
        {

            //xpath texts --------------------------------------------------------|
            By List1 = By.XPath("/html/body/div[2]/div/div/div[3]/section/section/div/ul/li[1]/div/div/div[1]/div/p[1]");

            //act ----------------------------------------------------------------|
            try
            {
                List1.Equals("AAA AAA");
                Console.WriteLine("It is in Ascending Order");

            }
            catch
            {
                Console.WriteLine("It is NOT in Ascending Order");
                Assert.Fail();
                _webdriver.Quit();
            }

        }
        public void NavigateToPaymentPage()
        {

            System.Threading.Thread.Sleep(5000);
            By Pay = By.XPath("/html/body/div[2]/div/div/div[3]/section/section/div/ul/li[1]/div/div/div[3]/div/button[1]/span");

            //act ----------------------------------------------------------------|
            _webdriver.FindElement(Pay).Click();



        }
        public void TransferFromEveryDayAccountToBillsAccount()
        {

            System.Threading.Thread.Sleep(5000);
            By TextfieldAmount = By.XPath("/html/body/div[7]/div/div/div/div/div[2]/form/div[1]/div/span/span[1]/input");


            By From = By.XPath("/html/body/div[7]/div/div/div/div/div[1]/div/div[1]/button");
            By TextfieldFrom = By.XPath("/html/body/div[7]/div/div/div[2]/div/div/div/span/span[1]/input");
            By EverydayAccount = By.Name("Everyday");


            By To = By.XPath("/html/body/div[7]/div/div/div/div/div[1]/div/div[2]/button");
            By TextfieldTo = By.XPath("/html/body/div[7]/div/div/div[2]/div/div/div/span/span[1]/input");
            By BillsAccount = By.Name("Bills");



            //act ----------------------------------------------------------------|
            // input $500
            _webdriver.FindElement(TextfieldAmount).SendKeys("500");

            // From Everyday
            _webdriver.FindElement(From).Click();
            _webdriver.FindElement(TextfieldFrom).SendKeys("Every");
            _webdriver.FindElement(EverydayAccount).Click();


            // To bills
            _webdriver.FindElement(To).Click();
            _webdriver.FindElement(TextfieldTo).SendKeys("Bill");
            _webdriver.FindElement(BillsAccount).Click();







        }


    }
}

    

