using MicroserviceRabbitMQ.Domain.Core.Bus;
using MicroserviceRabbitMQ.Transfer.Application.Interfaces;
using MicroserviceRabbitMQ.Transfer.Domain.Interfaces;
using MicroserviceRabbitMQ.Transfer.Domain.Models;

namespace MicroserviceRabbitMQ.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;
        public TransferService(ITransferRepository transferRepository, IEventBus bus)
        {
            _transferRepository = transferRepository;
            _bus = bus;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
           return _transferRepository.GetTransferLogs();
        }
    }
}
