using DB;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CFBiblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private BibliotecaContext _context;

        public AutorController(BibliotecaContext context)
        {
            _context = context;
        }



        // GET: api/<AutorController>
        [HttpGet]
        public IEnumerable<Autor> Get() => _context.Autors.ToList();

        // GET api/<AutorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AutorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AutorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AutorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
