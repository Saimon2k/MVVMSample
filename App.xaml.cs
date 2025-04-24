using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVVMSample.ViewModel;
using System.Windows;

namespace MVVMSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider _provider;
        private static IHost _host;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Настройка DI
            _host = CreateHostBuilder(e.Args).Build();
            _provider = _host.Services;
            _host.RunAsync();

            // Запуск главного окна
            var mainWindow = _provider.GetRequiredService<MainWindow>();
            mainWindow.DataContext = _provider.GetRequiredService<TrainViewModel>();
            mainWindow.Show();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    //services.AddDbContext<TrainContext>();
                    services.AddSingleton<MainWindow>();
                    services.AddSingleton<TrainViewModel>();
                });
    }

}
