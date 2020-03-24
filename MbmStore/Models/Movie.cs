using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
        // fields
        private decimal price;
        private string imageFileName;

        // properties
        //public string Title { get; }
        public string Director { get; set; }
        public short Released { get; set; }

        //public string ImageFileName {get; set;}

        //public decimal Price
        //{
        //    set
        //    {
        //        if (value <= 0)
        //        {
        //            throw new Exception("Price is not accepted");
        //        }
        //        else
        //        {
        //            price = value;
        //        }
        //    }
        //    get { return price; }
        //}


        // constructors
        public Movie() { }

        public Movie(string title, decimal price)
        {
            Title = title;
            Price = price;
        }
        public Movie(int productID,string title, decimal price//, string imageurl
            ,string director) : base(productID,title, price)
        {
            ProductID = productID;
            Title = title;
            Price = price;
           // ImageFileName = imageurl;
            Director = director;
        }

        
    }
}