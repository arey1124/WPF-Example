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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!", "This is title");
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!", "Button Dialog", MessageBoxButton.YesNoCancel);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!", "Button Dialog", MessageBoxButton.YesNoCancel,MessageBoxImage.Warning);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Are you sure ?","Closing Window", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
