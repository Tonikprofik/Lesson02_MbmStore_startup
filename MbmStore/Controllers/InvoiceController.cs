using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Infrastructure;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        //GET Invoice
        public IActionResult Index()
        {
            //list
            List<SelectListItem> customers = new List<SelectListItem>();
            //Dropdown List
            foreach (Invoice item in Repository.Invoices)
            {
                customers.Add(new SelectListItem
                {
                    Text = item.Customer.FirstName + " " + item.Customer.LastName,
                    Value = item.Customer.CustomerId.ToString()
                });
            }
            
            //Removes duplicate entries with same ID from a IEnumerable
            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();

            
            ViewData["Customers"] = customers;
            ViewData["Invoices"] = Repository.Invoices;

            return View();
        }

        [HttpPost]
        public IActionResult Index(int? customer)
        {
            List<Invoice> invoices;

            if (customer != null)
            {//select invoices for a customer with linq
                invoices = Repository.Invoices.Where(r =>
                r.Customer.CustomerId == customer).ToList();
            }
            else
            {
                invoices = Repository.Invoices;
            }
            //declare list
            List<SelectListItem> customers = new List<SelectListItem>();
           
            //dropdown list
            foreach (Invoice item in Repository.Invoices)
            {
                if (item.Customer.CustomerId == customer)
                {
                    customers.Add(new SelectListItem
                    {
                        Text = item.Customer.FirstName + " " + item.Customer.LastName,
                        Value = item.Customer.CustomerId.ToString(),
                        Selected = true
                    });
                }
                else
                {
                    customers.Add(new SelectListItem
                    {
                        Text = item.Customer.FirstName + " " + item.Customer.LastName,
                        Value = item.Customer.CustomerId.ToString()
                    });
                }
            }

            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();
            ViewData["Customers"] = customers;
            ViewData["Invoices"] = invoices;
            return View();

        }
    }
}