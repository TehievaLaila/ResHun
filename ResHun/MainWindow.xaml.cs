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

namespace ResHun
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
            this.Close();

        }

        private void men_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Авторизируйтесь пожалуйста!");
        }

        private void bro_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Авторизируйтесь пожалуйста!");
        }

        private void abou_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Авторизируйтесь пожалуйста!");
        }

        private void revi_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Авторизируйтесь пожалуйста!");
        }

        private void cont_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Авторизируйтесь пожалуйста!");
        }
    }
}
