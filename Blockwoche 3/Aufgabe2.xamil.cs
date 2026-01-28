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
    /// Interaktionslogik für aufgabe2.xaml
    /// </summary>
    public partial class aufgabe2 : Page
    {
        public aufgabe2()
        {
            InitializeComponent();
        }

        private void OkButton(object sender, RoutedEventArgs e)
        {
           
                double a = double.Parse(kathete1Input.Text);
                double b = double.Parse(kathete2Input.Text);

                double c = Math.Sqrt( a * a + b * b );

                ergebnissTxt.Text = "Die beide Katheten entsprechen " + c + " cm";
        }

    }
}
