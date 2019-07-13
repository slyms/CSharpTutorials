using System;
using System.Drawing;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AnkproTraining
{
    [TestClass]
    public class SeleniumBasics
    {
        [TestMethod]
        public void LaunchBrowser()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com";
            Thread.Sleep(4000);
        }
        [TestMethod]
        public void GetPageTitleUrlAndPageSource()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com";

            Console.WriteLine(driver.Title);

            Console.WriteLine(driver.Url);
            driver.Url = "http://uitestpractice.com";
            string url = driver.Url;

            Console.WriteLine(driver.PageSource);
            driver.Quit();
        }
        [TestMethod]
        public void ManageBrowserWindow()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com";

            driver.Manage().Window.Minimize();
            Thread.Sleep(4000);

            driver.Manage().Window.FullScreen();
            Thread.Sleep(4000);

            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);

            driver.Manage().Window.Position = new Point(400, 200);
            Thread.Sleep(4000);

            Point point = driver.Manage().Window.Position;
            Console.WriteLine(point);

            driver.Manage().Window.Size = new Size(400, 600);
            Thread.Sleep(4000);

            Size size = driver.Manage().Window.Size;
            Console.WriteLine(size);

            driver.Quit();
        }
        [TestMethod]
        public void BrowserNavigation()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com";

            driver.Navigate().GoToUrl("http://uitestpractice.com");
            Thread.Sleep(4000);

            driver.Navigate().Back();
            Thread.Sleep(4000);

            driver.Navigate().Forward();
            Thread.Sleep(4000);

            driver.Navigate().Refresh();
            Thread.Sleep(4000);

            driver.Quit();
        }
    }
}
