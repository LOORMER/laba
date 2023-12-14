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
    /// Логика взаимодействия для poiskSprWindow.xaml
    /// </summary>
    public partial class poiskSprWindow : Window
    {
        public poiskSprWindow()
        {
            InitializeComponent();
            SprLV.ItemsSource = connection.context.spravochnaia.ToList();
        }

        private void searchdata_TextChanged(object sender, TextChangedEventArgs e)
        {
            SprLV.ItemsSource = connection.context.spravochnaia.Where(x => x.datarojdenia.ToString().StartsWith(searchdata.Text)).ToList();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
