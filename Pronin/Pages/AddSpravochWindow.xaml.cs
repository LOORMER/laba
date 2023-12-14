using Pronin.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для AddSpravochWindow.xaml
    /// </summary>
    public partial class AddSpravochWindow : Window
    {
        spravochnaia spr;
        bool chek;
        public AddSpravochWindow(spravochnaia c)
        {
            InitializeComponent();
            if (c == null)
            {
                c = new spravochnaia();
                chek = true;
            }
            else
                chek = false;
            DataContext = spr = c;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            SpravochWindow spravochWindow = new SpravochWindow();
            spravochWindow.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (chek)
            {
                connection.context.spravochnaia.Add(spr);
            }
            try
            {
                connection.context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            SpravochWindow spravochWindow = new SpravochWindow();
            spravochWindow.Show();
            this.Hide();

        }
    } 
}
  

