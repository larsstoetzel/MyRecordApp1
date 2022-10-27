using Microsoft.Extensions.DependencyInjection;
using MyRecordApp.ViewModel;
using System.Windows;

namespace MyRecordApp.View.Dialogs
{
    /// <summary>
    /// Interaktionslogik für TokenDialogView.xaml
    /// </summary>
    public partial class TokenDialogView : Window
    {
        public TokenDialogView()
        {
            InitializeComponent();
            DataContext = App.Current.Services.GetService<SettingsViewModel>();
            tbxEnterToken.Focus();
        }
        public SettingsViewModel ViewModel => (SettingsViewModel)DataContext;

        
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
