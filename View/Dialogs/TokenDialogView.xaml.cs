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
            tbxEnterToken.Focus();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.AccessToken = tbxEnterToken.ToString();
            Properties.Settings.Default.Save();
            this.Close();
          
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
