using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;




namespace DEMO

{
    public class EnvironmentURL
    {
        private IWebDriver _webdriver { get; set; }

        public EnvironmentURL(IWebDriver webDriver)
        {
            _webdriver = webDriver;
        }
        
        public void OpenBrowserDemo()
        {
            

            //OPEN BROWSER--------------------------------------------------------------|

            System.Threading.Thread.Sleep(3000);
            _webdriver.Navigate().GoToUrl("https://www.demo.bnz.co.nz/client/");
            System.Threading.Thread.Sleep(3000);
            _webdriver.Manage().Window.Maximize();



        
       
        }

    }
}
