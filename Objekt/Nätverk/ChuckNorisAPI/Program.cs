using System;
using RestSharp;
using System.Text.Json;

namespace ChuckNorisAPI
{

    class Joke
    {
        public string icon_url { get; set; }
      //  public string id { get; set; }
        public string value { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuck Norris skämt");

            // Hämmta ett skämt från api.chucknorris.io/jockes; 
            string url = "https://api.chucknorris.io/jokes";
            var client = new RestClient(url);
            var request = new RestRequest("random", DataFormat.Json);
            var response = client.Get(request);

            // Skapa objektet som skall lagra json-data
            Joke skämtet = new Joke();

            // Stoppa in svaret i Joke-objektet
            skämtet = JsonSerializer.Deserialize<Joke>(response.Content);
            Console.WriteLine(skämtet.value);

            // Skriv ut JSON i en fil
         /*    File.WriteAllText("joke.json", response.Content);
            var options = new JsonSerializerOptions { WriteIndented = true };
            Console.WriteLine(JsonSerializer.Serialize(skämtet, options)); */
        }
    }
}
