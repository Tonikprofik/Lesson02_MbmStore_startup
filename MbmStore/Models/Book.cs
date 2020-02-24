using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Book : Product
    {
        private string Author { get; set; }
        private string Publisher { get; set; }
        private short Published { get; set; }
        private string ISBN { get; set; }

        public Book()
        {

        }
        public Book(string author, string title
            ,decimal price, short published)
        {

        }

    }
}
