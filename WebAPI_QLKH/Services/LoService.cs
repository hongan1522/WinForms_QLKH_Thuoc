using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI_QLKH.Controllers;
using WebAPI_QLKH.Models;
using static WebAPI_QLKH.Controllers.LoController;

namespace WebAPI_QLKH.Services
{
    public class LoService
    {
        private readonly RestClient _restClient;

        public LoService(string baseUrl)
        {
            _restClient = new RestClient(baseUrl);
        }

        public async Task<List<Lo>> LayDanhSachLo()
        {
            var request = new RestRequest("api/Lo", Method.Get);
            var response = await _restClient.ExecuteAsync<List<Lo>>(request);

            return response.Data;
        }
        public async Task<RestResponse> ThemLo(LoPost loPost)
        {
            var request = new RestRequest("api/Lo", Method.Post)
                .AddJsonBody(loPost);

            return await _restClient.ExecuteAsync(request);
        }

        public async Task<RestResponse> CapNhatLo(string id, LoPut loPut)
        {
            var request = new RestRequest($"api/Lo/{id}", Method.Put)
                .AddJsonBody(loPut);

            return await _restClient.ExecuteAsync(request);
        }

        public async Task<RestResponse> XoaLo(string id)
        {
            var request = new RestRequest($"api/Lo/{id}", Method.Delete);

            return await _restClient.ExecuteAsync(request);
        }

    }
}
