using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        public class ChiNhanhPayload
        {
            public string CN_ID { get; set; }
            public string CN_Name { get; set; }
            public string CN_Address { get; set; }
        }
        public class ChiNhanhPayloadPut
        {
            public string CN_Name { get; set; }
            public string CN_Address { get; set; }
        }

        // GET: api/ChiNhanh
        [HttpGet]
        public IActionResult GetChiNhanh()
        {
            var chiNhanhs = _context.ChiNhanh.ToList();
            return Ok(chiNhanhs);
        }

        // GET: api/ChiNhanh/5
        [HttpGet("{id}")]
        public IActionResult GetChiNhanh(string id)
        {
            var chiNhanh = _context.ChiNhanh.Find(id);

            if (chiNhanh == null)
            {
                return NotFound();
            }

            return Ok(chiNhanh);
        }
        private bool ChiNhanhExists(string id)
        {
            return _context.ChiNhanh.Any(e => e.CN_ID == id);
        }

        // POST: api/ChiNhanh
        [HttpPost]
        public async Task<ActionResult<IEnumerable<ChiNhanh>>> PostChiNhanh([FromBody] List<ChiNhanhPayload> payloads)
        {
            if (payloads == null || !payloads.Any())
            {
                return BadRequest("Danh sách payload không hợp lệ");
            }

            var chiNhanhList = payloads.Select(payload => new ChiNhanh
            {
                CN_ID = payload.CN_ID.Trim(),
                CN_Name = payload.CN_Name.Trim(),
                CN_Address = payload.CN_Address.Trim()
            }).ToList();

            _context.ChiNhanh.AddRange(chiNhanhList);
            await _context.SaveChangesAsync();

            return chiNhanhList;
        }

        // PUT: api/ChiNhanh/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChiNhanh(string id, [FromBody] ChiNhanhPayloadPut payload)
        {
            if (payload == null || string.IsNullOrEmpty(payload.CN_Name) || string.IsNullOrEmpty(payload.CN_Address))
            {
                return BadRequest("Danh sách payload không hợp lệ");
            }

            var chiNhanh = await _context.ChiNhanh.FindAsync(id);

            if (chiNhanh == null)
            {
                return NotFound();
            }

            chiNhanh.CN_Name = payload.CN_Name;
            chiNhanh.CN_Address = payload.CN_Address;

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

            // Trả về kết quả thành công
            return NoContent();
        }

        // DELETE: api/ChiNhanh/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChiNhanh(string id)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    //Xóa DNhap_ID bảng ChiTietDonNhap
                    await _context.Database.ExecuteSqlRawAsync($"DELETE FROM ChiTietDonNhap WHERE DNhap_ID IN (SELECT DNhap_ID FROM DonNhap WHERE NV_ID IN (SELECT NV_ID FROM NhanVien WHERE CN_ID = '{id}'))");

                    //Xóa NV_ID bảng DonNhap
                    await _context.Database.ExecuteSqlRawAsync($"DELETE FROM DonNhap WHERE NV_ID IN (SELECT NV_ID FROM NhanVien WHERE CN_ID = '{id}')");

                    //Xóa DXuat_ID bảng ChiTietDonXuat
                    await _context.Database.ExecuteSqlRawAsync($"DELETE FROM ChiTietDonXuat WHERE DXuat_ID IN (SELECT DXuat_ID FROM DonXuat WHERE NV_ID IN (SELECT NV_ID FROM NhanVien WHERE CN_ID = '{id}'))");

                    //Xóa NV_ID bảng DonXuat
                    await _context.Database.ExecuteSqlRawAsync($"DELETE FROM DonXuat WHERE NV_ID IN (SELECT NV_ID FROM NhanVien WHERE CN_ID = '{id}')");

                    //Xóa Lo_ID bảng ChiTietThuoc
                    await _context.Database.ExecuteSqlRawAsync($"DELETE FROM ChiTietThuoc WHERE Lo_ID IN (SELECT Lo_ID FROM Lo WHERE Kho_ID IN (SELECT Kho_ID FROM Kho WHERE CN_ID = '{id}'))");

                    //Xóa Kho_ID bảng Lo
                    await _context.Database.ExecuteSqlRawAsync($"DELETE FROM Lo WHERE Kho_ID IN (SELECT Kho_ID FROM Kho WHERE CN_ID = '{id}')");

                    //Xóa CN_ID bảng Kho
                    await _context.Database.ExecuteSqlRawAsync($"DELETE FROM Kho WHERE CN_ID = '{id}'");

                    //Xóa CN_ID bảng NhanVien
                    await _context.Database.ExecuteSqlRawAsync($"DELETE FROM NhanVien WHERE CN_ID = '{id}'");

                    //Xóa dữ liệu bảng ChiNhanh
                    var chiNhanh = await _context.ChiNhanh.FindAsync(id);
                    if (chiNhanh == null)
                    {
                        return NotFound();
                    }

                    _context.ChiNhanh.Remove(chiNhanh);

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
    }
}
