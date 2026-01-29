using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Blochwoche_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1(object sender, RoutedEventArgs e) 
        {
            MainFrame.Navigate(new aufgabe1());
        }

        private void Button2(object sender, RoutedEventArgs e) 
        {
            MainFrame.Navigate(new aufgabe2());
        }

        private void Button3(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new aufgabe3());
        }

        private void Button4(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new aufgabe3());
        }


    }
}
