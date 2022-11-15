using Microsoft.Extensions.DependencyInjection;
using MyRecordApp.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace MyRecordApp.View
{
    /// <summary>
    /// Interaktionslogik für AddSearchView.xaml
    /// </summary>
    public partial class AddSearchView : Window
    {
        public AddSearchView()
        {
            InitializeComponent();
            DataContext = App.Current.Services.GetService<AddSearchViewModel>();
            tbxSearch.Focus();

        }

      
        private void addRecord_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

      
    }
}
