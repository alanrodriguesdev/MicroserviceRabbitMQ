using MicroserviceRabbitMQ.MVC.Models.DTO;
using Refit;

namespace MicroserviceRabbitMQ.MVC.Refit.Interfaces
{
    public interface IBankingApi
    {
       [Post("/api/Banking")]
       Task<dynamic> PostAsync([Body] TransferDTO transferDTO);
    }
}
