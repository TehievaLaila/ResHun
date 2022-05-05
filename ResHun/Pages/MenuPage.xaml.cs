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
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        List<Dishes> mydisheslist = new List<Dishes>();
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
                mydisheslist = App.en.Dishes.ToList();
                for (int i = 0; i < 2; i++)
                {

                }
                //var lst1 = from cust in App.en.Dishes
                //           where cust.ID_Dishes == x
                //           select cust;
                //var lst2 = from cust in App.en.Dishes
                //           where cust.ID_Dishes == x + 1
                //           select cust;

                //Nam.Content = lst1.First().Name;
                //Mee.Content = lst1.First().ID_Dishes;
                //Descrip.Text = lst1.First().Description;
                //Pri.Content = lst1.First().Price;
                //Fir.Content = lst1.First().ID_Meat;

                //Nana.Content = lst2.First().Name;
                //Meme.Content = lst2.First().ID_Dishes;
                //desdes.Text = lst2.First().Description;
                //pripri.Content = lst2.First().Price;
                //thr.Content = lst2.First().ID_Meat;
            }
            catch { }
        }

        private void Right_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (x + 2 <= App.en.Dishes.Count())
            {
                x += 2;
            }
            else
            {
                x = 1;
            }
            GetInfoProduct();
        }

        private void Left_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (x - 2 <= App.en.Dishes.Count())
            {
                x -= 2;
            }
            else
            {
                x = 1;
            }
            GetInfoProduct();
        }

        private void Or_Click(object sender, RoutedEventArgs e)
        {
            OrderDish order = new OrderDish();
            User user = new User();
            {
                order.Name = Convert.ToString(Nam.Content);
                order.Count = Convert.ToInt32(Pri.Content);
                order.ID_User = App.user.User.ID_User;
                order.ID_Dishes = Convert.ToInt32(Mee.Content);
            }
            App.en.OrderDish.Add(order);
            App.en.SaveChanges();
            MessageBox.Show("Ваш заказ принят");

        }

        private void OrOr_Click(object sender, RoutedEventArgs e)
        {
            OrderDish order = new OrderDish();
            User user = new User();
            {
                order.Name = Convert.ToString(Nana.Content);
                order.Count = Convert.ToInt32(pripri.Content);
                order.ID_User = App.user.User.ID_User;
                order.ID_Dishes = Convert.ToInt32(Meme.Content);
            }
            App.en.OrderDish.Add(order);
            App.en.SaveChanges();
            MessageBox.Show("Ваш заказ принят");
        }

        private void Govad_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
