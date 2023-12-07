using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_QLKH.Models;

namespace WebAPI_QLKH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoController : ControllerBase
    {
        private readonly QLKH_ThuocContext _context;

        public LoController(QLKH_ThuocContext context)
        {
            _context = context;
        }

        // GET: api/Lo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lo>>> GetLo()
        {
          if (_context.Lo == null)
          {
              return NotFound();
          }
            return await _context.Lo.ToListAsync();
        }

        // GET: api/Lo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lo>> GetLo(string id)
        {
          if (_context.Lo == null)
          {
              return NotFound();
          }
            var lo = await _context.Lo.FindAsync(id);

            if (lo == null)
            {
                return NotFound();
            }

            return lo;
        }

        // PUT: api/Lo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLo(string id, Lo lo)
        {
            if (id != lo.Lo_ID)
            {
                return BadRequest();
            }

            _context.Entry(lo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoExists(id))
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

        // POST: api/Lo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Lo>> PostLo(Lo lo)
        {
          if (_context.Lo == null)
          {
              return Problem("Entity set 'QLKH_ThuocContext.Lo'  is null.");
          }
            _context.Lo.Add(lo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LoExists(lo.Lo_ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLo", new { id = lo.Lo_ID }, lo);
        }

        // DELETE: api/Lo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLo(string id)
        {
            if (_context.Lo == null)
            {
                return NotFound();
            }
            var lo = await _context.Lo.FindAsync(id);
            if (lo == null)
            {
                return NotFound();
            }

            _context.Lo.Remove(lo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LoExists(string id)
        {
            return (_context.Lo?.Any(e => e.Lo_ID == id)).GetValueOrDefault();
        }
    }
}
