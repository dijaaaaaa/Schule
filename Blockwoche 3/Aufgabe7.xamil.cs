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
    /// Interaktionslogik für aufagbe7.xaml
    /// </summary>
    public partial class aufagbe7 : Page
    {
        public aufagbe7()
        {
            InitializeComponent();
        }

        private void rechenenButton(object sender, RoutedEventArgs e)
        {
            double zinsen = double.Parse(txtZinsen.Text);
            double kapital = double.Parse(txtKapital.Text);
            int jahre = int.Parse(txtJahre.Text);

            string text = " ";

            for (int i = 1; i<= jahre; i++)
            {
                kapital = kapital + kapital + zinsen;
                txtOutput.Text = "Jahr: " + i + "Kapital: " + kapital + " Euro"; 
            }



        }
    }
}
