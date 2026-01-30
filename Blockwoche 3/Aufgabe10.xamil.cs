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
    /// Interaktionslogik für aufgabe10.xaml
    /// </summary>
    public partial class aufgabe10 : Page
    {
        public aufgabe10()
        {
            InitializeComponent();
        }

        private void OkayButton(object sender, RoutedEventArgs e)
        {
            double l = double.Parse(lange.Text);
            double b = double.Parse(breite.Text);
            double h = double.Parse(hohe.Text);
            double ergebniss = l * b * h;

            ergebnissTxt.Text = "Ihr Ergebniss ist: " + ergebniss;
        }

        private void Button10P(object sender, RoutedEventArgs e)
        {
            Aufagbe10Frame.Navigate(new aufgabe9()); 
        }

        private void Button10N(object sender, RoutedEventArgs e)
        {
            Aufagbe10Frame.Navigate(new aufagbe11()); 
        }
    }
}
