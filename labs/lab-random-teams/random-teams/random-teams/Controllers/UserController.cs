using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using random_teams.Models;

namespace random_teams.Controllers
{
    public class UserController : Controller
    {
        private static readonly List<User> _userList = new List<User>();

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            if (ModelState.IsValid)
            {
                //_userList.Add(user);

                //var users = new List<User>();

                //users.Add(user);

                _userList.Add(user);

                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult ViewAllUsers()
        {
            ViewData["UserList"] = _userList;
            return View();
        }
    }
}