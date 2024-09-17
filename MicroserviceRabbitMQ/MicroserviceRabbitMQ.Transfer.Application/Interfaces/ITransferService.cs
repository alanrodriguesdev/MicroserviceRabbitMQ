using MicroserviceRabbitMQ.Transfer.Domain.Models;

namespace MicroserviceRabbitMQ.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
