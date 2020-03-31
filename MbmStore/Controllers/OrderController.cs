using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Models.ViewModels;

namespace MbmStore.Controllers
{
    public class OrderController : Controller
    {
        private Cart cart;


        //might not have to be here yet
        public OrderController(Cart cartService)
        {
            cart = cartService;
        }
        public ViewResult Checkout()
        {
            return View(new Order());
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (cart.Lines.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, fill it up!");
            }
            if (ModelState.IsValid)
            {
                //orderprocceslogic
                cart.Clear();
                    return View("Completed");
            }
            else
            {
                return View(order);
            }
        }
    }
}