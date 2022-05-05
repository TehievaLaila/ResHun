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
    /// Логика взаимодействия для Rer.xaml
    /// </summary>
    public partial class Rer : Window
    {
        public Rer()
        {
            InitializeComponent();
        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            Review review = new Review();
            User user = new User();
            {
                review.Name = App.user.User.Name;
                review.Description = Convert.ToString(Desu.Text);
                review.ID_User = App.user.User.ID_User;
            }
            App.en.Review.Add(review);
            App.en.SaveChanges();
            MessageBox.Show("Спасибо за коментарий");
            this.Close();
        }

       
    }
}
