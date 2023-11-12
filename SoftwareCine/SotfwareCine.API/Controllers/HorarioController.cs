using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SotfwareCine.API.Data;
using SotfwareCine.Shared.Entities;

namespace SotfwareCine.API.Controllers
{
    [ApiController]
    [Route("/api/horarios")]
    public class HorarioController : ControllerBase
    {
        private readonly DataContext _context;

        public HorarioController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Post(Horario horario)
        {
            _context.Add(horario);
            await _context.SaveChangesAsync();
            return Ok(horario);
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Teatros.ToListAsync());
        }

    }
}



