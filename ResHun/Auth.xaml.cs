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
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }
        public static db.Entities dba = new db.Entities();

        public static db.Authorization Auto;
        
        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            foreach (var user in dba.Authorization)
            {
                if (user.login == log.Text.Trim())
                {
                    if (Pass.Password == "" || log.Text == "")
                    {
                        MessageBox.Show("Enter the data!");

                    }

                    if (user.password == Pass.Password.Trim() && user.ID_Role == 2)
                    {
                        MessageBox.Show($"Hello {user.login}");
                        Hun hun = new Hun();
                        hun.Show();
                        this.Close();
                        App.user = user;
                    }

                    if (user.password == Pass.Password.Trim() && user.ID_Role == 1)
                    {
                        MessageBox.Show($"Hello Director{user.login}");

                        AdminPanel admin = new AdminPanel();
                        admin.Show();
                        this.Close();
                        App.user = user;
                    }

                }

            }
        }

        private async void Reg_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text == "" || phone.Text == "" || login1.Text == "" || password.Password == "")
            {
                MessageBox.Show("Enter the data!");
            }
            else
            {
                string[] ss = name.Text.Split(' ');
                User users = new User();
                {
                    users.Name = ss[1];
                    users.FirstName = ss[0];
                    users.LastName = ss[2];
                    users.Phone = phone.Text;
                }
                dba.User.Add(users);
                dba.SaveChanges();
                Authorization autoriz = new Authorization();
                {
                    autoriz.login = login1.Text;
                    autoriz.password = password.Password;
                    autoriz.ID_Role = 2;
                    autoriz.ID_User = users.ID_User;
                }
                dba.Authorization.Add(autoriz);
                dba.SaveChanges();
                MessageBox.Show("Cool!");

                Hun hun = new Hun();
                hun.Show();
                this.Close();
            }
        }
    }
}
