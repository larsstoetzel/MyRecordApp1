using Microsoft.Extensions.DependencyInjection;
using MyRecordApp.Model;
using MyRecordApp.Properties;
using MyRecordApp.Services;
using MyRecordApp.ViewModel;
using Refit;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace MyRecordApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider Services { get; }
        public new static App Current => (App)Application.Current;
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
            services.AddTransient<SettingsViewModel>();
            services.AddTransient<AuthorizationHeaderHandler>();
            services.AddRefitClient<IDiscogsApi>().ConfigureHttpClient(x => x.BaseAddress = new Uri("https://api.discogs.com"))
                .AddHttpMessageHandler<AuthorizationHeaderHandler>();
            services.AddTransient<SearchViewModel>();
            return services.BuildServiceProvider();
        }
       }
   
}
