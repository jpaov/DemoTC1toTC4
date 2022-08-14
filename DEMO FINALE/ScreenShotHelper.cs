using OpenQA.Selenium;
using System;
using System.IO;

namespace DEMO

{

    public class ScreenShotHelper
    {
        private string _folderPath { get; set; }
        private IWebDriver _webDriver { get; set; }


        public ScreenShotHelper(string folderPath, IWebDriver webDriver)
        {
            _folderPath = folderPath;
            _webDriver = webDriver;

        }
        public void ScreenshotResultPage(string filename)
        {
            try
            { 

            Screenshot screenshotObject = ((ITakesScreenshot)_webDriver).GetScreenshot();
            screenshotObject.SaveAsFile(Path.Combine(_folderPath, filename), OpenQA.Selenium.ScreenshotImageFormat.Png);

            _webDriver.Quit();
        }
        catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}