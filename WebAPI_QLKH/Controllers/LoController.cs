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
    public class LoPost
    {
        public string Lo_ID { get; set; }
        public string Lo_Name { get; set; }
        public string Lo_Position { get; set; }
        public string Kho_ID { get; set; }
    }

    public class LoPut
    {
        public string Lo_Name { get; set; }
        public string Lo_Position { get; set; }
    }

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
        public IActionResult GetLo()
        {
            var lo = _context.Lo.ToList();
            return Ok(lo);
        }

        // GET: api/Lo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lo>> GetLo(string id)
        {
            var lo = await _context.Lo.FindAsync(id);

            if (lo == null)
            {
                return NotFound();
            }

            return lo;
        }

        // POST: api/Lo
        [HttpPost]
        public async Task<ActionResult<Lo>> PostLo(LoPost loPost)
        {
            var lo = new Lo
            {
                Lo_ID = loPost.Lo_ID,
                Lo_Name = loPost.Lo_Name,
                Lo_Position = loPost.Lo_Position,
                Kho_ID = loPost.Kho_ID
            };

            _context.Lo.Add(lo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLo", new { id = lo.Lo_ID }, lo);
        }

        // PUT: api/Lo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLo(string id, LoPut loPut)
        {
            var lo = await _context.Lo.FindAsync(id);

            if (lo == null)
            {
                return NotFound();
            }

            lo.Lo_Name = loPut.Lo_Name;
            lo.Lo_Position = loPut.Lo_Position;

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

            var ctdn = await _context.ChiTietDonNhap.FindAsync(lo.Lo_ID);
            if (ctdn != null)
            {
                _context.ChiTietDonNhap.Remove(ctdn);
            }

            var ctt = await _context.ChiTietThuoc.FindAsync(lo.Lo_ID);
            if (ctt != null)
            {
                _context.ChiTietThuoc.Remove(ctt);
            }

            _context.Lo.Remove(lo);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        private void UpdateLo_ID(string currentID, string newID)
        {
            _context.ChiTietDonNhap.Where(ctdn => ctdn.Lo_ID == currentID)
                .ToList()
                .ForEach(ctdn => ctdn.Lo_ID = newID);

            _context.ChiTietThuoc.Where(ctt => ctt.Lo_ID == currentID)
                .ToList()
                .ForEach(ctt => ctt.Lo_ID = newID);
        }

        private bool LoExists(string id)
        {
            return _context.Lo.Any(e => e.Lo_ID == id);
        }
    }
}
