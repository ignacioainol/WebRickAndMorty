using System.Text.Json;
using WebRickAndMorty.Interfaz;
using WebRickAndMorty.Models;

namespace WebRickAndMorty.Service
{
    public class RickMorty : IRickMorty
    {
      
        public async Task<Root> GetAllCharacter()
        {
            string url = "https://rickandmortyapi.com/api/character/?page=1";
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            //var characters2 = JsonSerializer.Deserialize<Root>(result);
            var characters = JsonSerializer.Deserialize<Root>(result);
            return characters;
        }

        

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);




    }
}
