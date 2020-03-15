using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            List<Customer> customers = new List<Customer>();
            var customer1 = new Customer("Jonna", "Watson", "Strynnevej", "3000", "Hells Kitchen");
            customer1.AddPhone("123456789");
            customer1.BirthDate = new DateTime(1977, 2, 8);
            var customer2 = new Customer("Don", "Madson", "Brugevej", "5000", "WA");
            customer2.AddPhone("911911911");
            customer1.BirthDate = new DateTime(1945,6,5);
            var customer3 = new Customer("Pon", "Badson", "Trugevej", "666", "AAR");
            customer3.AddPhone("420420420");
            customer1.BirthDate = new DateTime(1917, 4, 3);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            ViewBag.Customers = customers;
            

            return View();
        }
    }
}