using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amazonEx1
{
    internal class Results
    {
        private IWebDriver driver;

        public Results(IWebDriver driver) { 
            this.driver = driver;
        }

        public void getResultBy(Dictionary<string, string> filters)
        {
            string xpath = "//span[@class='a-price-whole'";
            foreach(var filter in filters)
            {
                switch (filter.Key)
                {
                    case "Price_Lower_Then":
                        xpath += "and descendant::span[@class = 'a-price-whole' and text() < " + filter.Value;
                        break;
                    case "Price_Hiegher_OR_Equal_Then":
                        xpath += "and text() >= " + filter.Value;
                        break;
                    case "Free_Shipping":
                        xpath += "and descendant::span[contains(text(), 'FREE'" + filter.Value;
                        break;
                }
            }
            xpath += "]]";
        }
    }
}
