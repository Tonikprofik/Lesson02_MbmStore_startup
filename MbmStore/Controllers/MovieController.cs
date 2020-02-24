using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {

            // create a new Movie object with instance name jungleBook
            var jungleBook = new Movie("Jungle Book", 160.50m, "junglebook.jpg","Zac Snyder");
            var littleWoman = new Movie("Little Woman", 120m, "lilwmn.jpg","James Cameron");
            var harryPotter = new Movie("Harry Potter", 190m, "hrptr.jpg","Christopher Nolan");
            
            // assign a ViewBag property to the new Movie object
            ViewBag.JungleBook = jungleBook;
            ViewBag.LittleWoman = littleWoman;
            ViewBag.HarryPotter = harryPotter;

            // return the default view
            return View();
        }
    }
}