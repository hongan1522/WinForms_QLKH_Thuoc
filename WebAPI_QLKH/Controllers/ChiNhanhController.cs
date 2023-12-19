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
        public class ChiNhanhPost
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
        public async Task<ActionResult<IEnumerable<ChiNhanh>>> PostChiNhanh([FromBody] List<ChiNhanhPost> payloads)
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
                    // Xóa dữ liệu liên quan trong ChiTietDonNhap
                    var relatedChiTietDonNhaps = await _context.ChiTietDonNhap
                        .Where(ctdn => ctdn.DNhap.NV_ID == id)
                        .ToListAsync();
                    _context.ChiTietDonNhap.RemoveRange(relatedChiTietDonNhaps);

                    // Xóa dữ liệu liên quan trong DonNhap
                    var relatedDonNhaps = await _context.DonNhap
                        .Where(dn => dn.NV_ID == id)
                        .ToListAsync();
                    _context.DonNhap.RemoveRange(relatedDonNhaps);

                    // Xóa dữ liệu liên quan trong ChiTietDonXuat
                    var relatedChiTietDonXuats = await _context.ChiTietDonXuat
                        .Where(ctdx => ctdx.DXuat.NV_ID == id)
                        .ToListAsync();
                    _context.ChiTietDonXuat.RemoveRange(relatedChiTietDonXuats);

                    // Xóa dữ liệu liên quan trong DonXuat
                    var relatedDonXuats = await _context.DonXuat
                        .Where(dx => dx.NV_ID == id)
                        .ToListAsync();
                    _context.DonXuat.RemoveRange(relatedDonXuats);

                    // Xóa dữ liệu liên quan trong ChiTietThuoc
                    var relatedChiTietThuocs = await _context.ChiTietThuoc
                        .Where(ctt => ctt.Lo.Kho.CN_ID == id)
                        .ToListAsync();
                    _context.ChiTietThuoc.RemoveRange(relatedChiTietThuocs);

                    // Xóa dữ liệu liên quan trong Lo
                    var relatedLos = await _context.Lo
                        .Where(lo => lo.Kho.CN_ID == id)
                        .ToListAsync();
                    _context.Lo.RemoveRange(relatedLos);

                    // Xóa dữ liệu liên quan trong Kho
                    var relatedKhos = await _context.Kho
                        .Where(kho => kho.CN_ID == id)
                        .ToListAsync();
                    _context.Kho.RemoveRange(relatedKhos);

                    // Xóa dữ liệu liên quan trong NhanVien
                    var relatedNhanViens = await _context.NhanVien
                        .Where(nv => nv.CN_ID == id)
                        .ToListAsync();
                    _context.NhanVien.RemoveRange(relatedNhanViens);

                    // Xóa dữ liệu trong ChiNhanh
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
