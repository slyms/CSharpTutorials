using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnkproTraining
{
    [TestClass]
    public class Wait
    {
        [TestMethod]
        public void ThreadWait()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.uitestpractice.com/Students/Contact";
            driver.FindElement(By.PartialLinkText("This is")).Click();

            Thread.Sleep(10000);
            string contact = driver.FindElement(By.ClassName("ContactUs")).Text;
            Console.WriteLine(contact.Contains("Python"));

            driver.Quit();
        }

        [TestMethod]
        public void ImplicitWait()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(12);

            driver.Url = "http://www.uitestpractice.com/Students/Contact";
            driver.FindElement(By.PartialLinkText("This is")).Click();

            string contact = driver.FindElement(By.ClassName("ContactUs")).Text;
            Console.WriteLine(contact.Contains("Python"));

            driver.Quit();
        }

        [TestMethod]
        public void ExplicitWait()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.uitestpractice.com/Students/Contact";
            driver.FindElement(By.PartialLinkText("This is")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(12));
            wait.Until(ExpectedConditions.ElementExists(By.ClassName("ContactUs")));

            string contact = driver.FindElement(By.ClassName("ContactUs")).Text;
            Console.WriteLine(contact.Contains("Python"));

            driver.Quit();
        }

        [TestMethod]
        public void PageLoadWait()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            driver.Url = "http://www.uitestpractice.com/Students/Contact";

            driver.Quit();
        }

        [TestMethod]
        public void MixingOfImplicitWaitAndExplicitWait()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.uitestpractice.com/Students/Contact";

            //Implicit Wait
            Stopwatch watchExplicit = null;
            Stopwatch watchImplicit = null;
            watchImplicit = Stopwatch.StartNew();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            try
            {
                watchExplicit = Stopwatch.StartNew();
                
                //Explicit Wait
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
                wait.Until(ExpectedConditions.ElementExists(By.Id("something")));

                driver.FindElement(By.Id("something")).Click();
            }
            catch (Exception e)
            {
                watchImplicit.Stop();
                watchExplicit.Stop();
                Console.WriteLine(e);
                Console.WriteLine(watchImplicit.ElapsedMilliseconds + " milliseconds");
                Console.WriteLine(watchExplicit.ElapsedMilliseconds + " milliseconds");
            }

            driver.Quit();
        }

        [TestMethod]
        public void CustomExpectedConditionMethod()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.uitestpractice.com/Students/Contact";

            driver.FindElement(By.PartialLinkText("This is")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            //Custom Expected Condition
            wait.Until<IWebElement>(WaitFor);
            Console.WriteLine(driver.FindElement(By.ClassName("ContactUs")).Text);

            driver.Quit();
        }

        private IWebElement WaitFor(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.ClassName("ContactUs"));
            if(element.Displayed && element.Enabled && element.Text.Contains("C#"))
            {
                return element;
            }
            return null;
        }

        [TestMethod]
        public void CustomExpectedConditionLambda()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.uitestpractice.com/Students/Contact";

            driver.FindElement(By.PartialLinkText("This is")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            //Custom Expected Condition
            wait.Until(d =>
            {
                IWebElement element = driver.FindElement(By.ClassName("ContactUs"));
                if (element.Displayed && element.Enabled && element.Text.Contains("C#"))
                {
                    return element;
                }
                return null;
            });
            Console.WriteLine(driver.FindElement(By.ClassName("ContactUs")).Text);

            driver.Quit();
        }

        [TestMethod]
        public void CustomExpectedConditionClass()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.uitestpractice.com/Students/Contact";

            driver.FindElement(By.PartialLinkText("This is")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            //Custom Expected Condition
            wait.Until(CustomExpectedConditions.WaitForElementToContainText(By.ClassName("ContactUs")));

            Console.WriteLine(driver.FindElement(By.ClassName("ContactUs")).Text);

            driver.Quit();
        }

        public class CustomExpectedConditions
        {
            //Method uses Func delegate
            //Stores reference of any lambda expression that accepts input of IWebElement and returns string value
            //Accept by as param
            //Passed IWebDriver, return type: bool
            public static Func<IWebDriver, bool> WaitForElementToContainText(By by)
            {
                //Reference variable
                Func<IWebDriver, bool> myCustomCondition;

                //Assign Func delegate to lambda expression that contains ExpectedCondition logic
                myCustomCondition = driver =>
                {
                    IWebElement element = driver.FindElement(by);

                    if (element != null) //Accessing parent Method's parameter
                    {
                        if (element.Displayed && element.Enabled && element.Text.Contains("C#"))
                            return true;
                        else
                            return false;
                    }
                    return false;
                };

                return myCustomCondition;
            }
        }
    }
}
