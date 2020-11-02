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

namespace wpfMessageBox
{
    /// <summary>
    /// Interaction logic for MessageBoxUI.xaml
    /// </summary>
    public partial class MessageBoxUI : Window
    {
        public MessageBoxUI()
        {
            InitializeComponent();
        }
        private void optionNumberOne_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked on Okay button ", "Your Selection", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void optionNumberTwo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked on Cancel button ", "Your Selection", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
