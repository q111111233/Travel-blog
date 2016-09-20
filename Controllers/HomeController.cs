using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelBlog.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TravelBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public HomeController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        //Register New User Using AJAX
        [HttpPost]
        public async Task<IActionResult> Register(string username, string password)
        {
            var newUser = new ApplicationUser { UserName = username };
            IdentityResult registeredUser = await _userManager.CreateAsync(newUser, password);
            if (registeredUser.Succeeded)
            {
                return Json(username);
            }
            else
            {
                return View();
            }
        }

        ////Login Using AJAX
        [HttpPost]
        public async Task<IActionResult> LogIn(string username, string password)
        {
            string[] loggedInUser = { username, password };
            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(username, password, isPersistent: true, lockoutOnFailure: false);
            if (signInResult.Succeeded)
            {
                return Json(loggedInUser);
            }
            else
            {
                return View();
            }
        }

        ////Log Out User
        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }
    }
}
