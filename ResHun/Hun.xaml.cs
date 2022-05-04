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
using ResHun.Pages;

namespace ResHun
{
    /// <summary>
    /// Логика взаимодействия для Hun.xaml
    /// </summary>
    public partial class Hun : Window
    {
        public Hun()
        {
            InitializeComponent();
        }
        private void Me_Click(object sender, RoutedEventArgs e)
        {
            Old.Navigate(new MenuPage());
        }

        private void Br_Click(object sender, RoutedEventArgs e)
        {
            Old.Navigate(new ReservationPage());
        }

        private void AU_Click(object sender, RoutedEventArgs e)
        {
            Old.Navigate(new AboutUsPage());
        }

        private void Review_Click(object sender, RoutedEventArgs e)
        {
            Old.Navigate(new ReviewPage());
        }

        private void Cont_Click(object sender, RoutedEventArgs e)
        {
            Old.Navigate(new ContactPage());
        }

        private void Bas_Click(object sender, RoutedEventArgs e)
        {
            Old.Navigate(new BasketPage());
        }

        private void lich_Click(object sender, RoutedEventArgs e)
        {
            LichKab lichKab = new LichKab();
            lichKab.Show();
        }
    }
}

