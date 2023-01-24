using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amazonEx1
{
    internal interface BrowsersFactory //Factory design pattern
    {
        IWebDriver InitBrowser();
    }
}
