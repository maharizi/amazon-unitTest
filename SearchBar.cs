using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace amazonEx1
{
    internal class SearchBar
    {
        private IWebDriver driver;

        public SearchBar(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string Text
        {
            set
            {
                this.driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys(value);
            }
        }

        public void Click()
        {
            this.driver.FindElement(By.Id("nav-search-submit-button")).Click();
        }
    }
}
