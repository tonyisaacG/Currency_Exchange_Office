using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using Repository;
using System.Data;

namespace CompanyEmployees.ContextFactory
{
    public static class DatabaseSettingCustome
    {

        public static void ConfigurationBinder(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Financal_Transaction>(FTSetting =>
            {
                FTSetting.HasCheckConstraint("FT_date_ch", "FT_date >= getdate()");
                FTSetting.HasCheckConstraint("FT_transeredAmount_ch", "([FT_transeredAmount]>(0))");
                FTSetting.HasCheckConstraint("FT_exchangeRate_ch", "([FT_exchangeRate]>(0))");
                FTSetting.HasCheckConstraint("FT_amount_ch", "([FT_amount]>(0))");
            });

            modelBuilder.Entity<Desposit>(FTSetting =>
            {
                FTSetting.HasCheckConstraint("Despt_amount_ch", "([Despt_amount] > (0))");
                FTSetting.HasCheckConstraint("Despt_date_ch", "([Despt_date] >= getdate())");
            });
        }
     
    
    }
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
