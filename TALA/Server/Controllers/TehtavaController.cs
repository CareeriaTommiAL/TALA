using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TALA.Server.Data;
using TALA.Server.Models;

namespace TALA.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TehtavaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TehtavaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Tehtava
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tehtava>>> GetTehtavat()
        {
            return await _context.Tehtavat.ToListAsync();
        }

        // GET: api/Tehtava/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tehtava>> GetTehtava(int id)
        {
            var tehtava = await _context.Tehtavat.FindAsync(id);

            if (tehtava == null)
            {
                return NotFound();
            }

            return tehtava;
        }

        // PUT: api/Tehtava/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTehtava(int id, Tehtava tehtava)
        {
            if (id != tehtava.TehtavaId)
            {
                return BadRequest();
            }

            _context.Entry(tehtava).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TehtavaExists(id))
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

        // POST: api/Tehtava
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tehtava>> PostTehtava(Tehtava tehtava)
        {
            _context.Tehtavat.Add(tehtava);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTehtava", new { id = tehtava.TehtavaId }, tehtava);
        }

        // DELETE: api/Tehtava/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTehtava(int id)
        {
            var tehtava = await _context.Tehtavat.FindAsync(id);
            if (tehtava == null)
            {
                return NotFound();
            }

            _context.Tehtavat.Remove(tehtava);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TehtavaExists(int id)
        {
            return _context.Tehtavat.Any(e => e.TehtavaId == id);
        }
    }
}
