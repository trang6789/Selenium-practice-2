using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumPractice2.Property.Locator;

namespace SeleniumPractice2.Property.Method
{
    class CheckboxMethod
    {
        public static void checkboxClick( IWebElement checkbox)
        {
            //click on element
            checkbox.Click();
        }
                      
    }
}
