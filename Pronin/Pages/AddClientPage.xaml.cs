using Pronin.AppData;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Логика взаимодействия для AddClientPage.xaml
    /// </summary>
    public partial class AddClientPage : Page
    {
        spravochnaia sp;
       public bool chechNew;
        public AddClientPage(spravochnaia c)
        {
            InitializeComponent();
            if (c == null)
            {
               c = new spravochnaia();
                chechNew = true;
                
            }
            else
            
                chechNew = false;
                DataContext = sp = c;
            
           
            
            
        }

        private void Savebutn_Click(object sender, RoutedEventArgs e)
        {
            if(chechNew)
            {
                connection.context.spravochnaia.Add(sp);
            }
            try
            {
                connection.context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка");
            }
            connection.context.SaveChanges();
            NAV.MainFrame.GoBack();
        }

        private void backbutn_Click(object sender, RoutedEventArgs e)
        {
            NAV.MainFrame.GoBack();
        }
    }
}
