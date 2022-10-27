using CommunityToolkit.Mvvm.Input;
using MyRecordApp.Properties;
using MyRecordApp.View.Dialogs;
using System.Windows;
using System.Windows.Input;

namespace MyRecordApp.ViewModel
{
    public class SettingsViewModel
    {
        public SettingsViewModel()
        {
            SaveTokenCommand = new RelayCommand<string>(SaveToken);
        }
        public IRelayCommand <string> SaveTokenCommand { get; }
        public void SaveToken(string accessToken)
        {
            Settings.Default.AccessToken = accessToken;
            Settings.Default.Save();
        }
    }
    
}
