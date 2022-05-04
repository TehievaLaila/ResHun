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
    /// Логика взаимодействия для SotrPage.xaml
    /// </summary>
    public partial class SotrPage : Page
    {
        public static Entities db = new Entities();

        public SotrPage()

        {
            InitializeComponent();
            Empl();
        }
        private void Empl()
        {
            var qadr =
                from Employee in db.Employe
                select new
                {
                    ID = Employee.ID_Employe,
                    Surname = Employee.FirstName,
                    Name = Employee.Name,
                    Patronymic = Employee.LastName,
                    Phone = Employee.Phone
                };
            Hum.ItemsSource = qadr.ToList();
        }
    }
}
