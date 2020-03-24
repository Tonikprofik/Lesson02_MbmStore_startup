using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Infrastructure
{
    public static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();
        static Repository()
        {
            var mov1 = new Movie(100,"Jungle Book", 160.50m, "Zac Snyder");
            mov1.ImageUrl = "junglebook.jpg";
            var mov2 = new Movie(101,"Little Woman", 120m, "James Cameron");
            mov2.ImageUrl = "lilwmn.jpg";
            var mov3 = new Movie(102,"Harry Potter", 190m, "Christopher Nolan");
            mov3.ImageUrl = "hrptr.jpg";

            Products.Add(mov1);
            Products.Add(mov2);
            Products.Add(mov3);
            // assign a ViewBag property to the new Movie object
            //instantiated subclasses - objects created
            // var book = new Book("Aldous Huxley", "Brave New World"
            //            ,90.5m,22/3/2010); //might be mm/dd/yyyy

            //books.Add(new Book("Aldous Huxley", "Brave New World", 90.5m, 22 / 3 / 2010));
            var book1 = new Book(200,"Ray Bradbury", "Fahrenheit 451"
                        , 190.5m, 1984 );
                book1.Publisher = "Rybka Publishers";
            book1.ImageUrl = "fahren.jfif";
                book1.ISBN = "0112911666";
            var book2 = new Book(201,"Michael Pollan", "How to Change The New Science"
                        , 190.5m, 1950);
                book2.Publisher = "Rybka Publishers";
            book2.ImageUrl = "lsd.jfif";
            book2.ISBN = "01244557889";
            var book3 = new Book(202,"James Clear", "Atomic Habits"
                        , 190.5m, 1984);
                book3.Publisher = "Donuta Pubs";
                book3.ImageUrl = "atmc.jpg";
                book3.ISBN = "1555789666";
            Products.Add(book1);
            Products.Add(book2);
            Products.Add(book3);

            var cd1 = new MusicCD(300,"The Growlers", "Casual Aquaintances"
                    , 3.50m, "Warner bros", 2016 );
            cd1.ImageUrl = "grwlrs.jfif";
            cd1.AddTrack(new Track("Good Advice", new TimeSpan(0, 3, 50)));
            cd1.AddTrack(new Track("Dull Boy", new TimeSpan(0, 3, 50)));
            cd1.AddTrack(new Track("Dope on Rope", new TimeSpan(0, 3, 50)));
            
            var cd2 = new MusicCD(301,"Pink Floyd", "Wish You Were Here"
                    , 50m, "Warner bros", 1985);
            cd2.ImageUrl = "pnkfld.jfif";
            cd2.AddTrack(new Track("Shine On You Crazy Diamond"
                , new TimeSpan(0, 3, 50)));
            cd2.AddTrack(new Track("Wish You Were Here", new TimeSpan(0, 3, 50)));

            var cd3 = new MusicCD(302,"Allah-Las", "Allah-Las"
                    , 5.50m, "Warner bros", 2012);
            cd3.ImageUrl = "allah.jfif";
            cd3.AddTrack(new Track("Catamaran", new TimeSpan(0, 4, 50)));
            cd3.AddTrack(new Track("Sandy", new TimeSpan(0, 5, 25)));
            cd3.AddTrack(new Track("No Voodoo", new TimeSpan(0, 3, 50)));

            Products.Add(cd1);
            Products.Add(cd2);
            Products.Add(cd3);
            //customers
            var c1 = new Customer("Juan", "Don", "Sonderhoj", "666", "Aarhus");
            var c2 = new Customer("Tuan", "Pon", "Byghoj", "666", "Aarhus");
            var c3 = new Customer("Dan", "Con", "Derhoj", "666", "Aarhus");
            c1.AddPhone("91100");
            c1.CustomerId = 1;
            c2.CustomerId = 2;
            //orders
            var ori1 = new OrderItem(book1, 2);
            var ori2 = new OrderItem(cd1, 3);
            var ori3 = new OrderItem(mov2, 1);
            var ori4 = new OrderItem(book2, 3);
            //Invoices
            var inv1 = new Invoice(1, new DateTime(2020, 01, 20),c1);
            inv1.AddOrderItem(ori1.Product, ori1.Quantity);
            inv1.AddOrderItem(ori3.Product, ori3.Quantity);
            c1.AddInvoice(inv1);

            var inv2 = new Invoice(2, new DateTime(2019, 02, 21), c2);
            inv2.AddOrderItem(ori2.Product, ori2.Quantity);
            inv2.AddOrderItem(ori4.Product, ori4.Quantity);
            c2.AddInvoice(inv2);

            Invoices.Add(inv1);
            Invoices.Add(inv2);
            
        }
    }
}
