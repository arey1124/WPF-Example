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
using System.Data;
using System.Data.SqlClient;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for NewPage.xaml
    /// </summary>
    public partial class NewPage : Page
    {
        public NewPage()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        SqlConnection con;
        int r = 0;
        int max;
        private void connect_Click(object sender, RoutedEventArgs e)
        {
            string cs = "server=USER-PC;user id=sa;password=1234;database=StpDB";
            con = new SqlConnection(cs);
            con.Open();

            string query = "Select * FROM tblStocks";
            SqlDataAdapter da = new SqlDataAdapter(query,con);

            da.Fill(ds);
            da.Dispose();
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }  
        }

        private void get_Click(object sender, RoutedEventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                DataTable d = ds.Tables[0];
                grid.ItemsSource = d.DefaultView;
            } 
        }

        private void first_Click(object sender, RoutedEventArgs e)
        {
            DataRow d = ds.Tables[0].Rows[0];
            t1.Text = d[0].ToString();
            t2.Text = d[1].ToString();
            t3.Text = d[2].ToString();
            r = 0;
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            max = ds.Tables[0].Rows.Count-1;
            if (r == max)
            {
                MessageBox.Show("This is the last record , no next record available");
            }
            else
            {
                r += 1;
                DataRow d = ds.Tables[0].Rows[r];
                t1.Text = d[0].ToString();
                t2.Text = d[1].ToString();
                t3.Text = d[2].ToString();
            }
        }

        private void prev_Click(object sender, RoutedEventArgs e)
        {
            if (r == 0)
            {
                MessageBox.Show("This is the first record , no previous record available");
            }
            else
            {
                r -= 1;
                DataRow d = ds.Tables[0].Rows[r];
                t1.Text = d[0].ToString();
                t2.Text = d[1].ToString();
                t3.Text = d[2].ToString();
            }
        }

        private void last_Click(object sender, RoutedEventArgs e)
        {
            max = ds.Tables[0].Rows.Count-1;
            DataRow d = ds.Tables[0].Rows[max];
            t1.Text = d[0].ToString();
            t2.Text = d[1].ToString();
            t3.Text = d[2].ToString();
            r = max;
        }
    }
}
