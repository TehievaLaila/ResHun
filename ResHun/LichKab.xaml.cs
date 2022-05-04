using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace ResHun
{
    /// <summary>
    /// Логика взаимодействия для LichKab.xaml
    /// </summary>
    public partial class LichKab : Window
    {
        byte[] photo;
        public LichKab()
        {
            InitializeComponent();
            GetInfoUsers();
        }

        private void Clo_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            //var us = App.en.User.Where(x => x.ID_User == App.user.ID_User).FirstOrDefault();
            //us.Image = photo;
            //App.en.SaveChanges();
        }

        private void GetInfoUsers()
        {
            FIO.Text = App.user.User.FirstName + " " + App.user.User.Name + " " + App.user.User.LastName;
            pho.Text = App.user.login;
            Pas.Text = App.user.password;
            if (App.user.User.Image != null)
            {
                MemoryStream ms = new MemoryStream(App.user.User.Image);
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = ms;
                bitmapImage.EndInit();
                NewImg.Source = bitmapImage;
            }
        }

        private void redact_Click(object sender, RoutedEventArgs e)
        {
            var gg = App.en.User.Attach(App.en.User.FirstOrDefault(c => c.ID_User == App.user.ID_User));
            OpenFileDialog ofdImg = new OpenFileDialog();
            ofdImg.Filter = "Image files|*.bmp;*.jpg;*.png;*.tif|All files|*.*";
            ofdImg.FilterIndex = 1;
            if (ofdImg.ShowDialog() == true)
            {
                BitmapImage img = new BitmapImage();
                img.BeginInit();
                img.UriSource = new Uri(ofdImg.FileName);
                gg.Image = File.ReadAllBytes(ofdImg.FileName);
                img.EndInit();
                photo = File.ReadAllBytes(ofdImg.FileName);
                NewImg.Source = ByteArrayToImage(photo);
                App.en.SaveChanges();

            }
        }

        public BitmapSource ByteArrayToImage(byte[] buffer)
        {
            using (var stream = new MemoryStream(buffer))
            {
                return BitmapFrame.Create(stream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
            }
        }
    }
}

