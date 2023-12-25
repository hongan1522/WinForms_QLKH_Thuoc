using RestSharp;
using WebAPI_QLKH.Models;
using static WebAPI_QLKH.Controllers.NhanVienController;

namespace WebAPI_QLKH.Services
{
    public class NhanVienService
    {
        private readonly RestClient _client;

        public NhanVienService(string apiBaseUrl)
        {
            _client = new RestClient(apiBaseUrl);
        }
        public List<NhanVien> LayDSNV()
        {
            var request = new RestRequest("api/NhanVien", Method.Get);
            var response = _client.Execute<List<NhanVien>>(request);

            if (response.IsSuccessful)
            {
                return response.Data;
            }
            else
            {
                Console.WriteLine($"Lỗi khi lấy dữ liệu: {response.ErrorMessage}");
                return null;
            }
        }
    }
}