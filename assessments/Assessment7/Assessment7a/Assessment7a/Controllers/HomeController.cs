using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assessment7a.Models;

namespace Assessment7a.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var animalApiClient = new AnimalApiClient.AnimalApiClient();

            var animalList = await animalApiClient.GetAllAnimals();

            return View(animalList);
        }

        public async Task<IActionResult> Species(string animalSpecies)
        {
            var animalApiClient = new AnimalApiClient.AnimalApiClient();
            var animal = new AnimalApiClient.Animal();

            if (animalSpecies != null)
            {
                animal = await animalApiClient.GetSpeciesDetail(animalSpecies);
                if (animal != null)
                {
                    return View(animal);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return RedirectToAction("Index");
            }
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
