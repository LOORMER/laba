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
    /// Логика взаимодействия для Spravochnaya_Page.xaml
    /// </summary>
    public partial class Spravochnaya_Page : Page
    {
        public Spravochnaya_Page()
        {
            InitializeComponent();
            SpravocnayaLV.ItemsSource = connection.context.spravochnaia.ToList();
        }

        private void SpravocnayaLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void addbutton_Click(object sender, RoutedEventArgs e)
        {
            NAV.MainFrame.Navigate (new AddClientPage(null));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SpravocnayaLV.ItemsSource = connection.context.spravochnaia.ToList();
        }
    }
}
