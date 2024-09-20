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
using System.Windows.Shapes;

namespace ClinicPro
{
    /// <summary>
    /// Логика взаимодействия для MessageBoxWW.xaml
    /// </summary>
    public partial class MessageBoxWW : Window
    {
        public bool isConfirmed { get; private set; } = false;

        public MessageBoxWW()
        {
            InitializeComponent();
        }

        private void YesButtonClick(object sender, RoutedEventArgs e)
        {
            isConfirmed = true;
            this.Close();
        }
        private void NoButtonClick(object sender, RoutedEventArgs e)
        {
            isConfirmed = false;
            this.Close();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}
