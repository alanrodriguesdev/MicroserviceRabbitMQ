using MicroserviceRabbitMQ.Banking.Application.Interfaces;
using MicroserviceRabbitMQ.Banking.Application.Models;
using MicroserviceRabbitMQ.Banking.Domain.Commands;
using MicroserviceRabbitMQ.Banking.Domain.Interfaces;
using MicroserviceRabbitMQ.Banking.Domain.Models;
using MicroserviceRabbitMQ.Domain.Core.Bus;

namespace MicroserviceRabbitMQ.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;
        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand
                (
                    accountTransfer.FromAccount,
                    accountTransfer.ToAccount,
                    accountTransfer.TransferAmount
                );
            _bus.SendCommand(createTransferCommand);
        }
    }
}
