using Microsoft.Win32;
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
    /// Логика взаимодействия для ADMIN.xaml
    /// </summary>
    public partial class ADMIN : Page
    {
        ADMIN an;
        imageadd imgconvert = new imageadd();
        BikeEntities bik = new BikeEntities();
        public ADMIN(List<int> ids = null)
        {
            InitializeComponent();
            lbTodoList.ItemsSource = bik.Bike.ToList();
            
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog im = new OpenFileDialog();
            im.FilterIndex = 2;
            im.Filter = "jpg|*.jpg";
                
                    
                try
                {
                if (im.ShowDialog() == true)
                {
                    Bike bike = new Bike();
                    BikeEntities entities = new BikeEntities();
                    var src = new BitmapImage();
                    src.BeginInit();
                    src.UriSource = new Uri(@"" + im.FileName, UriKind.Relative);
                    src.CacheOption = BitmapCacheOption.OnLoad;
                    src.EndInit();
                    bike.Image = imgconvert.imageTobyteArray(src);
                    bike.Price = Convert.ToDecimal(txtprice.Text);
                    bike.Name = Convert.ToString(txtname.Text);
                    bike.Size = Convert.ToString(txtsize.Text);
                    bike.Material = Convert.ToString(txtmaterial.Text);
                    bike.Picture = Convert.ToInt32(txtpicture.Text);
                    bike.NumberBike = Convert.ToInt32(txtnumberbike.Text);
                    bike.Description = Convert.ToString(txtdescriptrion.Text);
                    bike.Type = Convert.ToString(txttype.Text);
                    entities.Bike.Add(bike);
                    entities.SaveChanges();
                    update();
                    System.Windows.MessageBox.Show("Отлично", "данные добавлены");
                }
                }
                catch
                {
                System.Windows.MessageBox.Show("Ошибка", "Проверьте что все поля заполнены");
                }
                
                


        }
        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Page1());

        }
        public void Delete(object sender, RoutedEventArgs e)
        {
            Bike del = lbTodoList.SelectedValue as Bike;
            bik.Bike.Remove(del);
            bik.SaveChanges();
            update();
        }
        private void update()
        {
            lbTodoList.ItemsSource = bik.Bike.ToList();
        }
        private void price_PreviewTextInput(object sender, TextCompositionEventArgs e) { char s = Convert.ToChar(e.Text); if (s < '0' || s > '9') e.Handled = true; }
        private void picture_PreviewTextInput(object sender, TextCompositionEventArgs e) { char s = Convert.ToChar(e.Text); if (s < '0' || s > '9') e.Handled = true; }
        private void number_PreviewTextInput(object sender, TextCompositionEventArgs e) { char s = Convert.ToChar(e.Text); if (s < '0' || s > '9') e.Handled = true; }

    }
}
