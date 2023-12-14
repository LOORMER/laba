using Pronin.AppData;
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
    /// Логика взаимодействия для ADdUchWindow.xaml
    /// </summary>
    public partial class ADdUchWindow : Window
    {
        ucetnaya ucetnaya;
        bool chek;
        public ADdUchWindow(ucetnaya c)
        {

            InitializeComponent();
            if (c == null)
            {
                c = new ucetnaya();
                chek = true;

            }
            else

                chek = false;
            DataContext = ucetnaya = c;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (chek)
            {
                connection.context.ucetnaya.Add(ucetnaya);
            }
            try
            {
                connection.context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка");
            }
            UchWindow uchWindow = new UchWindow();
            uchWindow.Show();
            this.Hide();

        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            UchWindow uchWindow = new UchWindow();
            uchWindow.Show();
            this.Hide();
        }
    }
}
