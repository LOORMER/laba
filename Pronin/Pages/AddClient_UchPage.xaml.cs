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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pronin.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddClient_UchPage.xaml
    /// </summary>
    public partial class AddClient_UchPage : Page
    {
       ucetnaya uch;
        bool checkNew;
        public AddClient_UchPage(ucetnaya c)
        {
            InitializeComponent();
            if (c == null)
            {
                c = new ucetnaya();
                checkNew = true;

            }
            else

                checkNew = false;
            DataContext = uch = c;
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            NAV.MainFrame.GoBack();
        }

        private void sohranitBut_Click(object sender, RoutedEventArgs e)
        {
            if (checkNew)
            {
                connection.context.ucetnaya.Add(uch);
            }
            try
            {
                connection.context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка");
            }
            connection.context.SaveChanges();
            NAV.MainFrame.GoBack();
        }
    }
}
