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
    /// Логика взаимодействия для Uchetnaya_Page.xaml
    /// </summary>
    public partial class Uchetnaya_Page : Page
    {
        public Uchetnaya_Page()
        {
            InitializeComponent();
            uchetnayaGrid.ItemsSource = connection.context.ucetnaya.ToList();
        }

        private void UchetnayaLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            var del = uchetnayaGrid.SelectedItems.Cast<ucetnaya>().ToList();
            
                
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            NAV.MainFrame.Navigate(new AddClient_UchPage(null));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void obnovbtn_Click(object sender, RoutedEventArgs e)
        {
            uchetnayaGrid.ItemsSource = connection.context.ucetnaya.ToList();
        }

        private void Editbutn_Click(object sender, RoutedEventArgs e)
        {
            NAV.MainFrame.Navigate(new AddClient_UchPage((sender as Button).DataContext as ucetnaya));
        }
    }
}
