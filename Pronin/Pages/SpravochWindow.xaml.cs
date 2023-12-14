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
    /// Логика взаимодействия для SpravochWindow.xaml
    /// </summary>
    public partial class SpravochWindow : Window
    {
        public SpravochWindow()
        {
            InitializeComponent();
            SpravocnayaLV.ItemsSource = connection.context.spravochnaia.ToList();
        }

        private void addbutton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
