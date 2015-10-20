//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MultipleBrowserTesting
//{
//    using NUnit.Framework;
//    using OpenQA.Selenium;
//    using OpenQA.Selenium.IE;
//    using System;

//    [TestFixture]
//    public class GmailTests
//    {
//        private IWebDriver driver;

//        public GmailTests() { }

//        [SetUp]
//        public void LoadDriver()
//        {
//            Console.WriteLine("SetUp");
//            driver = new InternetExplorerDriver();
//        }

//        [Test]
//        public void Login()
//        {
//            Console.WriteLine("Test");

//            driver.Navigate().GoToUrl("http://gmail.com");
//            driver.FindElement(By.Id("Email")).SendKeys("test");
//            driver.FindElement(By.Id("Passwd")).SendKeys("test");
//            driver.FindElement(By.Id("Passwd")).Submit();

//            Assert.True(driver.Title.Contains("Inbox"));
//        }

//        [TearDown]
//        public void UnloadDriver()
//        {
//            Console.WriteLine("TearDown");
//            driver.Quit();
//        }
//    }

//    [TestFixture, Description("Tests Google Search with String data")]
//    public class GoogleTests
//    {
//        private IWebDriver driver;

//        public GoogleTests() { }

//        [SetUp]

//        public void LoadDriver() { driver = new InternetExplorerDriver(); }

//        [TestCase("Google")]   // searchString = Google
//        [TestCase("Bing")]     // searchString = Bing
//        public void Search(string searchString)
//        {
//            // execute Search twice with testdata: Google, Bing

//            driver.Navigate().GoToUrl("http://google.com");
//            driver.FindElement(By.Name("q")).SendKeys(searchString);
//            driver.FindElement(By.Name("q")).Submit();

//            Assert.True(driver.Title.Contains("Google"));
//        }

//        [TearDown]
//        public void UnloadDriver() { driver.Quit(); }
//    }
//}
