using MicroserviceRabbitMQ.MVC.Models.DTO;
using MicroserviceRabbitMQ.MVC.Refit.Interfaces;
using Newtonsoft.Json;
using Refit;

namespace MicroserviceRabbitMQ.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _httpClient;
        private readonly IBankingApi _bankingApi;
        public TransferService(HttpClient httpClient, IBankingApi bankingApi)
        {
            _httpClient = httpClient;
            _bankingApi = bankingApi;
        }
        public async Task TransferAsync(TransferDTO transferDTO)
        {
            var response = await _bankingApi.PostAsync(transferDTO);
        }

        //HTTPCLIENT
        public async Task TransferAsync2(TransferDTO transferDTO)
        {
            var uri = "https://localhost:7250";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDTO)
                , System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
