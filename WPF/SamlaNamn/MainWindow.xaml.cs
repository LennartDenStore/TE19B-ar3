using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SamlaNamn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static List<string> namnlista = new List<string>();

        static int antal = 0;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void ClickLäggTill(object sender, RoutedEventArgs e)
        {
            // Läs av namnet
            string namn = rutaNamn.Text;

            // Om namnet ej tomt
            if (namn != "")
            {
                rutaNamn.Text = "";
                rutaLista.Text += namn + "\n";
                rutaFel.Text = "Inga fel...";
                namnlista.Add(namn);
            }
            else
            {
                rutaFel.Text = "Inget namn matades in, försök igen!";
            }
        }
        private void ClickSpara(object sender, RoutedEventArgs e)
        {
            File.WriteAllLines(@"namnlista.txt", namnlista);
            rutaFel.Text = "Namnen sparade i namnlista.txt";
        }
    }
}
