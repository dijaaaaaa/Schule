using System;
using System.Collections.Generic;
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
    /// Interaktionslogik für aufgabe9.xaml
    /// </summary>
    public partial class aufgabe9 : Page
    {
        public aufgabe9()
        {
            InitializeComponent();
        }

        private void Button9P(object sender, RoutedEventArgs e)
        {
            Aufagbe8Frame.Navigate(new aufgabe8()); //leads to last page this case page 1
        }

        private void Button9N(object sender, RoutedEventArgs e)
        {
            Aufagbe8Frame.Navigate(new aufgabe10()); //leads to last page this case page 1
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
                double l = double.Parse(lange.Text);
                double b = double.Parse(breite.Text);
                double h = double.Parse(hohe.Text);
                double ergebniss = 2 * (l * b + l * h + b * h);

                ergebnissTxt.Text = "Ihr Ergebniss ist: " + ergebniss ;  

        }
    }
}
