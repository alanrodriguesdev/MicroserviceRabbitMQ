using MicroserviceRabbitMQ.MVC.Models.DTO;

namespace MicroserviceRabbitMQ.MVC.Services
{
    public interface ITransferService
    {
        Task TransferAsync(TransferDTO transferDTO);
    }
}
