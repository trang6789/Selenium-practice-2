using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumPractice2.Property.Method;
using SeleniumPractice2.Property.Locator;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumPractice2.Test
{
    class TestResult
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\TNG77\\chromedriver_win32 (3)");
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }


        [Test]
        public void testCheckbox()
        {
            //Open browser
            //Maximize browser
            //Find locator of checkbox 1
            //Click on checkbox 1
            //Find locator of radio button 1
            //Click on radio button 1

            driver.Navigate().GoToUrl(CheckboxLocator.baselink);            
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement checkbox = driver.FindElement(By.XPath(CheckboxLocator.checkboxlink));            
            CheckboxMethod.checkboxClick(checkbox);
            Thread.Sleep(2000);            
            IWebElement radioButton = driver.FindElement(By.XPath(RadioButtonLocator.radiobuttonlink));            
            CheckboxMethod.checkboxClick(radioButton);
        }

        //[Test]
        //public void testRadioButton()
        //{
        //    //Open browser
        //    driver.Navigate().GoToUrl(RadioButtonLocator.baselink);
        //    //Maximize browser
        //    driver.Manage().Window.Maximize();
        //    Thread.Sleep(2000);
        //    //Find locator of radio button 1
        //    IWebElement radioButton = driver.FindElement(By.XPath(RadioButtonLocator.checkboxlink));
        //    //Click on radio button 1
        //    CheckboxMethod.checkboxClick(radioButton);

        //}

        [Test]
        public void testDragAndDrop()
        {
            //Open browser
            //Maximize browser
            //Find locator of Sales
            //Find locate to drag Sales
            //instantiate new objext of Action
            //Perform action drag and drop

            driver.Navigate().GoToUrl(DragAndDropLocator.baselink);            
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);            
            IWebElement from = driver.FindElement(By.XPath(DragAndDropLocator.from));            
            IWebElement to = driver.FindElement(By.XPath(DragAndDropLocator.to));            
            Actions act = new Actions(driver);            
            act.DragAndDrop(from, to).Build().Perform();
           
        }


        [Test]
        public void testDropdownList()
        {
            //Open browser
            //Maximize browser
            //Find locator of dropdown list
            //use method to check value is choosen
            //Find locator of value is displayed
            //Check value

            driver.Navigate().GoToUrl(DropdownListLocator.baselink);
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement list = driver.FindElement(By.XPath(DropdownListLocator.dropdownlistLink));
            DropdownListMethod.checkDropDownList(list);
            IWebElement display = driver.FindElement(By.XPath(DropdownListLocator.daySelected));
            Assert.AreEqual("Day selected :- Sunday", display.Text);          

            
        }
    }
}
