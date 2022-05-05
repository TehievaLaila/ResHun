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
    /// Логика взаимодействия для ReservationPage.xaml
    /// </summary>
    public partial class ReservationPage : Page
    {
        public ReservationPage()
        {
            InitializeComponent();
        }

        private void Bron_Click(object sender, RoutedEventArgs e)
        {
            Reservation reserv = new Reservation();
            {
                reserv.Name = Convert.ToString(name.Text);
                reserv.FirstName = Convert.ToString(sername.Text);
                reserv.Date = Convert.ToString(dat.Text);
                reserv.Time = Convert.ToString(tim.Text);
                reserv.NumberOrPersons = Convert.ToInt32(coun.Text);
                reserv.Event = Convert.ToString(son.Text);
                reserv.ID_User = App.user.User.ID_User;
            }
            App.en.Reservation.Add(reserv);
            App.en.SaveChanges();
            MessageBox.Show("Бронь успешно зафиксирована");
        }
    }
}
