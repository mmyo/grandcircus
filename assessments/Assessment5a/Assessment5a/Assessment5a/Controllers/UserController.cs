using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment5a.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assessment5a.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Welcome(User user)
        {
            if (user.Password == "open sesame")
            {
                ViewBag.Name = user.Name.ToUpper();
                ViewBag.Length = user.Name.Length;
                return View();

            }
            else
            {
                return RedirectToAction("WrongPassword", "User", user);
            }
        }

        public IActionResult WrongPassword(User user)
        {
            ViewBag.Name = user.Name;
            return View(); 
        }
    }
}