using EnergiaRuralApi.Data;
using EnergiaRuralApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EnergiaRuralApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly EnergiaRuralContext _context;

        public UsuarioController(EnergiaRuralContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return Ok(usuario);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var usuario = await _context.Usuarios.Include(u => u.Simulacoes).FirstOrDefaultAsync(u => u.UsuarioId == id);
            if (usuario == null) return NotFound();

            return Ok(usuario);
        }
    }
}