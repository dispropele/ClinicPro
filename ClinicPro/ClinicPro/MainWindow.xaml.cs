using System;
using System.Collections.Generic;
using System.IO;
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
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ClinicPro
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserSession userSession;
        //подключение БД
        private string connectionString = "Data Source=DISPROPELE\\CLINICSQLSERVER;Initial Catalog=ClinicProDB;Integrated Security = True";
        
        /*
        private bool isHomeActive
                    ,isMedicineActive
                    ,isChatActive
                    ,isSettingsActive = false;

        public bool isFirstLogin = true; */
        

        public MainWindow()
        {
            InitializeComponent();
            
            userSession = new UserSession();
            userSession.LoadState();

            if (userSession.IsLoggedIn)
            {
                MainFrame.Navigate(new Pacient.Home.HomePage());
            }
            else
            {
                MainFrame.Navigate(new Login.Login());
            }
        }

        private void OnLogin()
        {
            // Логика входа
            userSession.SaveState(true);
        }

        private void OnLogout()
        {
            // Логика выхода
            userSession.SaveState(false);
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

    class UserSession
    {
        private const string StateFilePath = "userState.txt";

        public bool IsLoggedIn { get; private set; }

        public void LoadState()
        {
            if (File.Exists(StateFilePath))
            {
                var state = File.ReadAllText(StateFilePath);
                IsLoggedIn = bool.Parse(state);
            }
        }

        public void SaveState(bool isLoggedIn)
        {
            IsLoggedIn = isLoggedIn;
            File.WriteAllText(StateFilePath, IsLoggedIn.ToString());
        }
    }
}
