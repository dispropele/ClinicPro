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

namespace ClinicPro.Login
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        private bool isVisiblePassword = false;

        public Login()
        {
            InitializeComponent();
        }

        private void TextBoxLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TextBoxLogin.Text == "Ваш логин")
            {
                TextBoxLogin.Text = "";
                TextBoxLogin.Foreground = Brushes.Black;
            }
        }
        private void TextBoxLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxLogin.Text))
            {
                TextBoxLogin.Text = "Ваш логин";
                TextBoxLogin.Foreground = Brushes.Gray;
            }
        }

        private void PassBoxLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            LabelPassBox.Content = null;
        }

        private void PassBoxLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PassBoxPassword.Password))
            {
                LabelPassBox.Content = "Пароль";
            }
        }

        private void PassBoxPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            TextBoxPassword.Text = PassBoxPassword.Password;
        }

        private void PassBoxEyeClick(object sender, RoutedEventArgs e)
        {
            if (isVisiblePassword)
            {
                PassBoxPassword.Visibility = Visibility.Visible;
                TextBoxPassword.Visibility = Visibility.Collapsed;
                PassBoxEyeImg.Source = new BitmapImage(new Uri("/imgs/Eye off.png", UriKind.Relative));
            }
            else
            {
                PassBoxPassword.Visibility = Visibility.Collapsed;
                TextBoxPassword.Visibility = Visibility.Visible;
                PassBoxEyeImg.Source = new BitmapImage(new Uri("/imgs/Eye.png", UriKind.Relative));
            }
            isVisiblePassword = !isVisiblePassword;
        }

        private void RegistrationMoveClick(object sender, RoutedEventArgs e)
        {
            LoginFrame.Navigate(new Registration.Registration());
        }
    }
}
