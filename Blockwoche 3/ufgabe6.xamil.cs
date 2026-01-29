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
using System.Data; //damit ich databese table benutzen kann

namespace Blockwoche_3
{
    /// <summary>
    /// Interaktionslogik für aufgabe6.xaml
    /// </summary>
    public partial class aufgabe6 : Page
    {
        public aufgabe6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //wenn user clickt button dann...
        {
            DataTable table = new DataTable();

            table.Columns.Add("Jahr", typeof(int));
            table.Columns.Add("Inventar", typeof(int));

            double robben = 2600;

            for (int jahr = 1; jahr <= 10; jahr++)
            {
                robben = robben * 1.075;
                robben = robben - 250;

                table.Rows.Add(jahr, (int)Math.Round(robben));
            }

            robbenTabbele.ItemsSource = table.DefaultView;
        }
    }
}
