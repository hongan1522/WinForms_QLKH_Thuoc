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
    public class DonNhapController : ControllerBase
    {
        private readonly QLKH_ThuocContext _context;

        public DonNhapController(QLKH_ThuocContext context)
        {
            _context = context;
        }

        // GET: api/DonNhap
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DonNhap>>> GetDonNhap()
        {
          if (_context.DonNhap == null)
          {
              return NotFound();
          }
            return await _context.DonNhap.ToListAsync();
        }

        // GET: api/DonNhap/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DonNhap>> GetDonNhap(string id)
        {
          if (_context.DonNhap == null)
          {
              return NotFound();
          }
            var donNhap = await _context.DonNhap.FindAsync(id);

            if (donNhap == null)
            {
                return NotFound();
            }

            return donNhap;
        }

        // PUT: api/DonNhap/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDonNhap(string id, DonNhap donNhap)
        {
            if (id != donNhap.DNhap_ID)
            {
                return BadRequest();
            }

            _context.Entry(donNhap).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonNhapExists(id))
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

        // POST: api/DonNhap
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DonNhap>> PostDonNhap(DonNhap donNhap)
        {
          if (_context.DonNhap == null)
          {
              return Problem("Entity set 'QLKH_ThuocContext.DonNhap'  is null.");
          }
            _context.DonNhap.Add(donNhap);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DonNhapExists(donNhap.DNhap_ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDonNhap", new { id = donNhap.DNhap_ID }, donNhap);
        }

        // DELETE: api/DonNhap/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDonNhap(string id)
        {
            if (_context.DonNhap == null)
            {
                return NotFound();
            }
            var donNhap = await _context.DonNhap.FindAsync(id);
            if (donNhap == null)
            {
                return NotFound();
            }

            _context.DonNhap.Remove(donNhap);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DonNhapExists(string id)
        {
            return (_context.DonNhap?.Any(e => e.DNhap_ID == id)).GetValueOrDefault();
        }
    }
}
