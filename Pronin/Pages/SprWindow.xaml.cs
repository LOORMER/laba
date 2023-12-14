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
    /// Логика взаимодействия для SprWindow.xaml
    /// </summary>
    public partial class SprWindow : Window
    {
        
       

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            addSPRWindow addSPRWindow = new addSPRWindow(null);
            addSPRWindow.Show();
            this.Hide();
        }

        private void delButton_Click(object sender, RoutedEventArgs e)
        {
            var delspravki = SprLV.SelectedItems.Cast<spravochnaia>().ToList();
            foreach (var delspravka in delspravki)
                if (connection.context.ucetnaya.Any(x => x.tabelniy_nomer == delspravka.tabel_nomer))
                {
                    MessageBox.Show("данные используются в другой таблице", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            if (MessageBox.Show($"Удалить {delspravki.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                connection.context.spravochnaia.RemoveRange(delspravki);
            try
            {
                connection.context.SaveChanges();
                SprLV.ItemsSource = connection.context.spravochnaia.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void refButton_Click(object sender, RoutedEventArgs e)
        {
            SprLV.ItemsSource = connection.context.spravochnaia.ToList();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            addSPRWindow addSPR = new addSPRWindow((sender as Button).DataContext as spravochnaia);
            addSPR.Show();
            this.Hide();

        }

        private void poiskButtn_Click(object sender, RoutedEventArgs e)
        {
            poiskSprWindow poiskSprWindow = new poiskSprWindow();
            poiskSprWindow.Show();
            this.Hide();
        }

        private void Oteh_Click(object sender, RoutedEventArgs e)
        {
            otchetWindow1 fjd = new otchetWindow1();
            fjd.Show();
            this.Hide();
         }
    }
}
