using System;
using System.Collections.Generic;
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

namespace Labb3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string[] rader = new string[194];

        public MainWindow()
        {
            InitializeComponent();

            // Läs in alla rader från textfilen countries.csv
        rader = File.ReadAllLines("Resurser/countries.csv");
        }
        
        private void ClickSök(object sender, RoutedEventArgs e)
        {
            int antal = 1;
        string sökterm = "";

            // Läs in sökterm
        sökterm = rutaSökterm.Text;
   
            // Skriv ut matchande land och dess landskod
        rutaResultat.Text += $"{antal} {land}: {landskod}";
 
            // Summering
        rutaStatus.Text = $"Hittade {antal} länder.";
        }
    }
}
