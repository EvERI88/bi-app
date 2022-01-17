using System;
using System.Collections.Generic;
using System.Data;
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

namespace Kursa4
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        BikeEntities bik = new BikeEntities();
        public List<int> idOrd = new List<int>();
        public List<int> idOrd1 = new List<int>();
        Izbrannoe iz;
        ADMIN an;
        
        bool check = false;
        public Page1()
        {
            InitializeComponent();
            lbTodoList.ItemsSource = bik.Bike.ToList();
            
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            iz = new Izbrannoe(idOrd.Distinct().ToList());
            frame.Navigate(iz);
        }

        private void button_save_Click(object sender, RoutedEventArgs e) 
        {


        }
        private void ShowHideDetails(object sender, RoutedEventArgs e)
        {
            int id = int.Parse((sender as Button).Tag.ToString());
            idOrd.Add(id);
            if (check)
                iz.AddBasketAsync(id);
            MessageBox.Show("Модель добавлена в избранное");
        }

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int id = int.Parse((sender as Button).Tag.ToString());
            idOrd.Add(id);
            if (check)
                iz.AddBasketAsync(id);
        }

        public void Button_Click4(object sender, RoutedEventArgs e)
        {
            an = new ADMIN(idOrd1.Distinct().ToList());
            frame.Navigate(new LOGIN());
        }
    }
    public partial class Bike

    {
        public object Photo
        {
            get
            {
                if (Image == null)
                {
                    return @"https://static.wikia.nocookie.net/houseki-no-kuni/images/3/3b/Missingimage.png/revision/latest?cb=20190328111547&path-prefix=ru";
                }
                else
                { return Image; }
            }
        }
    }
}
