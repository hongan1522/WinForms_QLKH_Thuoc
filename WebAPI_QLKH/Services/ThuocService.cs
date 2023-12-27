using RestSharp;
using WebAPI_QLKH.Models;

namespace WebAPI_QLKH.Services
{
    public class ThuocService
    {
        private readonly RestClient _client;

        public ThuocService(string apiBaseUrl)
        {
            _client = new RestClient(apiBaseUrl);
        }
        public List<Thuoc> LayDSThuoc()
        {
            var request = new RestRequest("api/Thuoc", Method.Get);
            var response = _client.Execute<List<Thuoc>>(request);

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
