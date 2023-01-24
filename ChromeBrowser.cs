using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amazonEx1
{
    internal class ChromeBrowser : BrowsersFactory
    {
        public IWebDriver driver = null;
        public IWebDriver InitBrowser()
        {
            if (driver == null)//SingleTon design pattern
            {
                driver = new ChromeDriver("C:\\bootcamp ness\\drivers");
                driver.Url = "https://www.amazon.com/";
            }
            return driver;
        }
    }
}
