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
    public class NCCController : ControllerBase
    {
        private readonly QLKH_ThuocContext _context;

        public NCCController(QLKH_ThuocContext context)
        {
            _context = context;
        }

        // GET: api/NCC
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NCC>>> GetNCC()
        {
          if (_context.NCC == null)
          {
              return NotFound();
          }
            return await _context.NCC.ToListAsync();
        }

        // GET: api/NCC/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NCC>> GetNCC(string id)
        {
          if (_context.NCC == null)
          {
              return NotFound();
          }
            var nCC = await _context.NCC.FindAsync(id);

            if (nCC == null)
            {
                return NotFound();
            }

            return nCC;
        }

        // PUT: api/NCC/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNCC(string id, NCC nCC)
        {
            if (id != nCC.NCC_ID)
            {
                return BadRequest();
            }

            _context.Entry(nCC).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NCCExists(id))
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

        // POST: api/NCC
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NCC>> PostNCC(NCC nCC)
        {
          if (_context.NCC == null)
          {
              return Problem("Entity set 'QLKH_ThuocContext.NCC'  is null.");
          }
            _context.NCC.Add(nCC);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (NCCExists(nCC.NCC_ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetNCC", new { id = nCC.NCC_ID }, nCC);
        }

        // DELETE: api/NCC/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNCC(string id)
        {
            if (_context.NCC == null)
            {
                return NotFound();
            }
            var nCC = await _context.NCC.FindAsync(id);
            if (nCC == null)
            {
                return NotFound();
            }

            _context.NCC.Remove(nCC);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NCCExists(string id)
        {
            return (_context.NCC?.Any(e => e.NCC_ID == id)).GetValueOrDefault();
        }
    }
}
