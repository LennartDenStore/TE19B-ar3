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

namespace Uppgift3
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

        private void knappPlusClick(Object sender, RoutedEventArgs e)
        {
            //  Töm resultat rutan
            resultatRuta.Text = $"";

            //float tal1 = float.Parse(tal1Ruta.Text);
            // Försöker konvertera tal1 till en flat
            float tal1;
            if (!float.TryParse(tal1Ruta.Text, out tal1))
            {
                MessageBox.Show("Fel inmatning i tal1.\n Formatet Tex 2,5");

            }

            float tal2;
            if (!float.TryParse(tal2Ruta.Text, out tal2))
            {
                MessageBox.Show("Fel inmatning i tal2.\n Formatet Tex 2,5");
            }

            //  Kollar ifal tal1 och tal2 är störe än eller mindre än 0 räknas ekvationen ut 
            //  om tal1 eller tal2 är 0 skrivs inget ut i rutan
            if (tal1 != 0 && tal2 != 0)
            {
                resultatRuta.Text = $"{tal1} + {tal2} = {tal1 + tal2}";
            }
            else
            {
                resultatRuta.Text = $"";
            }

        }

        private void knappMinusClick(Object sender, RoutedEventArgs e)
        {
            float tal1;
            if (!float.TryParse(tal1Ruta.Text, out tal1))
            {
                MessageBox.Show("Fel inmatning i tal1.\n Formatet Tex 2,5");

            }

            float tal2;
            if (!float.TryParse(tal2Ruta.Text, out tal2))
            {
                MessageBox.Show("Fel inmatning i tal2.\n Formatet Tex 2,5");

            }
            if (tal1 != 0 && tal2 != 0)
            {
                resultatRuta.Text = $"{tal1} - {tal2} = {tal1 - tal2}";
            }
            else
            {
                resultatRuta.Text = $"";
            }
        }

        private void knappGångerClick(Object sender, RoutedEventArgs e)
        {
            float tal1;
            if (!float.TryParse(tal1Ruta.Text, out tal1))
            {
                MessageBox.Show("Fel inmatning i tal1.\n Formatet Tex 2,5");

            }

            float tal2;
            if (!float.TryParse(tal2Ruta.Text, out tal2))
            {
                MessageBox.Show("Fel inmatning i tal2.\n Formatet Tex 2,5");

            }

            if (tal1 != 0 && tal2 != 0)
            {
                resultatRuta.Text = $"{tal1} * {tal2} = {tal1 * tal2}";
            }
            else
            {
                resultatRuta.Text = $"";
            }
        }

        private void knappDivideraClick(Object sender, RoutedEventArgs e)
        {
            float tal1;
            if (!float.TryParse(tal1Ruta.Text, out tal1))
            {
                MessageBox.Show("Fel inmatning i tal1.\n Formatet Tex 2,5");

            }

            float tal2;
            if (!float.TryParse(tal2Ruta.Text, out tal2))
            {
                MessageBox.Show("Fel inmatning i tal2.\n Formatet Tex 2,5");

            }

            if (tal1 != 0 && tal2 != 0)
            {
                resultatRuta.Text = $"{tal1} / {tal2} = {tal1 / tal2}";
            }
            else
            {
                resultatRuta.Text = $"";
            }
        }
    }
}

