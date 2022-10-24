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

namespace MyRecordApp.View.Dialogs
{
    /// <summary>
    /// Interaktionslogik für DeleteSureYesNoView.xaml
    /// </summary>
    public partial class DeleteSureYesNoView : Window
    {
        public DeleteSureYesNoView()
        {
            InitializeComponent();
        }
        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
