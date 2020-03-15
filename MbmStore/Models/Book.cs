using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Book : Product
    {
        //properties (might have to be public)

        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Published { get; set; }
        public string ISBN { get; set; }

        public Book()
        {

        }
        public Book(string author, string title
            ,decimal price, short published, string imageurl) 
            : base(title,price, imageurl)
        {
            Author = author;
            Published = published;
            
        }

    }
}
