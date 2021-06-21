using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TALA.Server.Data;
using TALA.Shared;

namespace TALA.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuoritusController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SuoritusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Suoritus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Suoritus>>> GetSuoritukset()
        {
            return await _context.Suoritukset.ToListAsync();
        }

        // GET: api/Suoritus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Suoritus>> GetSuoritus(int id)
        {
            var suoritus = await _context.Suoritukset.FindAsync(id);

            if (suoritus == null)
            {
                return NotFound();
            }

            return suoritus;
        }

        // PUT: api/Suoritus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuoritus(int id, Suoritus suoritus)
        {
            if (id != suoritus.SuoritusId)
            {
                return BadRequest();
            }

            _context.Entry(suoritus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuoritusExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Suoritus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Suoritus>> PostSuoritus(Suoritus suoritus)
        {
            _context.Suoritukset.Add(suoritus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSuoritus", new { id = suoritus.SuoritusId }, suoritus);
        }

        // DELETE: api/Suoritus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSuoritus(int id)
        {
            var suoritus = await _context.Suoritukset.FindAsync(id);
            if (suoritus == null)
            {
                return NotFound();
            }

            _context.Suoritukset.Remove(suoritus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SuoritusExists(int id)
        {
            return _context.Suoritukset.Any(e => e.SuoritusId == id);
        }
    }
}
