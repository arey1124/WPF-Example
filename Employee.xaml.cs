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
using System.Data;
using WpfApp1.ServiceReference1;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Employee.xaml
    /// </summary>
    public partial class Employee : Window
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmployeeClient emp = new EmployeeClient();
            gd1.ItemsSource = emp.getEmployees();
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            EmployeeClient emp = new EmployeeClient();
            UserAuth a = emp.getEmployeeRowById(tb1.Text.Trim());
            if (a!=null)
            {
                lb1.Content = "Record Found";
                tb2.Text = a.uname;
                tb3.Text = a.password;
            }
            else
            {
                lb1.Content = "No matching record";
                tb1.Text = "";
                tb2.Text = "";
                tb3.Text = "";
            }
            
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            EmployeeClient emp = new EmployeeClient();
            bool a = emp.updateEmployee(tb1.Text.Trim(),tb2.Text.Trim(),tb3.Text.Trim());
            if (a)
            {
                lb1.Content = "Updated Successfully";
                tb1.Text = "";
                tb2.Text = "";
                tb3.Text = "";
            }
            else
            {
                lb1.Content = "Failed to update";
                tb1.Text = "";
                tb2.Text = "";
                tb3.Text = "";
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            EmployeeClient emp = new EmployeeClient();
            bool a = emp.deleteEmployee(tb1.Text.Trim());
            if (a)
            {
                lb1.Content = "Deleted Successfully";
                tb1.Text = "";
                tb2.Text = "";
                tb3.Text = "";
            }
            else
            {
                lb1.Content = "Failed to delete";
                tb1.Text = "";
                tb2.Text = "";
                tb3.Text = "";
            }

        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {
            EmployeeClient emp = new EmployeeClient();
            bool a = emp.insertEmployee(tb1.Text.Trim(),tb2.Text.Trim(),tb3.Text.Trim());
            if (a)
            {
                lb1.Content = "Inserted Successfully";
                tb1.Text = "";
                tb2.Text = "";
                tb3.Text = "";
            }
            else
            {
                lb1.Content = "Failed to insert";
                tb1.Text = "";
                tb2.Text = "";
                tb3.Text = "";
            }
        }
    }
}
