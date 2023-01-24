using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amazonEx1
{
    internal class Pages
    {
        private IWebDriver driver;
        private Home home;
        private Search search;
        public Pages(IWebDriver driver)//POM design pattern
        {
            this.driver = driver;
        }
        public Home Home
        {
            get 
            {
                if (this.home == null)
                    this.home = new Home(this.driver);
                return this.home;
            }
        }
        public Search Search
        {
            get
            {
                if (this.search == null)
                    this.search = new Search(this.driver);
                return this.search;
            }
        }
    }
}
