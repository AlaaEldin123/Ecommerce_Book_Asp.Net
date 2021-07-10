using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookss.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookss.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cart()
        {
            ShoppingCart oShopingCart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("Cart");
            return View(oShopingCart);
        }
        public IActionResult REmoveItem(int id)
        {
            ShoppingCart ShopingCart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("Cart");
            ShopingCart.ListItems.Remove(ShopingCart.ListItems.Where(a => a.ItemId == id).FirstOrDefault());
            ShopingCart.Total = ShopingCart.ListItems.Sum(a => a.Total);
            HttpContext.Session.SetObjectAsJson("Cart", ShopingCart);
            return RedirectToAction("Cart");
        }
    }
}
