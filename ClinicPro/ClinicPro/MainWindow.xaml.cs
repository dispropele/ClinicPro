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
        private bool isHomeActive
                    ,isMedicineActive
                    ,isChatActive
                    ,isSettingsActive = false;

        public bool isFirstLogin = true;
        

        public MainWindow()
        {
            InitializeComponent();
            
            if (isFirstLogin)
            {
                MainFrame.Navigate(new Login.Login());
                isFirstLogin = false;
            }
            else
            {
                MainFrame.Navigate(new Doctor.Home.HomePage());
            }
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
            MessageBoxWW messageBoxWW = new MessageBoxWW();

            messageBoxWW.Owner = this;

            messageBoxWW.ShowDialog();

            if (messageBoxWW.isConfirmed)
            {
                this.Close();
            }
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}
