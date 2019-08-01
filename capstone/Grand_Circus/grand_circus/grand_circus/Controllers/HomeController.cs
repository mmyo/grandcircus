using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using grand_circus.Models;
using Microsoft.AspNetCore.Http;

namespace grand_circus.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISession _session;
        private readonly GrandCircusContext _context;


        public HomeController(GrandCircusContext context, IHttpContextAccessor httpContextAccessor)
        {
            _session = httpContextAccessor.HttpContext.Session;
            _context = context;
            
        }

        public IActionResult Index()
        {
            var users = _context.User;

            return View(users);


        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult SetUserSession(int id)
        {
            //var currentUser = _context.User.Find(id);

            _session.SetInt32("userId", id);

            return RedirectToAction("Index");
        }
    }
}
