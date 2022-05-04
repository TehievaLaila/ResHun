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

namespace ResHun.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public int x = 1;
        public MenuPage()
        {
            InitializeComponent();
            GetInfoProduct();
        }
        private void GetInfoProduct()
        {
            ResHun.db.Dishes dish = new ResHun.db.Dishes();
            try
            {
                var lst1 = from cust in App.en.Dishes
                           where cust.ID_Dishes == x
                           select cust;
                var lst2 = from cust in App.en.Dishes
                           where cust.ID_Dishes == x + 1
                           select cust;

                Nam.Content = lst1.First().Name;
                Mee.Content = lst1.First().ID_Meat;
                Descrip.Text = lst1.First().Description;
                Pri.Content = lst1.First().Price;

                Nana.Content = lst2.First().Name;
                Mee.Content = lst2.First().ID_Meat;
                desdes.Text = lst2.First().Description;
                pripri.Content = lst2.First().Price;
            }
            catch { }
        }
    }
}
