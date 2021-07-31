using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Ecommerceshoppingcart.Helpers;
using Ecommerce.Models;

namespace Ecommerceshoppingcart.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Product.Price * item.Quantity);
            return View();
        }
    }
}
