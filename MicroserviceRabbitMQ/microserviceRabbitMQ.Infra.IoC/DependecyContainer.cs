using MicroserviceRabbitMQ.Banking.Application.Interfaces;
using MicroserviceRabbitMQ.Banking.Application.Services;
using MicroserviceRabbitMQ.Banking.Data.Context;
using MicroserviceRabbitMQ.Banking.Data.Repository;
using MicroserviceRabbitMQ.Banking.Domain.Interfaces;
using MicroserviceRabbitMQ.Domain.Core.Bus;
using MicroserviceRabbitMQ.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MicroserviceRabbitMQ.Infra.IoC
{
    public class DependecyContainer
    {
        public static IServiceCollection RegisterServices(IServiceCollection services)
        {
           
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            // Application Services
            services.AddTransient<IAccountService,AccountService>();

            //Data
            services.AddTransient<IAccountRepository,AccountRepository>();
            services.AddTransient<BankingDBContext>();

            return services;
        }
    }
}
