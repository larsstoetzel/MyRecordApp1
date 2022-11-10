using CommunityToolkit.Mvvm.Input;
using MyRecordApp.Properties;
using MyRecordApp.Services;
using System.Threading.Tasks;
using System.Windows;

namespace MyRecordApp.ViewModel
{
    public class SettingsViewModel
    {
        private readonly IDiscogsApi _discogsApi;
        public SettingsViewModel(IDiscogsApi api)
        {            
            SaveTokenCommand = new AsyncRelayCommand<string>(SaveToken);
            _discogsApi = api;
        }
        
        public IAsyncRelayCommand <string> SaveTokenCommand { get; }
        public async Task SaveToken(string accessToken)
        {
            var response = await _discogsApi.CheckAccessTokenAsync("Discogs token=" + accessToken);
            if (response.IsSuccessStatusCode)
            {
                Settings.Default.AccessToken = accessToken;
                Settings.Default.Save();
            }
            else MessageBox.Show("Invalid Token", "InvalidToken",MessageBoxButton.OK ,MessageBoxImage.Error);
            
        }
    }
    
}
