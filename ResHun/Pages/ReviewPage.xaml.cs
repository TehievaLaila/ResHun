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
    /// Логика взаимодействия для ReviewPage.xaml
    /// </summary>
    public partial class ReviewPage : Page
    {
        public int x = 1;
        public ReviewPage()
        {
            InitializeComponent();
            GetInfoReview();
        }

        private void Write_Click(object sender, RoutedEventArgs e)
        {
            Rer rer = new Rer();
            rer.Show();
        }
        private void GetInfoReview()
        {
            ResHun.db.Review rev = new db.Review();
            try
            {
                var lst1 = from cust in App.en.Review
                           where cust.ID_Review == x
                           select cust;
                var lst2 = from cust in App.en.Review
                           where cust.ID_Review == x + 1
                           select cust;

                NameNa.Content = lst1.First().Name;
                WriteReview.Content = lst1.First().Description;

                NameName.Content = lst2.First().Name;
                Destr.Content = lst2.First().Description;
            }
            catch { }
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            if (x + 2 <= App.en.Dishes.Count())
            {
                x += 2;
            }
            else
            {
                x = 1;
            }
            GetInfoReview();
        }

        private void Left_Click(object sender, RoutedEventArgs e)
        {
            if (x - 2 <= App.en.Dishes.Count())
            {
                x -= 2;
            }
            else
            {
                x = 1;
            }
            GetInfoReview();
        }
    }
}
