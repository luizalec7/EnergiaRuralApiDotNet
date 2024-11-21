using EnergiaRuralApi.Data;
using EnergiaRuralApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EnergiaRuralApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimulacaoController : ControllerBase
    {
        private readonly EnergiaRuralContext _context;

        public SimulacaoController(EnergiaRuralContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSimulacao([FromBody] Simulacao simulacao)
        {
            _context.Simulacoes.Add(simulacao);
            await _context.SaveChangesAsync();
            return Ok(simulacao);
        }

        [HttpGet("{usuarioId}")]
        public async Task<IActionResult> GetSimulacoesByUser(int usuarioId)
        {
            var simulacoes = await _context.Simulacoes.Where(s => s.UsuarioId == usuarioId).ToListAsync();
            return Ok(simulacoes);
        }
    }
}