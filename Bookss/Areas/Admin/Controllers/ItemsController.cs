using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookss.Models;
using Microsoft.AspNetCore.Mvc;
using Bookss.Bl;
using Microsoft.AspNetCore.Http;
using System.IO;
using Domains;
using Microsoft.AspNetCore.Authorization;

namespace Bookss.Areas.Admin.Controllers
{ 
    [Area("Admin")]
    // the authorize will define who has access to this controller and its methods. 
    // in our case and dependin gto our databse in sql it is the Admin. we can add also
    // more than one roles = "Admin", "DataEntry"...
    [Authorize (Roles =("Admin"))] 
    public class ItemsController : Controller
    {
        ICategoryService categoryServices;
        IItemService itemService;
        public ItemsController(IItemService service, ICategoryService categoryService)
        {
            itemService = service;
            categoryServices = categoryService;
        }
        //[AllowAnonymous] this one allows only this method to be displayed when the whole 
        //controller is authorized.
        public IActionResult List()
        {
            return View(itemService.GetAll());
        }
         
        public IActionResult Edit(int? id)
        {
            ViewBag.Categories = categoryServices.GetAll();
            if(id!=null)
            {
                return View(itemService.GetById(Convert.ToInt32(id)));
            }
            else
            return View();
        }
        public IActionResult Delete(int item)
        {
            itemService.Delete(item);
            return RedirectToAction("List");
        }
        [HttpPost]
        public async Task<IActionResult> Save(TbItem item, List<IFormFile> Files)
        {
            if (ModelState.IsValid)
            {
                foreach( var file in Files)
                {
                    if(file.Length>0)
                    {
                        string ImageName = Guid.NewGuid().ToString() + ".jpg";
                        var filepaths = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/Uploads", ImageName);
                        using (var stream = System.IO.File.Create(filepaths))
                        {
                            await file.CopyToAsync(stream);
                        }
                        item.ImageName = ImageName;
                    }
                }
               
                if (item.ItemId == 0)

                    itemService.Add(item);
                else
                    itemService.Edit(item);
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.Categories = categoryServices.GetAll();
                return View("Edit",item);
            } 
        }
    }
}
