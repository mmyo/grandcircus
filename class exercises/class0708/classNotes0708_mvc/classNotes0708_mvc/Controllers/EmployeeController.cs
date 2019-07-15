using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using classNotes0708_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace classNotes0708_mvc.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            //call database here

            var employee = new Employee
            {
                Id = 1,
                FirstName = "matt",
                LastName = "yo",
                Email = "matt@matt.com"
            };

            return View(employee);
        }



    }
}