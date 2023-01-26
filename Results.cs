using NUnit.Framework.Interfaces;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.DevTools.V107.Debugger;

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
            string xpath = "//div[@class='a-section a-spacing-small a-spacing-top-small'";
            List<Item> items = new List<Item>();

            foreach (var filter in filters)
            {
                switch (filter.Key)
                {
                    case "Price_Lower_Then":
                        xpath += "and descendant::span[@class = 'a-price-whole' and text() < " + filter.Value + "]";
                        break;
                    case "Price_Hiegher_OR_Equal_Then":
                        xpath += "and descendant::span[@class = 'a-price-whole' and text() >= " + filter.Value + "]";
                        break;
                    case "Free_Shipping":
                        if(filter.Value == "true")
                            xpath += "and descendant::span[contains(text(), 'FREE')]";
                        break;
                }
            }
            xpath += "]";
            var elements = driver.FindElements(By.XPath(xpath));

            if (elements != null)
                foreach (var el in elements)
                {
                    var title = el.FindElement(By.XPath(".//span[@class='a-size-medium a-color-base a-text-normal']")).Text;
                    var price = el.FindElement(By.XPath(".//span[@class='a-price-whole']")).Text + "." + el.FindElement(By.XPath("//span[@class='a-price-fraction']")).Text + "$";
                    var url = el.FindElement(By.XPath((".//a[@class='a-link-normal s-underline-text s-underline-link-text s-link-style a-text-normal']"))).GetAttribute("href");
                    items.Add(new Item(title, price, url));
                }
            Console.WriteLine("Size Elements: " + elements.Count());

            foreach (var item in items)
            {
                Console.WriteLine("---------------");
                Console.WriteLine(item.Titel);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.Url);
            }
        }
    }
}
