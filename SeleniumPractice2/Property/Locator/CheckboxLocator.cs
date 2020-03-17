using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPractice2.Property.Locator
{
    //declare locator of base link
    //declare locator of checkbox
    class CheckboxLocator
    {
        public const string baselink = "http://demo.guru99.com/test/radio.html";
        public const string checkboxlink = "//*[@id= 'includedContent']//following::input[@value='checkbox1']";
    }
}
