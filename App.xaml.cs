using MVVMSample.ViewModel;
using System.Windows;
using MVVMSample.Model;
using Microsoft.Extensions.DependencyInjection;

namespace MVVMSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //public IServiceProvider Services { get; }

        //public App()
        //{
            //Services = ConfigureServices();
        //}

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow mainWindow = new() { DataContext = new TrainViewModel(new Train()) };
            mainWindow.Show();
            // Запуск главного окна
            //var mainWindow = Services.GetRequiredService<MainWindow>();
            //mainWindow.DataContext = Services.GetRequiredService<TrainViewModel>();
            //mainWindow.Show();
        }

        //private static IServiceProvider ConfigureServices()
        //{
        //    var services = new ServiceCollection();

        //    services.AddSingleton<MainWindow>();
        //    services.AddSingleton<TrainViewModel>();

        //    return services.BuildServiceProvider();
        //}

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureServices((hostContext, services) =>
        //        {
        //            //services.AddDbContext<TrainContext>();
        //            services.AddSingleton<MainWindow>();
        //            services.AddSingleton<TrainViewModel>();
        //        });
    }

}
