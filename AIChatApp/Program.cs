using AIChatApp.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AIChatApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            Application.Run(new Form1(host.Services));
        }

        static IHostBuilder CreateHostBuilder()
        {
            var builder = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddWindowsFormsBlazorWebView();
                    services.AddDevExpressBlazor(options =>
                    {
                        options.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5;
                        options.SizeMode = DevExpress.Blazor.SizeMode.Medium;
                    });
                    services.AddSingleton<WeatherForecastService>();
                });
            return builder;
        }
    }
}