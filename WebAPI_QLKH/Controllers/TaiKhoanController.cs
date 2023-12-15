﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_QLKH.Models;
using static WebAPI_QLKH.Controllers.KhoController;

namespace WebAPI_QLKH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaiKhoanController : ControllerBase
    {
        private readonly QLKH_ThuocContext _context;

        public TaiKhoanController(QLKH_ThuocContext context)
        {
            _context = context;
        }
        public class TKPayload
        {
            public string UserID { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public string Description { get; set; }
            public string RoleID { get; set; }
        }
        public class TKPayloadPut
        {
            public string Description { get; set; }
            public string RoleID { get; set; }
        }

        // GET: api/TaiKhoan
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaiKhoan>>> GetTaiKhoan()
        {
          if (_context.TaiKhoan == null)
          {
              return NotFound();
          }
            return await _context.TaiKhoan.ToListAsync();
        }

        // GET: api/TaiKhoan/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaiKhoan>> GetTaiKhoan(string id)
        {
          if (_context.TaiKhoan == null)
          {
              return NotFound();
          }
            var taiKhoan = await _context.TaiKhoan.FindAsync(id);

            if (taiKhoan == null)
            {
                return NotFound();
            }

            return taiKhoan;
        }

        // PUT: api/TaiKhoan/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaiKhoan(string id, [FromBody] TKPayloadPut payload)
        {
            var taiKhoan = await _context.TaiKhoan.FindAsync(id);

            if (taiKhoan == null)
            {
                return NotFound();
            }

            taiKhoan.Description = payload.Description;
            taiKhoan.RoleID = payload.RoleID;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaiKhoanExists(id))
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

        // POST: api/TaiKhoan
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IEnumerable<TaiKhoan>>> PostTaiKhoan([FromBody] List<TKPayload> payloads)
        {
            if (payloads == null || !payloads.Any())
            {
                return BadRequest("Danh sách payload không hợp lệ");
            }

            var TaiKhoanList = payloads.Select(payload => new TaiKhoan
            {
                UserID = payload.UserID.Trim(),
                RoleID = payload.RoleID.Trim(),
                UserName = payload.UserName.Trim(),
                Password = payload.Password.Trim(),
                Description = payload.Description.Trim()
            }).ToList();

            _context.TaiKhoan.AddRange(TaiKhoanList);
            await _context.SaveChangesAsync();

            return TaiKhoanList;
        }

        // DELETE: api/TaiKhoan/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaiKhoan(string id)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    //Xóa DXuat_ID bảng ChiTietDonXuat
                    await _context.Database.ExecuteSqlRawAsync($"DELETE FROM ChiTietDonXuat WHERE DXuat_ID IN (SELECT DXuat_ID FROM DonXuat WHERE NV_ID IN (SELECT NV_ID FROM NhanVien WHERE UserID = '{id}'))");

                    //Xóa NV_ID bảng DonXuat
                    await _context.Database.ExecuteSqlRawAsync($"DELETE FROM DonXuat WHERE NV_ID IN (SELECT NV_ID FROM NhanVien WHERE UserID = '{id}')");

                    //Xóa DNhap_ID bảng ChiTietDonNhap
                    await _context.Database.ExecuteSqlRawAsync($"DELETE FROM ChiTietDonNhap WHERE DNhap_ID IN (SELECT DNhap_ID FROM DonNhap WHERE NV_ID IN (SELECT NV_ID FROM NhanVien WHERE UserID = '{id}'))");

                    //Xóa NV_ID bảng DonNhap
                    await _context.Database.ExecuteSqlRawAsync($"DELETE FROM DonNhap WHERE NV_ID IN (SELECT NV_ID FROM NhanVien WHERE UserID = '{id}')");

                    //Xóa UserID bảng NhanVien
                    await _context.Database.ExecuteSqlRawAsync($"DELETE FROM NhanVien WHERE UserID = '{id}'");

                    //Xóa dữ liệu bảng TaiKhoan
                    var taiKhoan = await _context.TaiKhoan.FindAsync(id);
                    if (taiKhoan == null)
                    {
                        return NotFound();
                    }

                    _context.TaiKhoan.Remove(taiKhoan);

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
        private bool TaiKhoanExists(string id)
        {
            return (_context.TaiKhoan?.Any(e => e.UserID == id)).GetValueOrDefault();
        }
    }
}
