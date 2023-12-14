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
    /// Логика взаимодействия для sumuch.xaml
    /// </summary>
    public partial class sumuch : Window
    {
        public sumuch()
        {
            InitializeComponent();
            uchDATAGRID.ItemsSource = connection.context.ucetnaya.Select(x => new
            {
                x.nomer_zapisi,
                x.tabelniy_nomer,
                x.mouth,
                x.oklad,
                x.doplata,
                Sum_na_cheloveka = x.oklad + (x.doplata* x.oklad / 100),
                Sum_doplat = x.doplata * x.oklad / 100
            }).ToList();
        }

        private void vichisl_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void SEREGA_TextChanged(object sender, TextChangedEventArgs e)
        {
            uchDATAGRID.ItemsSource = connection.context.ucetnaya.Where(x => x.mouth.ToLower().Contains(SEREGA.Text.ToLower())).ToList();

        }

        private void start_SEREGA_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void end_SEREGA_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SeregaSearch_Click(object sender, RoutedEventArgs e)
        {
            int start = Convert.ToInt32(start_SEREGA.Text);
            int end = Convert.ToInt32(end_SEREGA.Text);
            uchDATAGRID.ItemsSource = connection.context.ucetnaya.Where(x=>x.oklad >= start && x.oklad <= end).ToList();

        }
    }
}
