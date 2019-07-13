using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support;
using System;
using System.Threading;

namespace AnkproTraining
{
    [TestClass]
    public class ActionsClass
    {
        [TestMethod]
        public void ActionsSendKeys()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com";

            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.End)
                .Perform();
            actions.SendKeys(Keys.Home)
                .Perform();

            Thread.Sleep(2000);
            driver.Url = "http://uitestpractice.com/Students/Actions";

            actions.SendKeys(driver.FindElement(By.Name("click")), Keys.Enter)
                .Perform();

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void ActionsMoveToElement()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);

            actions.MoveToElement(driver.FindElement(By.Id("div2")))
                .ContextClick()
                .Build()
                .Perform();

            actions.MoveToElement(driver.FindElement(By.Id("selectable")))
                .Click()
                .Build();
            //.Perform();

            actions.MoveToElement(driver.FindElement(By.Id("selectable")), 20, 20)
                .Click()
                .Build();
            //.Perform();

            actions.MoveToElement(driver.FindElement(By.Id("selectable")), 20, 20, MoveToElementOffsetOrigin.TopLeft)
                .DoubleClick()
                .Build()
                .Perform();

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void ActionsClick()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);
            actions.Click(driver.FindElement(By.Name("click")))
                .Build()
                .Perform();

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void ActionsDoubleClick()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);
            actions.DoubleClick(driver.FindElement(By.Name("dblClick")))
                .Build()
                .Perform();

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void ActionsClickAndHold()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);
            actions.ClickAndHold(driver.FindElement(By.Id("draggable")))
                .Build();
                //.Perform();
            actions.MoveToElement(driver.FindElement(By.Id("droppable")))
                .Build();
                //.Perform();
            actions.Release()
                .Build()
                .Perform();

            actions.ClickAndHold(driver.FindElement(By.Name("one")))
                .Release(driver.FindElement(By.Name("twelve")))
                .Build()
                .Perform();

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void ActionsMoveByOffset()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);
            actions.MoveByOffset(200, 200)
                .ContextClick()
                .Build()
                .Perform();

            actions.ClickAndHold(driver.FindElement(By.Name("six")))
                .MoveByOffset(-60, -50)
                .Build()
                .Perform();

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void ActionsDragAndDrop()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);
            actions.DragAndDrop(driver.FindElement(By.Id("draggable")), driver.FindElement(By.Id("droppable")))
                .Build()
                .Perform();

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void ActionsDragAndDropToOffset()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);
            actions.DragAndDropToOffset(driver.FindElement(By.Id("draggable")), 150, 50)
                .Build()
                .Perform();

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void ActionsKeyDownAndKeyUp()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";

            Actions actions = new Actions(driver);
            actions.KeyDown(Keys.Control)
                .Click(driver.FindElement(By.Name("one")))
                .Click(driver.FindElement(By.Name("twelve")))
                .KeyUp(Keys.Control)
                .Click(driver.FindElement(By.Name("seven")))
                .Build()
                .Perform();

            actions.KeyDown(driver.FindElement(By.Name("one")), Keys.Control)
                .KeyDown(driver.FindElement(By.Name("twelve")), Keys.Control)
                .KeyUp(Keys.Control)
                .KeyDown(driver.FindElement(By.Name("seven")), Keys.Control)
                .KeyUp(Keys.Control)
                .Build()
                .Perform();

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void ActionsFillFormsUsingSendKeys()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com/Account/Register";

            Actions actions = new Actions(driver);
            actions.Click(driver.FindElement(By.Id("Email")))
                .SendKeys("email@email.dom")
                .Click(driver.FindElement(By.Id("Password")))
                .SendKeys("Pass123!")
                .Click(driver.FindElement(By.Id("ConfirmPassword")))
                .SendKeys("Pass123!")
                .Click(driver.FindElement(By.XPath("//input[@value='Register']")))
                .Build()
                .Perform();

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void ActionsClearTextBox()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com/Account/Register";

            Actions actions = new Actions(driver);
            actions.Click(driver.FindElement(By.Id("Email")))
                .SendKeys("Text to be cleared")
                .Build()
                .Perform();
           
            actions.Click(driver.FindElement(By.Id("Email")))
                .KeyDown(Keys.Control)
                .SendKeys("a")
                .KeyUp(Keys.Control)
                .SendKeys(Keys.Backspace)
                .Build()
                .Perform();

            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
