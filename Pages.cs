using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amazonEx1
{
    internal class Pages
    {
        public Home home;
        public Search search;
        public Pages()//POM design pattern
        {
            home = new Home();
            search = new Search();
        }
    }
}
