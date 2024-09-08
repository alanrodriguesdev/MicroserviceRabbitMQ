using MicroserviceRabbitMQ.Banking.Application.Interfaces;
using MicroserviceRabbitMQ.Banking.Domain.Interfaces;
using MicroserviceRabbitMQ.Banking.Domain.Models;

namespace MicroserviceRabbitMQ.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
                _accountRepository = accountRepository;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }
    }
}
