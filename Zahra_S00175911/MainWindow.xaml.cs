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
using static Zahra_S00175911.Phone;

namespace Zahra_S00175911
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
                var query = from p in db.phones
                            select p.Name;

            var teams = query.ToList();

            lbPhones.ItemsSource = teams;

        }

        private void lbPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Phone chosen 
            string selectedPhone = (string)lbPhones.SelectedItem;

            //checking null data 
            if (selectedPhone != null)
            {
                var query = from p in db.phones
                            where p.Name == selectedPhone
                            select new
                            {
                                p.Price
                            };

                tbPrice.Text = query.ToString();
             
                //display selected phone image    
              //  imgPhone.Source = new BitmapImage(new Uri($"/images/{selectedPhone.Phone_Image}", UriKind.Relative));


            }
        }
    }
}
