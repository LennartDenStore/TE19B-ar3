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

namespace Uppgift1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ClickKör(object sender, RoutedEventArgs e)
        {

            //  Läs in texten från förnstret
            //  Och omvandlar till versaler
            string text = rutaText.Text.ToUpper();

            //   Läs in nyckeln från förnstret
            string nyckelString = rutaNyckel.Text;

            //   är nyckel ett tal
            int nyckel = 0;
            if (!int.TryParse(nyckelString, out nyckel) || nyckel <= 0 || nyckel > 9)
            {
                
            //  Fel, skriver ut en varning till användren
                MessageBox.Show("Du måste mata in ett tal (1-9). Försök igen: ");
               
            }else{

            //  Nu kan iv kryptera
            string kryptadText = "";
            for (int i = 0; i < text.Length; i++)
            {
                char bokstav = text[i];
                //  Console.WriteLine($"Bokstaven på position {i} är {bokstav}");

                int ascii = (int)bokstav;
                //  Console.WriteLine($"{bokstav} är {ascii}");

                int kryptadAscii = ascii + nyckel;

                if (kryptadAscii >= 90)
                {
                    kryptadAscii -= 26;
                }

                char kryptadBokstav = (char)(kryptadAscii);
                //  Console.WriteLine($"{bokstav} blir {kryptadBokstav}");

                kryptadText += kryptadBokstav.ToString();
            }

            rutaKryptera.Text = kryptadText;

            }

            
        }
    }

}
