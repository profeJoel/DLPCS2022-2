using BDAutomotora;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstAutomotora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private AutomotoraContext _context;

        public MarcaController(AutomotoraContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Marca> Get() => _context.Marcas.ToList();
    }
}
