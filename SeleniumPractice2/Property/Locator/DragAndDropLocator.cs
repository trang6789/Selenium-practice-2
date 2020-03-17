using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPractice2.Property.Locator
{
    //declare locator of base link
    //declare locator of resouce
    //declare locator of target
    class DragAndDropLocator
    {
        public const string baselink = "http://demo.guru99.com/test/drag_drop.html";
        public const string from = "//*[@id='credit1']//descendant::a";
        public const string to = "//*[@id='loan']//descendant::li";
    }
}
