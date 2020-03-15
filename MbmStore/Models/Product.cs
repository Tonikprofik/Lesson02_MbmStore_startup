using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Product
    {
        //properties (might have to be public)
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public Product()
        {

        }
        public Product(string title, decimal price, string imageurl)
        {
            Title = title;
            Price = price;
            ImageUrl = imageurl;
        }
    }
}
