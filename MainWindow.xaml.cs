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

namespace ProjektProgramowanie
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void EmployeeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CarsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClientsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Cars_Click(object sender, RoutedEventArgs e)
        {
            Window2 win = new Window2();
            this.Close();
            win.Show();
        }
        private void Employee_Click(object sender, RoutedEventArgs e)
        {
            Window3 win = new Window3();
            this.Close();
            win.Show();
        }
        private void Client_Click(object sender, RoutedEventArgs e)
        {
            Window4 win = new Window4();
            this.Close();
            win.Show();
        }
        private void Repairs_Click(object sender, RoutedEventArgs e)
        {
            Window5 win = new Window5();
            this.Close();
            win.Show();
        }
    }
}
