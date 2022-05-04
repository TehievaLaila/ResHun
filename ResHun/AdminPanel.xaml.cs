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
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Prod_Click(object sender, RoutedEventArgs e)
        {
            Tal.Navigate(new AdmPage());
        }

        private void Post_Click(object sender, RoutedEventArgs e)
        {
            Tal.Navigate(new PostavPage());
        }

        private void Sot_Click(object sender, RoutedEventArgs e)
        {
            Tal.Navigate(new SotrPage());
        }
    }
}
