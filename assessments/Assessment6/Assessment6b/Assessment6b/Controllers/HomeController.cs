using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assessment6b.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment6b.Controllers
{
    public class HomeController : Controller
    {
        private readonly JellyBeanContext _context;

        public HomeController(JellyBeanContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
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

        public async Task<IActionResult> JellyBean()
        {
            return View(await _context.JellyBeans.ToListAsync());
        }

        [HttpPost]
        public IActionResult JellyBean(string style, string rating)
        {

            try
            {
                var jellyBean = new JellyBean() { Style = style, Rating = Int32.Parse(rating) };
                return RedirectToAction("CreateJellyBean", jellyBean);
            }
            catch (Exception)
            {

                return RedirectToAction("JellyBean");

            }

        }


        public async Task<IActionResult> CreateJellyBean([Bind("JellyBeanId,Style,Rating")] JellyBean jellyBean)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jellyBean);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("JellyBean");
        }
    }
}
