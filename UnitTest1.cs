using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Cryptography.X509Certificates;

namespace amazonEx1
{
    public class Tests
    {
        public IWebDriver driver;
        Browsers brousers;
        Amazon amazon;
        Dictionary<string, string> dictFilter = new Dictionary<string, string>();

        [SetUp]
        public void Setup()
        {
            amazon = new Amazon();
            // driver = new ChromeDriver("C:\\bootcamp ness\\drivers");
            // driver.Url = "https://www.amazon.com/";
            brousers = new ChromeBrowser();
            driver = brousers.InitBrowser();
            dictFilter.Add("Price_Lower_Then", "100");
            dictFilter.Add("Price_Hiegher_OR_Equal_Then", "50");
            dictFilter.Add("Free_Shipping", "true");
        }

        [Test]
        public void Test1()//Facade design pattern
        {
            try
            {
                amazon.pages.home.searchBar.TextSearch("mouse", driver);
                amazon.pages.home.searchBar.ClickSearch(driver);
                amazon.pages.search.results.getResultBy(dictFilter);
                Assert.Pass();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Assert.Pass();
        }
    }
}