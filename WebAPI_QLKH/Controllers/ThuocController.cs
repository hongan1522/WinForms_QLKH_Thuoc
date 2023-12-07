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
    public class ThuocController : ControllerBase
    {
        private readonly QLKH_ThuocContext _context;

        public ThuocController(QLKH_ThuocContext context)
        {
            _context = context;
        }

        // GET: api/Thuoc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Thuoc>>> GetThuoc()
        {
          if (_context.Thuoc == null)
          {
              return NotFound();
          }
            return await _context.Thuoc.ToListAsync();
        }

        // GET: api/Thuoc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Thuoc>> GetThuoc(string id)
        {
          if (_context.Thuoc == null)
          {
              return NotFound();
          }
            var thuoc = await _context.Thuoc.FindAsync(id);

            if (thuoc == null)
            {
                return NotFound();
            }

            return thuoc;
        }

        // PUT: api/Thuoc/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutThuoc(string id, Thuoc thuoc)
        {
            if (id != thuoc.Thuoc_ID)
            {
                return BadRequest();
            }

            _context.Entry(thuoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThuocExists(id))
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

        // POST: api/Thuoc
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Thuoc>> PostThuoc(Thuoc thuoc)
        {
          if (_context.Thuoc == null)
          {
              return Problem("Entity set 'QLKH_ThuocContext.Thuoc'  is null.");
          }
            _context.Thuoc.Add(thuoc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ThuocExists(thuoc.Thuoc_ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetThuoc", new { id = thuoc.Thuoc_ID }, thuoc);
        }

        // DELETE: api/Thuoc/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteThuoc(string id)
        {
            if (_context.Thuoc == null)
            {
                return NotFound();
            }
            var thuoc = await _context.Thuoc.FindAsync(id);
            if (thuoc == null)
            {
                return NotFound();
            }

            _context.Thuoc.Remove(thuoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ThuocExists(string id)
        {
            return (_context.Thuoc?.Any(e => e.Thuoc_ID == id)).GetValueOrDefault();
        }
    }
}
