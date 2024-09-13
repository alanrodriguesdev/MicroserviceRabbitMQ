using MediatR;
using MicroserviceRabbitMQ.Banking.Domain.Commands;
using MicroserviceRabbitMQ.Banking.Domain.Events;
using MicroserviceRabbitMQ.Domain.Core.Bus;

namespace MicroserviceRabbitMQ.Banking.Domain.CommandsHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;
        public TransferCommandHandler(IEventBus bus)
        {
                _bus = bus;
        }
        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            //Publish event to RabbitMQ
            _bus.Publish(new TransferCreatedEvent(request.From,request.To,request.Amount));
            return Task.FromResult(true);
        }
    }
}
