using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bookss.Models;
using Bookss.Bl;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Domains;
using Microsoft.AspNetCore.Authorization;

namespace Bookss.Controllers
{
    [Authorize]
    public class ItemsController : Controller
    {
        IItemService ItemService; 
        public ItemsController(IItemService itemService)
        {
            ItemService = itemService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ItemList()
        {
            return View();
        }
        /// <summary>
        /// deails with all the deatils of the item itself
        /// and it shows below the related and also the upsellerr items.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Details(int id)
        {
            ItemDetailModel model = new ItemDetailModel();
            model.Item = ItemService.GetByIdWithImages(id);
            model.ListRelatedItems = ItemService.GetRelatedItems(model.Item.SalesPrice);
            model.ListUpSellerItems = ItemService.GetUpSellItems();
            return View(model);
        }
        /// <summary>
        /// Add to cart while the session holds the info about the user and keeps the 
        /// items in the card until he logs out.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult AddToCart(int id)
        {
            ShoppingCart oShopingCart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("Cart");
            if (oShopingCart == null)
                oShopingCart = new ShoppingCart();
            TbItem item = ItemService.GetById(id);
            ShoppingCartItem shoppingItem = oShopingCart.ListItems.Where(a=>a.ItemId==id).FirstOrDefault();
            if(shoppingItem != null)
            {
                shoppingItem.Qty++;
                shoppingItem.Total = shoppingItem.Price * shoppingItem.Qty;
            }
            else
            {
                oShopingCart.ListItems.Add(new ShoppingCartItem()
                {
                    ItemId = item.ItemId,
                    ItemName = item.ItemName,
                    ImageName = item.ImageName,
                    Price = item.SalesPrice,
                    Qty = 1,
                    Total = item.SalesPrice
                });
            }
           
            oShopingCart.Total = oShopingCart.ListItems.Sum(a => a.Total);
            HttpContext.Session.SetObjectAsJson("Cart", oShopingCart);
            return Redirect("/Home/Index");
        }
    }
}
