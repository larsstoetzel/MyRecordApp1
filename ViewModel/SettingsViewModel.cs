using MyRecordApp.Properties;

namespace MyRecordApp.ViewModel
{
    public class SettingsViewModel
    {
        public void SaveToken(string accessToken)
        {
            Settings.Default.accessToken = accessToken;
            Settings.Default.Save();
        }
    }
    
}
