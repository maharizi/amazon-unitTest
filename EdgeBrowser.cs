using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;

namespace amazonEx1
{
    internal class EdgeBrowser : BrowsersFactory
    {
        public IWebDriver driver = null;
        public IWebDriver InitBrowser()
        {
            if (driver == null)//SingleTon design pattern
            {
                driver = new EdgeDriver("C:\\bootcamp ness\\drivers");
                driver.Url = "https://www.amazon.com/?language=en_US&currency=USD";
            }
            return driver;
        }
    }
}
