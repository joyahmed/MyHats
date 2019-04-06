using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHats.Models;

namespace MyHats.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HatsController : ControllerBase
    {
        private readonly List<Hat> MyHats = new List<Hat>
        {
            new Hat {Id=1, Name="Geek", PriceUsd=7.99M, ImageLocation="images/geek.png"},
            new Hat {Id=2, Name="Pirate", PriceUsd=34.99M, ImageLocation="images/pirate.jpeg"},
            new Hat {Id=3, Name="Nasa", PriceUsd=9.99M, ImageLocation="images/nasa.jpg"}
        };

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Hat>> Get()
        {
            return Ok(MyHats);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Hat> Get(int id)
        {
            var result = MyHats.FirstOrDefault(h => h.Id == id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Hat value)
        {

            value.Id = MyHats.Max(h => h.Id) + 1;
            MyHats.Add(value);

            return NoContent();

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Hat value)
        {

            var thisHat = MyHats.FirstOrDefault(h => h.Id == id);
            if (thisHat == null) 
            {
                return NotFound();
            }

            thisHat.Name = value.Name;
            thisHat.PriceUsd = value.PriceUsd;

            return NoContent();

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            var hat = MyHats.FirstOrDefault(h => h.Id == id);

            if (hat == null)
            {
                return NotFound();
            }

            MyHats.Remove(hat);
            return NoContent();
        }
    }
}
