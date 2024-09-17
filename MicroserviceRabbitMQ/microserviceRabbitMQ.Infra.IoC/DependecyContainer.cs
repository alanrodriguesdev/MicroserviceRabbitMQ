using MediatR;
using MicroserviceRabbitMQ.Banking.Application.Interfaces;
using MicroserviceRabbitMQ.Banking.Application.Services;
using MicroserviceRabbitMQ.Banking.Data.Context;
using MicroserviceRabbitMQ.Banking.Data.Repository;
using MicroserviceRabbitMQ.Banking.Domain.Commands;
using MicroserviceRabbitMQ.Banking.Domain.CommandsHandlers;
using MicroserviceRabbitMQ.Banking.Domain.Interfaces;
using MicroserviceRabbitMQ.Domain.Core.Bus;
using MicroserviceRabbitMQ.Infra.Bus;
using MicroserviceRabbitMQ.Transfer.Application.Interfaces;
using MicroserviceRabbitMQ.Transfer.Application.Services;
using MicroserviceRabbitMQ.Transfer.Data.Context;
using MicroserviceRabbitMQ.Transfer.Data.Repository;
using MicroserviceRabbitMQ.Transfer.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MicroserviceRabbitMQ.Infra.IoC
{
    public class DependecyContainer
    {
        public static IServiceCollection RegisterServices(IServiceCollection services)
        {           
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            // Application Services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();

            //Data
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<TransferDBContext>();
            services.AddTransient<BankingDBContext>();

            return services;
        }
    }
}
