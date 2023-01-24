using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amazonEx1
{
    internal class Item
    {
        private string url;
        private string titel;
        private string price;

        public string Url
        {
            set
            {
                this.url = value;
            }
            get
            {
                return this.url;
            }
        }
        public string Titel 
        {
            set
            {
                this.titel = value;
            }
            get
            {
                return this.titel;
            }
        }

        public string Price
        {
            set
            {
                this.price = value;
            }
            get
            {
                return this.price;
            }
        }
    }
}
