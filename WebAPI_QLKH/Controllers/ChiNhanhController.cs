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
    public class ChiNhanhController : ControllerBase
    {
        private readonly QLKH_ThuocContext _context;

        public ChiNhanhController(QLKH_ThuocContext context)
        {
            _context = context;
        }

        // GET: api/ChiNhanh
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChiNhanh>>> GetChiNhanh()
        {
          if (_context.ChiNhanh == null)
          {
              return NotFound();
          }
            return await _context.ChiNhanh.ToListAsync();
        }

        // GET: api/ChiNhanh/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChiNhanh>> GetChiNhanh(string id)
        {
          if (_context.ChiNhanh == null)
          {
              return NotFound();
          }
            var chiNhanh = await _context.ChiNhanh.FindAsync(id);

            if (chiNhanh == null)
            {
                return NotFound();
            }

            return chiNhanh;
        }

        // PUT: api/ChiNhanh/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChiNhanh(string id, ChiNhanh chiNhanh)
        {
            if (id != chiNhanh.CN_ID)
            {
                return BadRequest();
            }

            _context.Entry(chiNhanh).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChiNhanhExists(id))
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

        // POST: api/ChiNhanh
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChiNhanh>> PostChiNhanh(ChiNhanh chiNhanh)
        {
          if (_context.ChiNhanh == null)
          {
              return Problem("Entity set 'QLKH_ThuocContext.ChiNhanh'  is null.");
          }
            _context.ChiNhanh.Add(chiNhanh);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChiNhanhExists(chiNhanh.CN_ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChiNhanh", new { id = chiNhanh.CN_ID }, chiNhanh);
        }

        // DELETE: api/ChiNhanh/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChiNhanh(string id)
        {
            if (_context.ChiNhanh == null)
            {
                return NotFound();
            }
            var chiNhanh = await _context.ChiNhanh.FindAsync(id);
            if (chiNhanh == null)
            {
                return NotFound();
            }

            _context.ChiNhanh.Remove(chiNhanh);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChiNhanhExists(string id)
        {
            return (_context.ChiNhanh?.Any(e => e.CN_ID == id)).GetValueOrDefault();
        }
    }
}
