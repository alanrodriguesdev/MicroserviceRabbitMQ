using MicroserviceRabbitMQ.Transfer.Data.Context;
using MicroserviceRabbitMQ.Transfer.Domain.Interfaces;
using MicroserviceRabbitMQ.Transfer.Domain.Models;

namespace MicroserviceRabbitMQ.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDBContext _ctx;
        public TransferRepository(TransferDBContext dBContext)
        {
            _ctx = dBContext;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _ctx.TransferLogs;
        }
    }
}
