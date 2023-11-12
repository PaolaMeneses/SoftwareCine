using Microsoft.AspNetCore.Mvc;
using SotfwareCine.API.Data;
using Microsoft.EntityFrameworkCore;
using SotfwareCine.Shared.Entities;

namespace SotfwareCine.API.Controllers
{
    [ApiController]
    [Route("/api/teatros")]
    public class TeatrosController : ControllerBase
    {
      private readonly DataContext _context;

            public TeatrosController(DataContext context)
            {
                _context = context;
            }

            [HttpPost]
            public async Task<ActionResult> Post(Teatro teatro)
            {
                _context.Add(teatro);
                await _context.SaveChangesAsync();
                return Ok(teatro);
            }

            [HttpGet]
            public async Task<ActionResult> Get()
            {
                return Ok(await _context.Teatros.ToListAsync());
            }

        }
    }


