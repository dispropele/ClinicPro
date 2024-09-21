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

namespace ClinicPro
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxWW messageBoxWW = new MessageBoxWW();

            // Для UserControl нужно использовать Window.GetWindow(), чтобы получить родительское окно.
            Window parentWindow = Window.GetWindow(this);
            messageBoxWW.Owner = parentWindow;

            messageBoxWW.ShowDialog();

            if (messageBoxWW.isConfirmed)
            {
                parentWindow.Close();
            }
        }
    }
}
