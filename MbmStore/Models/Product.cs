using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Product
    {
        //properties
        private string Title { get; set; }
        private decimal Price { get; set; }
        private string ImageUrl { get; set; }

        public Product()
        {

        }
        public Product(string title, decimal price)
        {

        }
    }
}
