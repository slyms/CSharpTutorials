using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnkproTraining
{
    [TestClass]
    public class JavaScriptExecutor
    {
        [TestMethod]
        public void JavaScriptDemo()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com/";

            //Refresh Page
            ((IJavaScriptExecutor)driver).ExecuteScript("history.go(0)");
            Thread.Sleep(2000);

            //Alert Window
            ((IJavaScriptExecutor)driver).ExecuteScript("alert('Hello')");
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void JavaScriptCheckbox()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Form";

            //Mark checkbox
            ((IJavaScriptExecutor)driver).ExecuteScript("document.querySelectorAll('input[value = read]')[0].click()");
            Thread.Sleep(2000);

            //Mark checkbox
            ((IJavaScriptExecutor)driver).ExecuteScript("document.querySelectorAll('input[value = read]')[0].click()");

            driver.Quit();
        }

        [TestMethod]
        public void JavaScriptInnerText()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com";

            string text = ((IJavaScriptExecutor)driver).ExecuteScript("return document.documentElement.innerText;").ToString();
            Console.WriteLine("innerText: " + text);
            Thread.Sleep(2000);

            driver.Quit();
        }

        [TestMethod]
        public void JavaScriptPageTitle()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com";

            string text = ((IJavaScriptExecutor)driver).ExecuteScript("return document.title;").ToString();
            Console.WriteLine("Text: " + text);
            Thread.Sleep(2000);

            driver.Quit();
        }

        [TestMethod]
        public void JavaScriptPageDomain()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com";

            string text = ((IJavaScriptExecutor)driver).ExecuteScript("return document.domain;").ToString();
            Console.WriteLine("Text: " + text);
            Thread.Sleep(2000);

            driver.Quit();
        }

        [TestMethod]
        public void JavaScriptPageUrl()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com";

            string text = ((IJavaScriptExecutor)driver).ExecuteScript("return document.URL;").ToString();
            Console.WriteLine("Text: " + text);
            Thread.Sleep(2000);

            driver.Quit();
        }

        [TestMethod]
        public void JavaScriptPageScroll()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com";

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void JavaScriptPageNavigate()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com";

            ((IJavaScriptExecutor)driver).ExecuteScript("window.location='http://ankpro.com/'");
            Thread.Sleep(2000);

            driver.Quit();
        }

        [TestMethod]
        public void JavaScriptPageHeightAndWidth()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com";

            string height = ((IJavaScriptExecutor)driver).ExecuteScript("return window.innerHeight").ToString();
            Console.WriteLine("Height: " + height);
            Thread.Sleep(2000);

            string width = ((IJavaScriptExecutor)driver).ExecuteScript("return window.innerWidth").ToString();
            Console.WriteLine("Width: " + width);
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void JavaScriptTypeText()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com/Account/Register";

            ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementById('Email').value='abc@abc.com';");
            Thread.Sleep(2000);

            driver.Quit();
        }

        [TestMethod]
        public void JavaScriptGetHiddenValue()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Index";
            driver.FindElement(By.XPath("//tbody//tr[2]//td[4]//button[1]")).Click();

            string hiddenValue=((IJavaScriptExecutor)driver).ExecuteScript("return document.getElementById('Id').value").ToString();
            Console.WriteLine($"hiddenValue: {hiddenValue}");

            Thread.Sleep(2000);

            driver.Quit();
        }
    }
}
