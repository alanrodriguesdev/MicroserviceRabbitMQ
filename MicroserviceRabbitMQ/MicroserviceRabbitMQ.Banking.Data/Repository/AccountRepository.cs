using MicroserviceRabbitMQ.Banking.Data.Context;
using MicroserviceRabbitMQ.Banking.Domain.Interfaces;
using MicroserviceRabbitMQ.Banking.Domain.Models;

namespace MicroserviceRabbitMQ.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDBContext _ctx;
        public AccountRepository(BankingDBContext dBContext)
        {
            _ctx = dBContext;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
