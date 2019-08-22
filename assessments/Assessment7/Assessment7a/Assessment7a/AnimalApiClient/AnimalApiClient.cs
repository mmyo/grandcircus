using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Assessment7a.AnimalApiClient
{
    public class AnimalApiClient
    {
        public async Task<List<Animal>> GetAllAnimals()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://gc-zoo.surge.sh");
            var response = await client.GetAsync($"/api/animals.json");
            var content = await response.Content.ReadAsStringAsync();
            var results = JsonConvert.DeserializeObject<AnimalApiSearch>(content);

            var animalList = results.Results.ToList();

            return animalList;
        }

        public async Task<Animal> GetSpeciesDetail(string animalSpecies)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://gc-zoo.surge.sh");
            var response = await client.GetAsync($"/api/species/{animalSpecies.ToLower()}.json");

            if (response.StatusCode.ToString() == "OK")
            {

                var content = await response.Content.ReadAsStringAsync();
                var animal = JsonConvert.DeserializeObject<Animal>(content);

                return animal;
            }
            else
            {
                return null;
            }
        }
    }
}
