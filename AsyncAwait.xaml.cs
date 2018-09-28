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
using System.Threading.Tasks;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AsyncAwait.xaml
    /// </summary>
    public partial class AsyncAwait : Window
    {
        public AsyncAwait()
        {
            InitializeComponent();
        }

        public int getCount()
        {
            StreamReader streamReader = new StreamReader("C:/Users/User/Desktop/test.txt");
            System.Threading.Thread.Sleep(6000);
            return streamReader.ReadToEnd().Length;
        }

        private async void count_Click(object sender, RoutedEventArgs e)
        {
            Task<int> tasks = new Task<int>(getCount);
            tasks.Start();
            int count = await tasks;
            result.Content = count.ToString();
        }
    }
}
