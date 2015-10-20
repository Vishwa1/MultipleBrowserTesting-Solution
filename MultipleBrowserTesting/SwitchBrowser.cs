using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using NUnit;
using OpenQA.Selenium.Remote;

namespace MultipleBrowserTesting
{
    [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(ChromeDriver))]
    [TestFixture(typeof(InternetExplorerDriver))]
    public class SwitchBrowser<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        private IWebDriver _driver;

        [Test]
        [Repeat (2)]
        public void Can_Visit_Google()
        {
            _driver = new TWebDriver();
            ICapabilities capabilities = ((RemoteWebDriver)_driver).Capabilities;
            string browser = capabilities.BrowserName;
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://www.google.ie/");

            switch (browser)
            { 
                case ("internet explorer"):
                    _driver.FindElement(By.Id("lst-ib")).SendKeys("ElasticSearch");
                    break;

                case ("chrome"): _driver.FindElement(By.Id("lst-ib")).SendKeys("MongoDB");
                    break;

                case ("firefox"): _driver.FindElement(By.Id("lst-ib")).SendKeys("Selenium");
                    break;
            }
            _driver.FindElement(By.Name("btnG")).Click();
            Screenshot ss = ((ITakesScreenshot)_driver).GetScreenshot();
            ss.SaveAsFile("C:/Users/VVibhute/Pictures/screenshot1.png", System.Drawing.Imaging.ImageFormat.Png);
            FixtureTearDown();
        }

        [TestFixtureTearDown]
        public void FixtureTearDown()
        {
            _driver.Close();
        }
    }
}