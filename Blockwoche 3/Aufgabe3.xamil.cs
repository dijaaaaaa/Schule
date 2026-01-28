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
using System.Windows.Shapes;

namespace Blockwoche_3
{
    /// <summary>
    /// Interaktionslogik für aufagbe3.xaml
    /// </summary>
    public partial class aufagbe3 : Window
    {
        public aufagbe3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double warewert = double.Parse(userInput.Text);
            double rabbat = warewert * 0.10;
            double steuer = warewert * 0.20;

            if (warewert > 1000)
            {
               
                double ergebniss = warewert - rabbat + steuer;

                ergebnissTxt.Text = "Der letzter Preis Ihres Produktes entspricht: " + ergebniss + " Euro";
            }
            else
            {


                double ergebniss2 = warewert + steuer;
                ergebnissTxt.Text = "Der letzter Preis Ihres Produkters entspricht: " + ergebniss2 + " Euro";
            }
        }
    }
}
