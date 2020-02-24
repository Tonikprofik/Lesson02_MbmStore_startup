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
            customers.ad
            var customer2 = new Customer("Don", "Madson", "Brugevej", "5000", "WA");
            var customer3 = new Customer("Pon", "Badson", "Trugevej", "666", "AAR");

            customers.Add(customer1);
            customers.Add(customer2);

            ViewBag.Customers = customers;
            
            return View();
        }
    }
}