using MicroserviceRabbitMQ.Domain.Core.Commands;

namespace MicroserviceRabbitMQ.Banking.Domain.Commands
{
    public class TransferCommand : Command
    {
        public int From { get; protected set; }
        public int To { get; protected set; }
        public decimal Amount { get; protected set; }
    }
}
