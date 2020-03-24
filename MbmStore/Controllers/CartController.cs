using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using MbmStore.Models;
using MbmStore.Infrastructure;
using MbmStore.Models.ViewModels;
using Newtonsoft.Json;

namespace MbmStore.Controllers
{
    public class CartController : Controller
    {
        private Cart cart;
        public CartController(Cart cartService)
        {
            cart = cartService;
        }
        public RedirectToActionResult AddToCart(int productID, string returnUrl)
        {
            Product product = Repository.Products.FirstOrDefault(p => p.ProductID == productID);
            if (product!= null)
            {
                cart.AddItem(product, 1);
            }
            return RedirectToAction("Index",new { returnUrl});
        }
        public RedirectToActionResult RemovefromCart(int productID, string returnUrl)
        {
            Product product = Repository.Products.FirstOrDefault(p => p.ProductID == productID);
            if (product != null)
            {
               cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        //private Cart GetCart()
        //{
        //    Cart cart = HttpContext.Session.GetJson<Cart>("Cart");
        //    if (cart == null)
        //    {
        //        cart = new Cart();
        //        HttpContext.Session.SetJson("Cart", cart);
        //    }
        //    return cart;
        //}
        //private void SaveCart(Cart cart)
        //{
        //    HttpContext.Session.SetJson("Cart", cart);
        //}
        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }
    }
}