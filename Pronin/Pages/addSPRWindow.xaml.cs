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
    /// Логика взаимодействия для addSPRWindow.xaml
    /// </summary>
    public partial class addSPRWindow : Window
    {
        public static bool ChekSpr(spravochnaia c)
        {
            if (string.IsNullOrEmpty(c.FIO) || !c.FIO.All(char.IsLetter))
                return false;
            return true;
        }
        public static bool ChekNullSpr(spravochnaia c)
        {
            if (string.IsNullOrEmpty(c.FIO) || !c.FIO.All(char.IsLetter))
                return false;
            return true;
        }
        public static bool ChekDigSpr(spravochnaia c)
        {
            if (string.IsNullOrEmpty(c.FIO) || !c.FIO.All(char.IsLetter))
                return false;
            return true;
        }

        spravochnaia sprav;
        bool chek;
        public addSPRWindow(spravochnaia c)
        {
            InitializeComponent();
            if (c == null)
            {
                c = new spravochnaia();
                chek = true;

            }
            else

                chek = false;
            DataContext = sprav = c;
        }

        private void Addbutn_Click(object sender, RoutedEventArgs e)
        {
            if (chek)
            {
                connection.context.spravochnaia.Add(sprav);
            }
            try
            {
                connection.context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка");
            }
            SprWindow sprWindow = new SprWindow();
            sprWindow.Show();
            this.Hide();
        }

        private void backbutn_Click(object sender, RoutedEventArgs e)
        {
            SprWindow sprWindow = new SprWindow();
            sprWindow.Show();
            this.Hide();
        }
    }
}
