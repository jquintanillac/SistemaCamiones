using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Driver.web.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Driver.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMDEventosController : ControllerBase
    {
        private readonly Datacontext _context;

        public SVMDEventosController(Datacontext context)
        {
            _context = context;
        }

        // GET: api/<SVMDEventosController>
        [HttpGet]
        public async Task<IActionResult> Fulleventos()
        {
            var events = await _context.Eventos.Select(e => new
            {
                id = e.id,
                title = e.title,
                description = e.Description,
                start = e.StarDate.ToString("yyyy-MM-ddTHH:mm:ss"),
                end = e.EndDate.AddDays(1).ToString("yyyy-MM-ddTHH:mm:ss"),
                Alldays = false
            }).ToListAsync();
            return new JsonResult(events);
        }

        // GET api/<SVMDEventosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SVMDEventosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SVMDEventosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SVMDEventosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
