using MicroserviceRabbitMQ.Domain.Core.Events;

namespace MicroserviceRabbitMQ.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime TimeStamp { get; protected set; }

        protected Command()
        {
           TimeStamp = DateTime.Now;
        }
    }
}
