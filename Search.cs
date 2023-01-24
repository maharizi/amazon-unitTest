using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amazonEx1
{
    internal class Search
    {
        private IWebDriver driver;
        public Results results;

        public Search(IWebDriver driver) 
        {
            this.driver = driver;
        }

        public Results Results
        {
            get
            {
                if (this.results == null)
                    this.results = new Results(this.driver);
                return this.results;
            }
        }
    }
}
