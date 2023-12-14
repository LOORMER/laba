using Pronin.AppData;
using System;
using Pronin.Pages;
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
    /// Логика взаимодействия для poiskUchWindow.xaml
    /// </summary>
    public partial class poiskUchWindow : Window
    {
        public poiskUchWindow()
        {
            InitializeComponent();
            UchDG.ItemsSource = connection.context.ucetnaya.ToList();

        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            UchWindow uchWindow = new UchWindow();
            uchWindow.Show();
            this.Hide();
        }

        private void Searchtab_TextChanged(object sender, TextChangedEventArgs e)
        {
            UchDG.ItemsSource = connection.context.ucetnaya.Where(x => x.tabelniy_nomer.ToString().StartsWith(Searchtab.Text)).ToList();
            
        }

        private void Searchmoth_TextChanged(object sender, TextChangedEventArgs e)
        {
            UchDG.ItemsSource = connection.context.ucetnaya.Where(x => x.mouth.ToString().StartsWith(Searchmoth.Text)).ToList();
        }

        private void searchprosent_TextChanged(object sender, TextChangedEventArgs e)
        {
            UchDG.ItemsSource = connection.context.ucetnaya.Where(x => x.doplata.ToString().StartsWith(searchprosent.Text)).ToList();
        }

       
    }
}
