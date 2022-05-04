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
using ResHun.db;

namespace ResHun.Pages
{
    /// <summary>
    /// Логика взаимодействия для PostavPage.xaml
    /// </summary>
    public partial class PostavPage : Page
    {
        public static Entities db = new Entities();
        public PostavPage()
        {
            InitializeComponent();
            var cl = from pk in db.Products select pk;
            Mar.ItemsSource = cl.ToList();
            Mar.DisplayMemberPath = "Name";
        }
        private void Mar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var pp = Mar.SelectedItem as Products;
            var pro = from pr in db.Supliers
                      join kat in db.Products
                      on pr.ID_Supliers equals kat.ID_Supliers
                      where kat.Name == pp.Name
                      select new
                      {
                          Имя = pr.Name,
                          Телефон = pr.Phone,

                      };
            Man.ItemsSource = pro.ToList();
        }

    }
}
