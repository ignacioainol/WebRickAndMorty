using Microsoft.AspNetCore.Mvc;
using WebRickAndMorty.Interfaz;
using WebRickAndMorty.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebRickAndMorty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RickMortyController : ControllerBase
    {
        private readonly IRickMorty _rickMorty;

        public RickMortyController(IRickMorty rickMorty)
        {
            _rickMorty = rickMorty;
        }

        // GET: api/<RickMortyController>
        [HttpGet("/getCharacters")]
        public async Task<Root> Get()
        {
            var result = await _rickMorty.GetAllCharacter();
            return result;
        }

        // GET api/<RickMortyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RickMortyController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RickMortyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RickMortyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
