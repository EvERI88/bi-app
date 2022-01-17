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

namespace Kursa4
{

    /// <summary>
    /// Логика взаимодействия для Izbrannoe.xaml
    /// </summary>
    public partial class Izbrannoe : Page
    {
        BikeEntities bik = new BikeEntities();
        BikeEntities Bike = new BikeEntities();
        bool check = false;
        MainWindow mainWindow = new MainWindow();
        Izbrannoe iz;
        public Izbrannoe(List<int> ids = null)
        {

            InitializeComponent();
            foreach (int id in ids)
            {
                itc.Items.Add(Bike.Bike.Where(x => x.id == id).First());
            }
            if (itc.Items.Count == 0)
            {
                MessageBox.Show("Список пуст, добавьте в него эллементы");
                check = true;


            }
        }
        private void btn(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Page1());
        }
        public void AddBasketAsync(int id)
        {
            frame.Navigate(iz);
            //itc.Items.Add(BikeEntities.Bike.Where(x => x.id == id).First());
        }

        public void Descrip(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int id = int.Parse((sender as Button).Tag.ToString());
        }

        private void itc_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }




        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Bike itcc = itc.SelectedValue as Bike;
            itc.Items.Remove(itcc);
            Bike.SaveChanges();
            UpdateDefaultStyle();
        }
        private void update()
        {
            itc.ItemsSource = Bike.Bike.ToList();
        }
    }
}
