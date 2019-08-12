using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab28.Models;
using System.Net.Http;
using Microsoft.AspNetCore.Http;

namespace lab28.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ISession _session;
        private readonly HttpClient _client;

        public HomeController(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _session = httpContextAccessor.HttpContext.Session;
            _client = _httpClientFactory.CreateClient();
            _client.BaseAddress = new Uri("https://deckofcardsapi.com");

        }

        public IActionResult Index()
        {


            return View();
        }

        //public IActionResult Index(Deck deck)
        //{

        //    return View(deck);
        //}

        public async Task<IActionResult> NewDeck()
        {
            
            var response = await _client.GetAsync("api/deck/new/shuffle/?deck_count=1");
            var content = await response.Content.ReadAsAsync<Deck>();

            _session.SetString("deckId", content.Deck_Id);
            _session.SetInt32("remaining", content.Remaining);

            return RedirectToAction("Index", "Home", content);
        }

        public async Task<IActionResult> DrawCards()
        {
            var deckId = _session.GetString("deckId");
            if (deckId != null)
            {
                var response = await _client.GetAsync($"api/deck/{deckId}/draw/?count=5");
                var content = await response.Content.ReadAsAsync<Deck>();
                _session.SetInt32("remaining", content.Remaining);

                ViewData["drawnCardsList"] = content.Cards;
                return View("Index");

            }

            return View("Index");
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
