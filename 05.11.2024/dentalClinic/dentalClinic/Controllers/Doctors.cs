using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dentalClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Doctors : ControllerBase
    {
        // GET: api/<Doctors>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Doctors>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Doctors>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Doctors>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Doctors>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
