using Microsoft.AspNetCore.Mvc;
using ResisTechHamb.Data;
using ResisTechHamb.Entities;

namespace ResisTechHamb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly Context _context;

        public ClienteController(Context context)
        {
            _context = context;
        }
        [HttpPost("CriarCliente")]
        public IActionResult Create(clientes clientes)
        {
            _context.Add(clientes);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new { id = clientes.Id }, clientes);
        }
        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var cliente = _context.Clientes.Find(id);

            if (cliente == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(cliente);
            }

        }
    }
}
