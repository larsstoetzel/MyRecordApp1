using Microsoft.Extensions.DependencyInjection;
using MyRecordApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyRecordApp.View
{
    /// <summary>
    /// Interaktionslogik für MyCollectionView.xaml
    /// </summary>
    public partial class MyCollectionView : Window
    {
        public MyCollectionView()
        {
            InitializeComponent();
            DataContext = App.Current.Services.GetService<MyCollectionViewModel>();
        }

        private void MyRecords_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAddSearch_Click(object sender, RoutedEventArgs e)
        {
            AddSearchView addSearchView = new AddSearchView();
            addSearchView.Show();
        }
    }
}
