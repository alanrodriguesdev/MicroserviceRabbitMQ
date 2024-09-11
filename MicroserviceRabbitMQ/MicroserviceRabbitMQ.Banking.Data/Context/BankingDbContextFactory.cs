using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MicroserviceRabbitMQ.Banking.Data.Context
{
    public class BankingDbContextFactory : IDesignTimeDbContextFactory<BankingDBContext>
    {
        public BankingDBContext CreateDbContext(string[] args)
        {
            // Obtenha a configuração do arquivo appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Crie a instância de DbContextOptions usando a string de conexão do arquivo de configuração
            var optionsBuilder = new DbContextOptionsBuilder<BankingDBContext>();
            var connectionString = configuration.GetConnectionString("BankingDbConnection");

            optionsBuilder.UseSqlServer(connectionString);

            return new BankingDBContext(optionsBuilder.Options);
        }
    }
}
