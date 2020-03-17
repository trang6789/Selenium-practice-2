using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPractice2.Property.Method
{
    class DragAndDropMethod
    {
        IWebDriver driver;

        public void checkDragAndDrop()
        {
            Actions act = new Actions(driver);
        }

    }
}
