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
    /// Interaktionslogik für aufgabe12.xaml
    /// </summary>
    public partial class aufgabe12 : Page
    {
        public aufgabe12()
        {
            InitializeComponent();
        }

     

        private void Button12P(object sender, RoutedEventArgs e)
        {
            Aufagbe12Frame.Navigate(new aufagbe11());
        }

        private void Button12N(object sender, RoutedEventArgs e)
        {
            Aufagbe12Frame.Navigate(new MainWindow());
        }

        private void BigButton(object sender, RoutedEventArgs e)
        {
            string text = "";

            for (char buchstabe = 'A'; buchstabe <= 'H'; buchstabe++)
            {
                for (int zahl = 1; zahl <= 8; zahl++)
                {
                    text += buchstabe + zahl + " ";
                }
                text += "\n";
            }

            txtOutput.Text = text;
        }
    }
}


