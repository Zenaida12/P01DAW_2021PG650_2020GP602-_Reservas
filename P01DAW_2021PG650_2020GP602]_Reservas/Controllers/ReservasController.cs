using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace P01DAW_2021PG650_2020GP602__Reservas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservasController : ControllerBase
    {
        // GET: api/<ReservasController>
        [HttpGet]
        private readonly IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ReservasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ReservasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ReservasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReservasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
