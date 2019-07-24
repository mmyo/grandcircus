using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assessment5b.Models;
using Microsoft.AspNetCore.Http;

namespace Assessment5b.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISession _session;

        //private int _quantity = 0;

        public HomeController(IHttpContextAccessor httpContextAccessor)
        {
            _session = httpContextAccessor.HttpContext.Session;
            //_session.SetInt32("quantity", 100);
        }
         
        public IActionResult Index()
        {
            //_session.SetInt32("quantity", 0);
            return View();
        }

        public IActionResult Item()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult AddItem()
        {

            if (_session.GetInt32("quantity") is null)
            {
                _session.SetInt32("quantity", 1);
            }
            else
            {
                _session.SetInt32("quantity", (int)_session.GetInt32("quantity") + 1 );
            }

            return RedirectToAction("Item", "Home");
        }

        public IActionResult DeleteItem()
        {


            if (_session.GetInt32("quantity") is null || (int)_session.GetInt32("quantity") == 0)
            {
                return RedirectToAction("Item", "Home");
            }
            else
            {
                _session.SetInt32("quantity", (int)_session.GetInt32("quantity") - 1);
            }

            return RedirectToAction("Item", "Home");
        }

        public IActionResult EmptyCart()
        {
            _session.SetInt32("quantity", 0);

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult UpdateQuantity(int quantity)
        {
            _session.SetInt32("quantity", quantity);


            return RedirectToAction("Item", "Home");
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
    }
}
