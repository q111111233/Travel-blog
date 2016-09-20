using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelBlog.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TravelBlog.Controllers
{
    public class DestinationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
