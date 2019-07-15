using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Models;
using CoffeeShop.Data;

namespace CoffeeShop.Controllers
{
    public class UserController : Controller
    {

        private static UserDataRepository _userDataRepository = new UserDataRepository();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserModel user)
        {
            _userDataRepository.Add(user);

            return RedirectToAction("ViewAll", "User");
            //return View();
        }

        public IActionResult Edit(string userId)
        {
            return View();
        }

        public IActionResult ViewAll()
        {
            return View(_userDataRepository);
        }

    }
}