using MicroserviceRabbitMQ.Domain.Core.Bus;
using MicroserviceRabbitMQ.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace microserviceRabbitMQ.Infra.IoC
{
    public class DependecyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
