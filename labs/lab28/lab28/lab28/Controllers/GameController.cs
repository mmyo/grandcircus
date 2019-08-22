using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using lab28.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab28.Controllers
{
    public class GameController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ISession _session;
        private readonly HttpClient _client;

        public GameController(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor)
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

        public IActionResult StartGame()
        {
            _session.SetString("player1", "Bob");
            _session.SetString("player2", "Linda");

            return View();

        }

        public async Task<IActionResult> GetNewDeck()
        {
            var response = await _client.GetAsync("api/deck/new/shuffle/?deck_count=1");

            var content = await response.Content.ReadAsAsync<Deck>();

            _session.SetString("gameDeckId", content.Deck_Id);
            

            return View("Index");
        }

        public async Task<IActionResult> DealHands()
        {
            var deckId = _session.GetString("gameDeckId");

            if (deckId != null)
            {
                var response = await _client.GetAsync($"api/deck/{deckId}/draw/?count=5");
                var content = await response.Content.ReadAsAsync<Deck>();
                string playerOneCards = null;

                foreach (var card in content.Cards)
                {
                    playerOneCards += card.Code + ",";
                }

                response = await _client.GetAsync($"api/deck/{deckId}/draw/?count=5");
                content = await response.Content.ReadAsAsync<Deck>();
                var playerTwoCards = content.Cards;

                var responsePlayerOne = await _client.GetAsync($"api/deck/{deckId}/pile/player1/add/?cards=AS,2S");

                var drawnCardsList = content.Cards;

            }

            return View("Index");
        }

    }
}