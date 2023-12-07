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
    public class KhoController : ControllerBase
    {
        private readonly QLKH_ThuocContext _context;

        public KhoController(QLKH_ThuocContext context)
        {
            _context = context;
        }

        // GET: api/Kho
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kho>>> GetKho()
        {
          if (_context.Kho == null)
          {
              return NotFound();
          }
            return await _context.Kho.ToListAsync();
        }

        // GET: api/Kho/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Kho>> GetKho(string id)
        {
          if (_context.Kho == null)
          {
              return NotFound();
          }
            var kho = await _context.Kho.FindAsync(id);

            if (kho == null)
            {
                return NotFound();
            }

            return kho;
        }

        // PUT: api/Kho/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKho(string id, Kho kho)
        {
            if (id != kho.Kho_ID)
            {
                return BadRequest();
            }

            _context.Entry(kho).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KhoExists(id))
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

        // POST: api/Kho
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Kho>> PostKho(Kho kho)
        {
          if (_context.Kho == null)
          {
              return Problem("Entity set 'QLKH_ThuocContext.Kho'  is null.");
          }
            _context.Kho.Add(kho);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (KhoExists(kho.Kho_ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetKho", new { id = kho.Kho_ID }, kho);
        }

        // DELETE: api/Kho/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKho(string id)
        {
            if (_context.Kho == null)
            {
                return NotFound();
            }
            var kho = await _context.Kho.FindAsync(id);
            if (kho == null)
            {
                return NotFound();
            }

            _context.Kho.Remove(kho);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KhoExists(string id)
        {
            return (_context.Kho?.Any(e => e.Kho_ID == id)).GetValueOrDefault();
        }
    }
}
