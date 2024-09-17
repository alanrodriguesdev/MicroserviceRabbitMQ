using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MicroserviceRabbitMQ.Transfer.Data.Context
{
    public class TransferDbContextFactory : IDesignTimeDbContextFactory<TransferDBContext>
    {
        public TransferDBContext CreateDbContext(string[] args)
        {
            // Obtenha a configuração do arquivo appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Crie a instância de DbContextOptions usando a string de conexão do arquivo de configuração
            var optionsBuilder = new DbContextOptionsBuilder<TransferDBContext>();
            var connectionString = configuration.GetConnectionString("TransferDbConnection");

            optionsBuilder.UseSqlServer(connectionString);

            return new TransferDBContext(optionsBuilder.Options);
        }
    }
}
