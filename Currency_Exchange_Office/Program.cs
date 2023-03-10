using Contracts;
using Currency_Exchange_Office.client;
using Currency_Exchange_Office.login;
using Currency_Exchange_Office.mainForm;
using Currency_Exchange_Office.treaders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository;
using Services;
using Services.Contracts;

namespace Currency_Exchange_Office
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        private static IHostBuilder CreateHostBuilder()
        {
            var c = Directory.GetCurrentDirectory().Replace("\\bin\\Debug\\net6.0-windows", "");
            var configuration = new ConfigurationBuilder()
            .SetBasePath(c)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();
            //var builder = new DbContextOptionsBuilder<DbContextRepository>()
            //.UseSqlServer(configuration.GetConnectionString("DatabaseConnection"),
            // b => b.MigrationsAssembly("Currency_Exchange_Office"));

            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddDbContext<DbContextRepository>(o => o.UseSqlServer(configuration.GetConnectionString("DatabaseConnection")));
                    services.AddScoped<IRepositoryManager, RepositoryManager>();
                    services.AddScoped<IServicesManager, ServicesManager>();
                    services.AddScoped<MainForm>();
                });
        }
    }
}
