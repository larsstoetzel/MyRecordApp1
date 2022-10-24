using Microsoft.Extensions.DependencyInjection;
using MyRecordApp.Model;
using MyRecordApp.ViewModel;
using System;
using System.Windows;

namespace MyRecordApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider Services { get; }
        public App()
        {
            Services = ConfigureServices();
            var dbContext = Services.GetRequiredService<RecordContext>();
            dbContext.Database.EnsureCreated();
        }

        private IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddDbContext<RecordContext>();
            services.AddSingleton<SettingsViewModel>();
            return services.BuildServiceProvider();
        }
       }
   
}
