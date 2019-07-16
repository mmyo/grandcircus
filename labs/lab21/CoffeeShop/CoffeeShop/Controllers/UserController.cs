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

        //private static UserDataRepository _userDataRepository = new UserDataRepository();

        private readonly IUserDataRepository _userDataRepository;

        public UserController(IUserDataRepository userDataRepository)
        {
             _userDataRepository = userDataRepository;
        }

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

            return RedirectToAction("ViewAll", "User", user);
            //return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult ViewAll(UserModel user)
        {
            //var user = _userDataRepository.Get(id);
            return View(user);
        }

    }
}