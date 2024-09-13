using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){
            int saat = DateTime.Now.Hour;
            // ViewBag.Selamlama = saat > 12 ? "Iyi gunler" : "Gunaydin";
            // ViewBag.UserName = "Kaan";

            ViewData["Selamlama"] = saat > 12 ? "Iyi gunler" : "Gunaydin";
            ViewData["UserName"] = "Kaan";

            return View();
        }
    }
}