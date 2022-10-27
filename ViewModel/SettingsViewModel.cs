using CommunityToolkit.Mvvm.Input;
using MyRecordApp.Properties;
using MyRecordApp.Services;
using System.Threading.Tasks;

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
            var identity = await _discogsApi.CheckAccessTokenAsync(accessToken);      
            Settings.Default.AccessToken = accessToken;
            Settings.Default.Save();
        }
    }
    
}
