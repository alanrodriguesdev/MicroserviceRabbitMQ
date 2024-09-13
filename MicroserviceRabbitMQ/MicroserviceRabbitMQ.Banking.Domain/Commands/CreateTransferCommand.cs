namespace MicroserviceRabbitMQ.Banking.Domain.Commands
{
    public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(int from, int to, decimal amount) 
        {
            this.From = from;
            this.To = to;
            this.Amount = amount;
        }
    }
}
