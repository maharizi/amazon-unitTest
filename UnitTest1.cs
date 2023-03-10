using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Cryptography.X509Certificates;

namespace amazonEx1
{
    public class Tests
    {
        public IWebDriver driver;
        BrowsersFactory browsers;
        Amazon amazon;
        Dictionary<string, string> dictFilter = new Dictionary<string, string>();

        [SetUp]
        public void Setup()
        {
            //browsers = new EdgeBrowser();
            browsers = new ChromeBrowser();
            driver = browsers.InitBrowser();
            amazon = new Amazon(driver);
            //Assert.That(typeof(browsers), Is.Not.Null.And.EqualTo());
            dictFilter.Add("Price_Lower_Then", "1000");
            dictFilter.Add("Price_Hiegher_OR_Equal_Then", "0");
            //dictFilter.Add("Free_Shipping", "true");
        }

        [Test]
        public void Test1()//Facade design pattern
        {
            try
            {
                amazon.Pages.Home.SearchBar.Text = "mouse";
                amazon.Pages.Home.SearchBar.Click();
                amazon.Pages.Search.Results.getResultBy(dictFilter);
                Assert.Pass();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}