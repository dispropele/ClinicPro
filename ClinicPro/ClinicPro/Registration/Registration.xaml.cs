using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
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

namespace ClinicPro.Registration
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class Registration : UserControl
    {
        private bool isEnabledRegistrationButton = false;

        public Registration()
        {
            InitializeComponent();
        }

        private void BackMouseClick(object sender, RoutedEventArgs e)
        {
            RegistrationFrame.Navigate(new Login.Login());
        }

        private void FirstPassBox_GotFocus(object sender, RoutedEventArgs e)
        {
            FirstLabelPassBox.Content = null;
        }

        private void FirstPassBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstPassBoxPassword.Password))
            {
                FirstLabelPassBox.Content = "Введите пароль";
            }
        }
        private void ConfirmPassBox_GotFocus(object sender, RoutedEventArgs e)
        {
            ConfirmLabelPassBox.Content = null;
            TextPassNotEqual.Visibility = Visibility.Hidden;
        }
        private void ConfirmPassBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ConfirmPassBoxPassword.Password))
            {
                ConfirmLabelPassBox.Content = "Подтвердите пароль";
                isEnabledRegistrationButton = false;
            } else if (FirstPassBoxPassword.Password != ConfirmPassBoxPassword.Password)
            {
                TextPassNotEqual.Visibility = Visibility.Visible;
                isEnabledRegistrationButton = false;
            } else
            {
                isEnabledRegistrationButton = true;
            }
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox) sender;
            string defaultText = GetDefaultText(textBox.Name);

            if (textBox.Text == defaultText)
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.Black;
            }
        }
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox) sender;
            string defaultText = GetDefaultText(textBox.Name);

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = defaultText;
                textBox.Foreground = Brushes.Gray;
            }
        }

        private string GetDefaultText(string controlName)
        {
            switch (controlName)
            {
                case "TextBoxEmail": return "Почта";
                case "TextBoxFirstName": return "Имя";
                case "TextBoxLastName": return "Фамилия";
                case "FirstPassBoxPassword": return "Введите пароль";
                case "ConfirmPassBoxPassword": return "Подтвердите пароль";
                case "TextBoxPatr": return "Отчество (при наличии)";
                case "TextBoxPhone": return "Телефон";
                default: return "";
            }
        }
    }

    
}
