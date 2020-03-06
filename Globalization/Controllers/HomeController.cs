using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Globalization.Models;
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace Globalization.Controllers
{
    public class HomeController : Controller
    {
      
        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;

        public HomeController(IStringLocalizer<SharedResource> sharedLocalizer)
        {
            _sharedLocalizer = sharedLocalizer;

        }


        public IActionResult Index()
        {
               return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
      
        [HttpPost]
        public IActionResult Login(UserModel user)
        {

            if (user.UserName != null || user.Password != null)
            {
                if (user.UserName == "hanifi" && user.Password == "123")
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Veri = "Hata";
                    TempData["Veri"] = "";
                }

            }
            else
            {
                ViewBag.Veri = "Hata";

            }


            return View();
        }

        public IActionResult Login()
        {
            
            return View();
        }

       

        public IActionResult Contact()
        {
          
            return View();

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
