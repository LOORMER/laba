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

namespace Pronin.Pages
{
    /// <summary>
    /// Логика взаимодействия для zadania11.xaml
    /// </summary>
    public partial class zadania11 : Window
    {
        public zadania11()
        {
            InitializeComponent();
        }

        private void lb7_Click(object sender, RoutedEventArgs e)
        {
            lb7 lb7da = new lb7();
            lb7da.Show();
            this.Hide();
         }

        private void lb8_Click(object sender, RoutedEventArgs e)
        {
            lb8 lb8da = new lb8();
            lb8da.Show();
            this.Hide();
        }
    }
}
