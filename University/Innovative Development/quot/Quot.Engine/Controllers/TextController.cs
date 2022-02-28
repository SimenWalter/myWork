using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quot.Engine.Entities;
using Quot.Engine.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Quot.Engine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {

        ITextService Service { get; set; }
        public TextController(ITextService _service)
        {
            Service = _service;
        }
        // GET: api/<TextController>
        [HttpGet]
        public List<Paragraph> Get()
        {
            return Service.getAll();
        }

        // GET api/<TextController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TextController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TextController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TextController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
