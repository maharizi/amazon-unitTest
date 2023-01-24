using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amazonEx1
{
    internal class Home
    {
        private IWebDriver driver;
        public SearchBar searchBar;
        public Home(IWebDriver driver) 
        {
            this.driver = driver;
        }

        public SearchBar SearchBar
        {
            get
            {
                if (this.searchBar == null)
                    this.searchBar = new SearchBar(this.driver);
                return this.searchBar;
            }
        }
    }
}
