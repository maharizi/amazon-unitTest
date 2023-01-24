using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace amazonEx1
{
    internal class Amazon
    {
        private IWebDriver driver;
        private Pages pages;

        public Amazon(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Pages Pages
        {
            get
            {
                if (this.pages == null)
                    this.pages = new Pages(this.driver);
                return this.pages;
            }
        }
    }
}
