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
using System.Text.Json;

namespace BildFrånNasa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    class image1
    {
        public static BitmapImage Source { get; internal set; }
        public string image { get; set; }
        public string url { get; set; }
    }

    class images
    {
        public int count { get; set; }
        public List<image1> results { get; set; }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            image1.Source = new BitmapImage(new Uri("https://apod.nasa.gov/apod/image/2111/LLPegasi_HubbleLodge_960.jpg"));
            Console.WriteLine("Hämta bild från NasaAPI");

            // Hämmta ett skämt från api.chucknorris.io/jockes; 
            string url = "https://api.nasa.gov/planetary/apod";
            var client = new RestClient(url);
            var request = new RestRequest("image", DataFormat.);
            var response = client.Get(request);

            // Se svaret
           images dagensBild = JsonSerializer.Deserialize<images>(response.Content);

            if (dagensBild.results != null)   // se ifall informationen kan hitas från hemsidan inan programet körs
            {
                foreach (var bild in dagensBild.results)
                {
                    Console.WriteLine(bild.image);
                }
            }
        }
    }
}
