using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPractice2.Property.Locator
{
    //declare locator of base link
    //declare locator of dropdown list
    //declare locator of result place
    class DropdownListLocator
    {
        public const string baselink = "https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html";
        public const string dropdownlistLink = "//*[@id='select-demo']";
        public const string daySelected = "//*[@class='selected-value']";
    }
}
