using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPractice2.Property.Method
{
    class DropdownListMethod
    {
        //instantiate an object of SelectElement class
        //select value of oject equal Sunday
        public static void checkDropDownList(IWebElement list)
        {           
            var selectTest = new SelectElement(list);
            selectTest.SelectByValue("Sunday");
        }
    }
}
