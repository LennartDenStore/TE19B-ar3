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

namespace Uppgift6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public float summa = 0;
        public int antaClick = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void knappAdderaClick(object sender, RoutedEventArgs e)
        {
            //float tal1 = float.Parse(tal1Ruta.Text);
            // Försöker konvertera tal1 till en flat
            float tal;
            if (!float.TryParse(talRuta.Text, out tal))
            {
                MessageBox.Show("Fel inmatning i tal1.\n Formatet Tex 2,5");

            }
            else
            {
                antaClick++;

                summaRuta.Text = $"{summa} + {tal} = {summa + tal}";

                // spara summa till nästa gån ett tal anges
                summa = summa + tal;

                // Medelvärde
                medelRuta.Text = $"{summa} / {antaClick} = {summa / antaClick}";
            }
            // tömer Ange tal rutan
            talRuta.Text = "";
        }
    }
}
