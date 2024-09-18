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
using MicroserviceRabbitMQ.Transfer.Domain.EventHandlers;
using MicroserviceRabbitMQ.Transfer.Domain.Events;
using MicroserviceRabbitMQ.Transfer.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MicroserviceRabbitMQ.Infra.IoC
{
    public class DependecyContainer
    {
        public static IServiceCollection RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            //Subscription
            services.AddTransient<TransferEventHandler>();
            //services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            //{
            //    // Obtém o IServiceProviderFactory com o tipo correto
            //    var serviceProviderFactory = sp.GetRequiredService<IServiceProviderFactory<IServiceCollection>>();

            //    // Cria o IServiceProvider
            //    var serviceProvider = serviceProviderFactory.CreateServiceProvider((IServiceCollection)sp);

            //    // Obtém IMediator do IServiceProvider
            //    var mediator = serviceProvider.GetService<IMediator>();

            //    // Cria e retorna o RabbitMQBus
            //    return new RabbitMQBus(mediator, (IServiceScopeFactory)serviceProvider);
            //});

            //Subscription
            services.AddTransient<TransferEventHandler>();

            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();


            //Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            // Application Services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();

            //Data
            services.AddScoped<ITransferRepository, TransferRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<TransferDBContext>();
            services.AddScoped<BankingDBContext>();

            return services;
        }
    }
}
