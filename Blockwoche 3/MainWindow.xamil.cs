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

namespace Blockwoche_3
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

        private void Button1(object sender, RoutedEventArgs e) //aufagebe 1
        {
            MainFrame.Navigate(new Aufgabe1());
        }

        private void Button2(object sender, RoutedEventArgs e) //aufagbe 2
        {
            MainFrame.Navigate(new aufgabe2());
        }

        private void Button3(object sender, RoutedEventArgs e)//aufgebe 3
        {
            MainFrame.Navigate(new aufagbe3());
        }

        private void Button4(object sender, RoutedEventArgs e)//aufgebe 3
        {
            MainFrame.Navigate(new aufagbe4());
        }


    }
}
