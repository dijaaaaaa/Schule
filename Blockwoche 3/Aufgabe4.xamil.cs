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
    /// Interaktionslogik für aufgabe4.xaml
    /// </summary>
    public partial class aufgabe4 : Page
    {
        public aufgabe4()
        {
            InitializeComponent();
        }

        private void doWhileButton_Click(object sender, RoutedEventArgs e)
        {
            int i = 1;
            string text = " ";

            do
            {
                text += "√" + i + "=" + Math.Sqrt(i);
                i++;
            }
            while (i <= 0);

            textBox.Text = text;

        }

        private void whileButton_Click(object sender, RoutedEventArgs e)
        {
            int i = 1;
            string text = " ";

            while (i <= 20)
            {
                text += "√" + i + "=" + Math.Sqrt(i);
                i++;
            }
            textBox.Text = text;
        }
        
    }
}
