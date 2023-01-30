<<<<<<< HEAD
using Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository;
using Services;
using Services.Contracts;
using System.ComponentModel.Design;
using System.Configuration;
using System.IO;
=======
using Currency_Exchange_Office.client;
using Currency_Exchange_Office.mainForm;
using Currency_Exchange_Office.treaders;
>>>>>>> shehab

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
<<<<<<< HEAD
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
          ///  Application.Run(new Purchases_Frm());
=======
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            
            Application.Run(ServiceProvider.GetRequiredService<Desposit_Form>());
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
                    services.AddDbContext<DbContextRepository>(o=>o.UseSqlServer(configuration.GetConnectionString("DatabaseConnection")));
                    services.AddScoped<IRepositoryManager, RepositoryManager>();
                    services.AddScoped<IServicesManager, ServicesManager>();
                    services.AddTransient<Desposit_Form>();
                });
>>>>>>> main
=======
            Application.Run(new MainForm());
>>>>>>> shehab
        }
    }
}
