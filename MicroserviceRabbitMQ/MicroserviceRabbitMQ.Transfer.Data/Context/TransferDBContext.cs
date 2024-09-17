using MicroserviceRabbitMQ.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroserviceRabbitMQ.Transfer.Data.Context
{
    public class TransferDBContext : DbContext
    {
        public TransferDBContext(DbContextOptions<TransferDBContext> options) : base(options) { }

        public DbSet<TransferLog> TransferLogs { get; set; }

    }
}
