using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ClinicPro
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pacient.Home.HomePage());
        }

        private void MedicinesButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pacient.Medicines.MedicinesPage());
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("Вы действительно хотите выйти из приложения?",
                                              "Подтверждение выхода",
                                              MessageBoxButton.YesNo,
                                              MessageBoxImage.Question);

            // Если пользователь выбрал "Yes", закрываем приложение
            if (result == MessageBoxResult.Yes)
            {
                System.Windows.Application.Current.Shutdown();
            }
            // Если "No", ничего не делаем, диалоговое окно просто закрывается
        }
    }
}
