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
    /// Логика взаимодействия для UchWindow.xaml
    /// </summary>
    public partial class UchWindow : Window
    {
        public UchWindow()
        {
            InitializeComponent();
            UchDG.ItemsSource = connection.context.ucetnaya.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            ADdUchWindow ddUchWindow = new ADdUchWindow(null);
            ddUchWindow.Show();
            this.Hide();
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            var deluhceti = UchDG.SelectedItems.Cast<ucetnaya>().ToList();
            foreach (var deluchet in deluhceti)
                if (connection.context.spravochnaia.Any(x => x.tabel_nomer == deluchet.tabelniy_nomer))
                {
                    MessageBox.Show("данные используются в другой таблице", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            if (MessageBox.Show($"Удалить {deluhceti.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                connection.context.ucetnaya.RemoveRange(deluhceti);
            try
            {
                connection.context.SaveChanges();
                UchDG.ItemsSource = connection.context.ucetnaya.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Editbutn_Click(object sender, RoutedEventArgs e)
        {
            ADdUchWindow aDdUchWindow = new ADdUchWindow((sender as Button).DataContext as ucetnaya);
            aDdUchWindow.Show();
            this.Hide();
        }

        private void obnovbtn_Click(object sender, RoutedEventArgs e)
        {
            zadania11 zd11 = new zadania11();
            zd11.Show();
            this.Hide();


        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void poiskButn_Click(object sender, RoutedEventArgs e)
        {
            poiskUchWindow poiskUchWindow = new poiskUchWindow();
            poiskUchWindow.Show();
            this.Hide();
        }

        private void otcherBTTn_Click(RoutedEventArgs e)
        {

        }

        private void otcherBTTn_Click(object sender, RoutedEventArgs e)
        {
            otchetWindow1 otch = new otchetWindow1();
            otch.Show();
            this.Hide();
        }

        private void vichBttn_Click(object sender, RoutedEventArgs e)
        {
            UchDG.ItemsSource = connection.context.ucetnaya.Select(x => new
            {
                x.nomer_zapisi,
                x.tabelniy_nomer,
                x.mouth,
                x.oklad,

                prosent_doblat = x.doplata + x.oklad
            }).ToList();
        }

        private void vichBTTn_Click_1(object sender, RoutedEventArgs e)
        {
            sumuch fje = new sumuch();
            fje.Show();
            this.Hide();
        }
    }
}
