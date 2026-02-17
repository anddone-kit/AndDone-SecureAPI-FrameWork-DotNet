using AndDoneSecureClientLibrary.Api;
using AndDoneSecureClientLibrary.Client;
using APISample.APIProcessor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.DataFormats;

namespace APISample
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Environment.SetEnvironmentVariable("AndDoneSecureApi__xVersion", "2.2");
            //Environment.SetEnvironmentVariable("AndDoneSecureApi__xAppKey", "xxxxxx");

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();
            ServiceProvider.GetRequiredService<BatchesAPIProcessor>();
            ServiceProvider.GetRequiredService<CancellationsAPIProcessor>();
            ServiceProvider.GetRequiredService<EPFAPIProcessor>();
            ServiceProvider.GetRequiredService<OutboundPaymentsAPIProcessor>();
            ServiceProvider.GetRequiredService<PaymentAPIProcessor>();
            ServiceProvider.GetRequiredService<PaymentDetailsAPIProcessor>();
            ServiceProvider.GetRequiredService<PaymentIntentsAPIProcessor>();
            ServiceProvider.GetRequiredService<PaymentLinksAPIProcessor>();
            ServiceProvider.GetRequiredService<RefundsAPIProcessor>();
            ServiceProvider.GetRequiredService<ReportsAPIProcessor>();
            ServiceProvider.GetRequiredService<TokenLinksAPIProcessor>();
            ServiceProvider.GetRequiredService<TokensAPIProcessor>();
            ServiceProvider.GetRequiredService<VendorAPIProcessor>();
            ServiceProvider.GetRequiredService<ConfigurationControl>();

            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        private static void ConfigureServices(ServiceCollection serviceCollection)
        {

            var config = new ConfigurationBuilder().SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            serviceCollection.Configure<APISample.Settings.ConfigSettings>(config.GetSection("AndDoneSecureApi"));
            serviceCollection.AddTransient<MainForm>();
            serviceCollection.AddSingleton<BatchesAPIProcessor>();
            serviceCollection.AddSingleton<CancellationsAPIProcessor>();
            serviceCollection.AddSingleton<EPFAPIProcessor>();
            serviceCollection.AddSingleton<OutboundPaymentsAPIProcessor>();
            serviceCollection.AddSingleton<PaymentAPIProcessor>();
            serviceCollection.AddSingleton<PaymentDetailsAPIProcessor>();
            serviceCollection.AddSingleton<PaymentIntentsAPIProcessor>();
            serviceCollection.AddSingleton<PaymentLinksAPIProcessor>();
            serviceCollection.AddSingleton<RefundsAPIProcessor>();
            serviceCollection.AddSingleton<ReportsAPIProcessor>();
            serviceCollection.AddSingleton<TokenLinksAPIProcessor>();
            serviceCollection.AddSingleton<TokensAPIProcessor>();
            serviceCollection.AddSingleton<VendorAPIProcessor>();
            serviceCollection.AddSingleton<ConfigurationControl>();
        }
    }
}
