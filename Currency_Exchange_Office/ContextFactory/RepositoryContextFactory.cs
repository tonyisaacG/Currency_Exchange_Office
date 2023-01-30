using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Repository;

namespace CompanyEmployees.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<DbContextRepository>
    {
        public DbContextRepository CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            var builder = new DbContextOptionsBuilder<DbContextRepository>()
            .UseSqlServer(configuration.GetConnectionString("DatabaseConnection"),
             b => b.MigrationsAssembly("Currency_Exchange_Office"));
            return new DbContextRepository(builder.Options);
        }

     
    }
}
