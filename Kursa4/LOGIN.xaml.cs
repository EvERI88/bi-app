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
    /// Логика взаимодействия для LOGIN.xaml
    /// </summary>
    public partial class LOGIN : Page
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        private void avt(object sender, RoutedEventArgs e)
        {

            try
            {
                bool authStatus = false;

                if ((txtlogin.Text == "admin") && (txtpassword.Text == "admin"))
                {
                    System.Windows.MessageBox.Show("Вы вошли");
                    frame.Navigate(new ADMIN());
                }


                if (authStatus == true)
                {
                    
                    frame.Navigate(new ADMIN());
                }
                
            }

            catch
            {
                System.Windows.MessageBox.Show("Ошибка", "Попробуйте еще раз");

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Page1());
        }
        private void txtlogin_PreviewTextInput(object sender, TextCompositionEventArgs e) { char s = Convert.ToChar(e.Text); if (s < 'A' || s > 'z') e.Handled = true; }
        private void txtpassword_PreviewTextInput(object sender, TextCompositionEventArgs e) { char s = Convert.ToChar(e.Text); if (s < 'A' || s > 'z') e.Handled = true; }
    }
}

    

