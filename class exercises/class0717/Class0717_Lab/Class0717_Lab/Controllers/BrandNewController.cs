using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Class0717_Lab.Controllers
{
    

    public class BrandNewController : Controller
    {

        private readonly ISession _session;

        public BrandNewController(IHttpContextAccessor httpContextAccessor) 
        {
            _session = httpContextAccessor.HttpContext.Session;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Set()
        {
            ViewData["DateTimeNowViewData"] = DateTime.Now;

            TempData["DateTimeNowTempData"] = DateTime.Now;

            _session.SetString("DateTimeNowSession", DateTime.Now.ToString());

            return RedirectToAction("Get", "BrandNew");
        }

        public IActionResult Get()
        {
            return View();
        }
    }
}