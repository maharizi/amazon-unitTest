using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amazonEx1
{
    internal class SearchBar
    {
        public void TextSearch(string text, IWebDriver driver)
        {
            var set = driver.FindElement(By.Id("twotabsearchtextbox"));
            set.SendKeys(text);
        }

        public void ClickSearch(IWebDriver driver)
        {
            var click = driver.FindElement(By.Id("nav-search-submit-button"));
            click.Click();
        }
    }
}
