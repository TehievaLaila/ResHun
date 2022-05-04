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
using ResHun.db;

namespace ResHun
{
    /// <summary>
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        public static Entities db = new Entities();
        public Order()
        {
            InitializeComponent();
            Prod();
        }
        private void Prod()
        {
            var qadr =
                from Pro in db.Products
                select new
                {
                    ID = Pro.ID_Products,
                    Name = Pro.Name,
                    Count = Pro.Count
                };
            Fly.ItemsSource = qadr.ToList();
        }

        private void Ord_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
