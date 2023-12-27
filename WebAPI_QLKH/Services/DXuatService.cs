using RestSharp;
using WebAPI_QLKH.Models;

namespace WebAPI_QLKH.Services
{
    public class DXuatService
    {
        private readonly RestClient _client;

        public DXuatService(string apiBaseUrl)
        {
            _client = new RestClient(apiBaseUrl);
        }
        public List<DonXuat> LayDSDX()
        {
            var request = new RestRequest("api/DonXuat", Method.Get);
            var response = _client.Execute<List<DonXuat>>(request);

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
