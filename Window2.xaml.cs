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

namespace ProjektProgramowanie
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            CarServicesEntities db = new CarServicesEntities();
            var a = from f in db.samochodies
                    select new
                    {
                        f.VIN,
                        f.marka,
                        f.model,
                        f.nrSilnika,
                        f.peselWlasciciela
                    };
            this.Cars.ItemsSource = a.ToList();


        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Window2 win = new Window2();
            this.Close();
            win.Show();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            this.Close();
            win.Show();
        }
        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            Window2 win = new Window2();
            this.Close();
            win.Show();
        }
        private void Aktualizuj_Click(object sender, RoutedEventArgs e)
        {
            Window2 win = new Window2();
            this.Close();
            win.Show();
        }

    }
}
