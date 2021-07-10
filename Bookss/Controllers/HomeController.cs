using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookss.Models;
using Domains;
using Bookss.Bl;


namespace Bookss.Controllers
{
    public class HomeController : Controller
    {
        IItemService itemService;
        public HomeController(IItemService item)
        {
            itemService = item;
        }
        /// <summary>
        /// to bring all of lists in the homepage for the client 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            HomePageModel model = new HomePageModel();
            model.lstAllItems = itemService.GetAll();
            model.lstNewItems = model.lstAllItems.Take(5);
            model.lstBestSellers = model.lstAllItems.Take(3);
            model.lstCategories = model.lstAllItems.GroupBy(a => a.CategoryId).Select(a => a.First()).ToList();
            return View(model);
        }
    }
}
