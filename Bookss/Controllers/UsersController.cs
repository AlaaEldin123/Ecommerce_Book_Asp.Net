using Bookss.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookss.Controllers
{
    public class UsersController : Controller
    {
        UserManager<ApplicationUser> userManager;
        SignInManager<ApplicationUser> signInManager;
        public UsersController(UserManager<ApplicationUser> manager, SignInManager<ApplicationUser> signManager)
        {
            userManager = manager;
            signInManager = signManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// when the user tries to access a denied page this action holds the URl to return
        /// it back to the user once he logs in.
        /// </summary>
        /// <param name="ReturnUrl"></param>
        /// <returns></returns>
        public IActionResult Login(string ReturnUrl)
        {
            return View(new UserModel() { 
                ReturnUrl = ReturnUrl
            });
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return Redirect("~/");
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserModel userModel)
        {
            var user = new ApplicationUser()
            {
                Email = userModel.Email,
                UserName = userModel.Email,
            };
            var result = await userManager.CreateAsync(user, userModel.Password);
            if(result.Succeeded)
            {
                return Redirect("~/");
            }
            else
            return View("Login",userModel);
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserModel userModel)
        {
            var result = await signInManager.PasswordSignInAsync(userModel.Email, userModel.Password, true, true);
            if (string.IsNullOrEmpty(userModel.ReturnUrl))
                userModel.ReturnUrl = "~/";
            if (result.Succeeded)
            {
                return Redirect(userModel.ReturnUrl);
            }
            else
                return View("Login", userModel);
        }

    }
}
