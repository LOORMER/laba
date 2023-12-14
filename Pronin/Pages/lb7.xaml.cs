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
    /// Логика взаимодействия для lb7.xaml
    /// </summary>
    public partial class lb7 : Window
    {
        public lb7()
        {
            InitializeComponent();
            var selectData1 = connection.context.ucetnaya.GroupBy(x => x.dataRogdenia).ToList();

            var selectData2 = connection.context.ucetnaya.Select(x => new
            {
                sum = x.tabelniy_nomer
            }).Count();

            UchDG.ItemsSource = selectData1;
            search.Text = selectData2.ToString();

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
