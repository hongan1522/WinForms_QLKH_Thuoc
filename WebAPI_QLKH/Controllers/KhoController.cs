﻿using System;
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
        public class KhoPayload
        {
            public string Kho_ID { get; set; }
            public string Kho_Name { get; set; }
            public string Kho_Address { get; set; }
            public string CN_ID { get; set; }
        }
        public class KhoPayloadPut
        {
            public string Kho_Name { get; set; }
            public string Kho_Address { get; set; }
            public string CN_ID { get; set; }
        }
        // GET: api/Kho
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kho>>> GetKho()
        {
            var kho = _context.Kho.ToList();
            return Ok(kho);
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
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKho(string id, [FromBody] KhoPayloadPut payload)
        {
            if (payload == null || string.IsNullOrEmpty(payload.Kho_Name) || string.IsNullOrEmpty(payload.Kho_Address))
            {
                return BadRequest("Danh sách payload không hợp lệ");
            }

            var Kho = await _context.Kho.FindAsync(id);

            if (Kho == null)
            {
                return NotFound();
            }

            Kho.Kho_Name = payload.Kho_Name;
            Kho.Kho_Address = payload.Kho_Address;
            Kho.CN_ID = payload.CN_ID;

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

            // Trả về kết quả thành công
            return NoContent();
        }

        // POST: api/Kho
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Kho>>> PostKho([FromBody] List<KhoPayload> payloads)
        {
            if (payloads == null || !payloads.Any())
            {
                return BadRequest("Danh sách payload không hợp lệ");
            }

            var KhoList = payloads.Select(payload => new Kho
            {
                CN_ID = payload.CN_ID.Trim(),
                Kho_ID = payload.Kho_ID.Trim(),
                Kho_Name = payload.Kho_Name.Trim(),
                Kho_Address = payload.Kho_Address.Trim()
            }).ToList();

            _context.Kho.AddRange(KhoList);
            await _context.SaveChangesAsync();

            return KhoList;
        }

        // DELETE: api/Kho/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKho(string id)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    //Xóa Lo_ID bảng ChiTietThuoc
                    await _context.Database.ExecuteSqlRawAsync($"DELETE FROM ChiTietThuoc WHERE Lo_ID IN (SELECT Lo_ID FROM Lo WHERE Kho_ID = '{id}')");

                    //Xóa Lo_ID bảng ChiTietDonNhap
                    await _context.Database.ExecuteSqlRawAsync($"DELETE FROM ChiTietDonNhap WHERE Lo_ID IN (SELECT Lo_ID FROM Lo WHERE Kho_ID = '{id}')");

                    //Xóa Kho_ID bảng Lo
                    await _context.Database.ExecuteSqlRawAsync($"DELETE FROM Lo WHERE Kho_ID = '{id}'");

                    //Xóa dữ liệu bảng Kho
                    var kho = await _context.Kho.FindAsync(id);
                    if (kho == null)
                    {
                        return NotFound();
                    }

                    _context.Kho.Remove(kho);

                    await _context.SaveChangesAsync();

                    transaction.Commit();

                    return NoContent();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        private bool KhoExists(string id)
        {
            return (_context.Kho?.Any(e => e.Kho_ID == id)).GetValueOrDefault();
        }
    }
}
