using Microsoft.Expression.Encoder.ScreenCapture;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnkproTraining
{
    [TestClass]
    public class Windows
    {
        [TestMethod]
        public void SimpleAlert()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.uitestpractice.com/Students/Switchto";

            driver.FindElement(By.Id("alert")).Click();
            string alertText = driver.SwitchTo().Alert().Text;
            Console.WriteLine("alertText: " + alertText);
            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void PromptAlert()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.uitestpractice.com/Students/Switchto";

            driver.FindElement(By.Id("prompt")).Click();
            driver.SwitchTo().Alert().Dismiss();
            driver.FindElement(By.Id("prompt")).Click();
            driver.SwitchTo().Alert().SendKeys("Sly");
            driver.SwitchTo().Alert().Accept();
            string promptOutput = driver.FindElement(By.Id("demo")).Text;
            Console.WriteLine("promptOutput: " + promptOutput);

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void ConfirmationAlert()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.uitestpractice.com/Students/Switchto";

            driver.FindElement(By.Id("confirm")).Click();
            string alertText = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Dismiss();
            string confirmationOutput = driver.FindElement(By.Id("demo")).Text;
            Console.WriteLine("alertText: " + alertText);
            Console.WriteLine("confirmationOutput: " + confirmationOutput);

            driver.FindElement(By.Id("confirm")).Click();
            alertText = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Accept();
            confirmationOutput = driver.FindElement(By.Id("demo")).Text;
            Console.WriteLine("alertText: " + alertText);
            Console.WriteLine("confirmationOutput: " + confirmationOutput);

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void Frame()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.uitestpractice.com/Students/Switchto";

            driver.SwitchTo().Frame("iframe_a");
            driver.FindElement(By.Id("name")).SendKeys("abc");
            driver.SwitchTo().DefaultContent();
            driver.FindElement(By.LinkText("uitestpractice.com")).Click();

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void MultipleWindows()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.uitestpractice.com/Students/Switchto";

            Console.WriteLine("Before click");
            Console.WriteLine("Number of windows opened by Selenium " + driver.WindowHandles.Count);
            foreach (var item in driver.WindowHandles)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Current window handle " + driver.CurrentWindowHandle);

            driver.FindElement(By.LinkText("Opens in a new window")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            Console.WriteLine("After click");
            Console.WriteLine("Number of windows opened by Selenium " + driver.WindowHandles.Count);
            foreach (var item in driver.WindowHandles)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Current window handle " + driver.CurrentWindowHandle);
            string currentUrl = driver.Url;
            Console.WriteLine("currentUrl " + currentUrl);

            driver.Close();
            Console.WriteLine("After close");
            Console.WriteLine("Number of windows opened by Selenium " + driver.WindowHandles.Count);
            foreach (var item in driver.WindowHandles)
            {
                Console.WriteLine(item);
            }
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Console.WriteLine("Current window handle " + driver.CurrentWindowHandle);
            currentUrl = driver.Url;
            Console.WriteLine("currentUrl " + currentUrl);

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void ModalWindow()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.uitestpractice.com/Students/Switchto";

            driver.FindElement(By.XPath("//button[contains(text(),'Launch modal')]")).Click();
            string modalTitle = driver.FindElement(By.ClassName("modal-title")).Text;
            Console.WriteLine("modal-title: " + modalTitle);
            driver.FindElement(By.XPath("//button[text()='Ok']")).Click();

            driver.FindElement(By.XPath("//button[contains(text(),'Launch modal')]")).Click();
            driver.FindElement(By.XPath("//button[text()='Close']")).Click();

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void ScreenShot()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.ankpro.com";

            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("screenshot.png", ScreenshotImageFormat.Png);

            ScreenShotOfElement(driver, driver.FindElement(By.ClassName("jumbotron")));

            Thread.Sleep(2000);
            driver.Quit();
        }

        public void ScreenShotOfElement(IWebDriver driver, IWebElement element)
        {
            string fileName = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".jpg";
            //Take screenshot & store it in byteArray
            Byte[] byteArray = ((ITakesScreenshot)driver).GetScreenshot().AsByteArray;
            //Create Bitmap Object(save image to Memory)
            Bitmap screenshot = new Bitmap(new System.IO.MemoryStream(byteArray));
            //Create Rectangle Object - to crop image to specific element
            Rectangle croppedImage = new Rectangle(element.Location.X, element.Location.Y, element.Size.Width, element.Size.Height);

            //Use Bitmap variable - capture screenshot & crop it
            screenshot = screenshot.Clone(croppedImage, screenshot.PixelFormat);
            screenshot.Save(String.Format(fileName, ImageFormat.Jpeg));
        }

        [TestMethod]
        public void ScreenShotOfElementUsingExtensionMethod()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com";
            driver.TakeScreenshot(driver.FindElement(By.ClassName("jumbotron")));

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void VideoRecording()
        {
            ScreenCaptureJob scj = new ScreenCaptureJob();
            scj.OutputScreenCaptureFileName = @"D:\SeleniumVideo.mov";
            scj.Start();

            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com";
            Thread.Sleep(2000);
            scj.Stop();

            driver.Quit();
        }
    }
    static class Utils
    {
        public static void TakeScreenshot(this IWebDriver driver, IWebElement element)
        {
            string fileName = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".jpg";
            //Take screenshot & store it in byteArray
            Byte[] byteArray = ((ITakesScreenshot)driver).GetScreenshot().AsByteArray;
            //Create Bitmap Object(save image to Memory)
            Bitmap screenshot = new Bitmap(new System.IO.MemoryStream(byteArray));
            //Create Rectangle Object - to crop image to specific element
            Rectangle croppedImage = new Rectangle(element.Location.X, element.Location.Y, element.Size.Width, element.Size.Height);

            //Use Bitmap variable - capture screenshot & crop it
            screenshot = screenshot.Clone(croppedImage, screenshot.PixelFormat);
            screenshot.Save(String.Format(fileName, ImageFormat.Jpeg));
        }
    }
}
