using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
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
    /// Interaktionslogik für Aufgabe1.xaml
    /// </summary>
    public partial class Aufgabe1 : Page
    {

        public Aufgabe1()
        {
            InitializeComponent();
        }

        private void OkButton(object sender, RoutedEventArgs e)
        {
            //rechenungen
            double netto = double.Parse(nettoBetragInput.Text); //input nehmen 
            double mstw = 0.19;
            double brutto = netto * mstw;
            double gehalt = netto - brutto;

            //text der in der textbox raus kommt 
            txtOutput.Text = "Mwst: " + mstw + " % " + " Brutto: " + brutto + " Euro";
            txtgehalt.Text = "Ihr Brutto Gehalt ist " + gehalt + " Euro";
        }
    }
}
