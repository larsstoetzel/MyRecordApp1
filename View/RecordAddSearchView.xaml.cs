using Microsoft.Extensions.DependencyInjection;
using MyRecordApp.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace MyRecordApp.View
{
    /// <summary>
    /// Interaktionslogik für RecordAddSearchView.xaml
    /// </summary>
    public partial class RecordAddSearchView : Window
    {
        public RecordAddSearchView()
        {
            InitializeComponent();
            DataContext = App.Current.Services.GetService<SearchViewModel>();
            tbxSearch.Focus();

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void lvRecordSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
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
