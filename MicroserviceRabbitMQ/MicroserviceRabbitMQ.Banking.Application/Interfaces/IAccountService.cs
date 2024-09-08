using MicroserviceRabbitMQ.Banking.Domain.Models;

namespace MicroserviceRabbitMQ.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
    }
}
