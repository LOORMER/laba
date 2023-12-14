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
    /// Логика взаимодействия для lb8.xaml
    /// </summary>
    public partial class lb8 : Window
    {
        public lb8()
        {
            InitializeComponent();
            UchDG.ItemsSource = connection.context.ucetnaya.ToList();
            UchDG.ItemsSource = connection.context.ucetnaya.Select(x => new
            {
                
                x.tabelniy_nomer,
                x.mouth,
                x.oklad,
                x.doplata,
                Sum_na_cheloveka = x.doplata + x.oklad
            }).ToList();
        }

        private void searchBTN_Click(object sender, RoutedEventArgs e)
        {
            var selectData1 = connection.context.ucetnaya.Select(x => new {
                Sum_na_cheloveka = x.doplata + x.oklad
            }).ToList();
            var temp = Int32.Parse(search.Text);
            var selectData2 = selectData1.Where(x => x.Sum_na_cheloveka <= temp);
            UchDG.ItemsSource = selectData2.ToList();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
