using MicroserviceRabbitMQ.Transfer.Domain.Models;

namespace MicroserviceRabbitMQ.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
        void Add(TransferLog transferLog);
    }
}
