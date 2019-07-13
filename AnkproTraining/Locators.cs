using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace AnkproTraining
{
    [TestClass]
    public class Locators
    {
        [TestMethod]
        public void LocateById()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com/Account/Login";

            driver.FindElement(By.Id("Email")).SendKeys("a@b.com");

            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void LocateByName()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com/Account/Login";

            driver.FindElement(By.Name("Email")).SendKeys("name@a.com");

            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void LocateByClass()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com";

            string str = driver.FindElement(By.ClassName("jumbotron")).Text;
            Console.WriteLine(str);
            Thread.Sleep(3000);

            driver.Quit();
        }

        [TestMethod]
        public void LocateByTagName()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com";

            var paragraph = driver.FindElements(By.TagName("p"));
            Console.WriteLine(paragraph.Count);
            foreach (var item in paragraph)
            {
                Console.WriteLine(item.Text);
            }

            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void LocateByLinkText()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com";

            driver.FindElement(By.LinkText("Register")).Click();

            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void LocateByPartialLinkText()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com";

            driver.FindElement(By.PartialLinkText("Reg")).Click();

            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void CSSSelector()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com/account/login";
            int count = driver.FindElements(By.CssSelector("*")).Count;
            Console.WriteLine("Number of elements found with above CSS selector " + count);

            driver.FindElement(By.CssSelector("#Email")).SendKeys("a@a.com");
            driver.FindElements(By.CssSelector(".form-control"))[1].SendKeys("123");
            driver.FindElement(By.CssSelector("input[value = 'Log in']")).Click();
            int countStart = driver.FindElements(By.CssSelector("a[href^='/Home']")).Count;
            driver.FindElement(By.CssSelector("a[href$='Training']")).Click();
            Console.WriteLine(countStart);
            driver.Navigate().Back();

            string footer = driver.FindElement(By.CssSelector("footer p")).Text;
            Console.WriteLine(footer);

            driver.Url = "http://ankpro.com";
            string h1 = driver.FindElement(By.CssSelector("h1+p")).Text;
            Console.WriteLine(h1);

            driver.Url = "http://ankpro.com/account/login";
            string form = driver.FindElement(By.CssSelector("form[role='form']")).Text;
            Console.WriteLine(form);

            driver.FindElement(By.Id("RememberMe")).Click();
            bool checkbox = driver.FindElement(By.CssSelector("input[type=checkbox]:checked")).Selected;
            Console.WriteLine(checkbox);

            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void XPathLocator()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com/Account/Login";
            string absolute = driver.FindElement(By.XPath("html/body/div[2]/footer/p")).Text;
            Console.WriteLine(absolute);

            int elementsCount = driver.FindElements(By.XPath(".//*")).Count;
            Console.WriteLine("elementsCount: " + elementsCount);

            int inputCount = driver.FindElements(By.XPath(".//input")).Count;
            Console.WriteLine("inputCount: " + inputCount);

            driver.FindElement(By.XPath(".//input[@id='Email']")).SendKeys("attribute");
            driver.FindElement(By.XPath(".//input[@id='Email'][@name='Email']")).SendKeys("multiple");
            driver.FindElement(By.XPath(".//input[@id='Email' and @name='Email']")).SendKeys("AND");
            driver.FindElement(By.XPath(".//input[@id='Email' or @name='FAKE']")).SendKeys("OR");

            driver.Url = "http://ankpro.com/Home/Training";
            string cellText = driver.FindElement(By.XPath(".//tr[2]/td[2]")).Text;
            Console.WriteLine("cellText: " + cellText);
            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void XPathLocatorFunctions()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com";
            string people = driver.FindElement(By.XPath("//*[text()='Our People']")).Text;
            Console.WriteLine(people);

            driver.Url = "http://ankpro.com/Account/Login";
            driver.FindElement(By.XPath("//input[starts-with(@id, 'Rem')]")).Click();
            driver.FindElement(By.XPath("//input[contains(@id, 'Me')]")).Click();
            driver.FindElement(By.XPath("//input[@type='checkbox' and not(@checked='checked')]")).Click();

            driver.Url = "http://ankpro.com/Home/Training";
            string bootstrap = driver.FindElement(By.XPath(".//tbody/tr[last()]/td[last()]")).Text;
            Console.WriteLine(bootstrap);

            string html = driver.FindElement(By.XPath(".//tbody/tr[last()-1]")).Text;
            Console.WriteLine(html);

            string position = driver.FindElement(By.XPath("(.//tbody/tr)[position()=2]")).Text;
            Console.WriteLine(position);

            driver.Url = "http://ankpro.com/Account/Register";
            driver.FindElement(By.XPath("(.//input[@type='password'])[position()=2]")).SendKeys("2nd position");

            driver.Quit();
        }

        [TestMethod]
        public void XPathAxes()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com";
            string h1 = driver.FindElement(By.XPath("//h1/parent::div")).Text;
            Console.WriteLine("h1: " + h1);

            string footer = driver.FindElement(By.XPath("//footer/child::p")).Text;
            Console.WriteLine("footer: " + footer);

            driver.Url = "http://ankpro.com/home/training";
            int trsibling = driver.FindElements(By.XPath("//tr[6]/following-sibling::tr")).Count;
            Console.WriteLine("trsibling: " + trsibling);

            int trfollow = driver.FindElements(By.XPath("//tr[6]/following::*")).Count;
            Console.WriteLine("trfollow: " + trfollow);

            int trprecedingsib = driver.FindElements(By.XPath("//tr[6]/preceding-sibling::tr")).Count;
            Console.WriteLine("trprecedingsib: " + trprecedingsib);

            int trpreceding = driver.FindElements(By.XPath("//tr[6]/preceding::*")).Count;
            Console.WriteLine("trpreceding: " + trpreceding);

            int tableancestor = driver.FindElements(By.XPath("//table/ancestor::div")).Count;
            Console.WriteLine("tableancestor: " + tableancestor);

            int tabledescendant = driver.FindElements(By.XPath("//table/descendant::td")).Count;
            Console.WriteLine("tabledescendant: " + tabledescendant);
        }

        [TestMethod]
        public void WebElements()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://ankpro.com/home/training";
            bool displayed = driver.FindElement(By.ClassName("img-responsive")).Displayed;
            Console.WriteLine("displayed: " + displayed);

            driver.Url = "http://ankpro.com/Account/Login";
            bool enabled = driver.FindElement(By.Id("Email")).Enabled;
            Console.WriteLine("enabled: " + enabled);

            Point location = driver.FindElement(By.Id("Email")).Location;
            Console.WriteLine("location: " + location);

            bool selected = driver.FindElement(By.Id("RememberMe")).Selected;
            Console.WriteLine("selected: " + selected);
            driver.FindElement(By.Id("RememberMe")).Click();
            selected = driver.FindElement(By.Id("RememberMe")).Selected;
            Console.WriteLine("selected: " + selected);

            Size size = driver.FindElement(By.Id("Email")).Size;
            Console.WriteLine("size: " + size);

            string tagname = driver.FindElement(By.Id("Email")).TagName;
            Console.WriteLine("tagname: " + tagname);

            driver.FindElement(By.Id("Email")).SendKeys("text@to.clear");
            Thread.Sleep(2000);
            string clear = driver.FindElement(By.Id("Email")).GetAttribute("value");
            Console.WriteLine("clear: " + clear);
            driver.FindElement(By.Id("Email")).Clear();
            clear = clear = driver.FindElement(By.Id("Email")).GetAttribute("value");
            Console.WriteLine("clear: " + clear);

            driver.Url = "http://ankpro.com";
            string text = driver.FindElement(By.XPath(".//h2")).Text;
            Console.WriteLine("text: " + text);

            int count = driver.FindElements(By.TagName("Input")).Count;
            Console.WriteLine("count: " + count);

            driver.Url = "http://ankpro.com/Home/Training";
            string src = driver.FindElement(By.TagName("img")).GetAttribute("src");
            Console.WriteLine("src: " + src);

            driver.FindElement(By.LinkText("Register")).Click();
            string color = driver.FindElement(By.Id("registerLink")).GetCssValue("color");
            Console.WriteLine("color: " + color);

            driver.FindElement(By.XPath(".//input[@type='submit']")).Click();

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void DifferencesBetweenFindElementAndFindElements()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.ankpro.com/Home/Training";

            ReadOnlyCollection<IWebElement> tags = driver.FindElements(By.TagName("h2"));
            Console.WriteLine("tags: " + tags.Count);
            foreach (var item in tags)
            {
                Console.WriteLine("tags: " + item.Text);
            }
            IWebElement tag = driver.FindElement(By.TagName("h2"));
            Console.WriteLine("tag: " + tag.Text);

            ReadOnlyCollection<IWebElement> trs = driver.FindElements(By.TagName("tr"));
            Console.WriteLine("trs: " + trs.Count);
            foreach (var item in trs)
            {
                Console.WriteLine("trs: " + item.Text);
            }
            IWebElement tr = driver.FindElement(By.TagName("tr"));
            Console.WriteLine("tr: " + tr.Text);

            ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.Id("sample"));
            Console.WriteLine("elements: " + elements.Count);
            IWebElement element = driver.FindElement(By.Id("sample"));
            Console.WriteLine("element: " + element);

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void CountCheckedAndUncheckedCheckboxes()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Form";

            driver.FindElement(By.XPath("//input[@value='dance']")).Click();
            driver.FindElement(By.XPath("//input[@value='read']")).Click();
            ReadOnlyCollection<IWebElement> webElements = driver.FindElements(By.XPath("//input[@type='checkbox']"));
            int checkedCount = 0;
            int uncheckedCount = 0;
            foreach (var element in webElements)
            {
                if (element.Selected == true)
                    checkedCount++;
                else
                    uncheckedCount++;
            }
            Console.WriteLine("Number of checked checkboxes are: " + checkedCount++);
            Console.WriteLine("Number of unchecked checkboxes are: " + uncheckedCount++);

            driver.Quit();
        }

        [TestMethod]
        public void NewLineAndTab()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Form";
            driver.FindElement(By.Id("comment")).SendKeys("Good \n morning \t testers!");

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void ElementWithinElement()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Form";

            string home = driver.FindElement(By.TagName("li")).FindElement(By.LinkText("Home")).Text;
            Console.WriteLine("home: " + home);

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void DropDownAndMultiselectDropDown()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Select";

            IWebElement elementDropDown = driver.FindElement(By.Id("countriesSingle"));
            Console.WriteLine("countriesSingle: " + elementDropDown.Text);
            SelectElement selectDropDown = new SelectElement(elementDropDown);
            IList<IWebElement> elementsDropDown = selectDropDown.Options;

            Console.WriteLine("elements.Count: " + elementsDropDown.Count);
            foreach (var item in elementsDropDown)
            {
                Console.WriteLine("elements.Text: " + item.Text);
            }
            bool isMultiple = selectDropDown.IsMultiple;
            Console.WriteLine("selectElement.IsMultiple: " + selectDropDown.IsMultiple);
            IWebElement selectedDropDown = selectDropDown.SelectedOption;
            Console.WriteLine("selectedDropDown: " + selectedDropDown.Text);

            IWebElement elementMulti = driver.FindElement(By.Id("countriesMultiple"));
            Console.WriteLine("\ncountriesMultiple: " + elementMulti.Text);
            SelectElement selectMulti = new SelectElement(elementMulti);
            IList<IWebElement> elementsMulti = selectMulti.Options;

            Console.WriteLine("elements.Count: " + elementsMulti.Count);
            foreach (var item in elementsMulti)
            {
                Console.WriteLine("elements.Text: " + item.Text);
            }
            isMultiple = selectMulti.IsMultiple;
            Console.WriteLine("selectElement.IsMultiple: " + selectMulti.IsMultiple);

            selectMulti.SelectByText("England");
            selectMulti.DeselectByText("England");
            selectMulti.SelectByIndex(0);
            //selectMulti.DeselectByIndex(2);
            selectMulti.SelectByValue("usa");
            selectMulti.DeselectByValue("usa");
            selectMulti.SelectByText("China");

            IWebElement selectedMulti = selectMulti.SelectedOption;
            Console.WriteLine("selectedMulti: " + selectedMulti.Text);

            IList<IWebElement> elementsSelected = selectMulti.AllSelectedOptions;
            Console.WriteLine("elementsSelected - count: " + elementsSelected.Count);
            foreach(var item in elementsSelected)
            {
                Console.WriteLine("elementsSelected: " + item.Text);
            }

            selectMulti.DeselectAll();
            Console.WriteLine("elementsSelected - count: " + elementsSelected.Count);
            foreach (var item in elementsSelected)
            {
                Console.WriteLine("elementsSelected: " + item.Text);
            }

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void HTMLDropdownAndBootStrapDropdown()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Select";

            driver.FindElement(By.Id("dropdownMenu1")).Click();
            driver.FindElement(By.XPath("//a[text()='England']")).Click();

            string buttonText = driver.FindElement(By.Id("dropdownMenu1")).Text;
            Console.WriteLine("buttonText: " + buttonText);

            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
