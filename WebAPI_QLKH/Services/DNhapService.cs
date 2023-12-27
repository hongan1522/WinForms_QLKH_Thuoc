using RestSharp;
using WebAPI_QLKH.Models;

namespace WebAPI_QLKH.Services
{
    public class DNhapService
    {
        private readonly RestClient _client;

        public DNhapService(string apiBaseUrl)
        {
            _client = new RestClient(apiBaseUrl);
        }
        public List<DonNhap> LayDSDN()
        {
            var request = new RestRequest("api/DonNhap", Method.Get);
            var response = _client.Execute<List<DonNhap>>(request);

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
