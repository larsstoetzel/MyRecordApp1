using MyRecordApp.View.Dialogs;
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
    /// Interaktionslogik für WelcomeView.xaml
    /// </summary>
    public partial class WelcomeView : Window
    {
        public WelcomeView()
        {
            InitializeComponent();
        }
        private void btnEnterToken_Click(object sender, RoutedEventArgs e)
        {
           TokenDialogView tokenDialogView = new TokenDialogView();
            tokenDialogView.ShowDialog();
                        
        }
        private void btnMyCollection_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MyCollectionView myCollectionView = new MyCollectionView();
            {
                myCollectionView.ShowDialog();
            }

        }

    }
}
