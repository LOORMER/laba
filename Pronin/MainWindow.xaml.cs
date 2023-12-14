using Pronin.AppData;
using Pronin.Pages;
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

namespace Pronin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void SprButton_Click(object sender, RoutedEventArgs e)
        {
            SprWindow sprWindow = new SprWindow();
            sprWindow.Show();
            this.Hide();
        }

        private void UchButton_Click(object sender, RoutedEventArgs e)
        {
            UchWindow uchWindow = new UchWindow();
            uchWindow.Show();
            this.Hide();
        }
    }
}
