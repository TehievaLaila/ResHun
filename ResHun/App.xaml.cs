using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ResHun.db;

namespace ResHun
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Entities en = new Entities();
        public static Authorization user = new Authorization();
        public static Dishes dish = new Dishes();
    }
}
