using System;
using RestSharp;
using System.Collections.Generic;
using System.Text.Json;

namespace StarWars
{
    class Character
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    class Characters
    {
        public int count { get; set; }
        public List<Character> results { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hämta karacktärer från StarWarsAPI");

            // Hämmta ett skämt från api.chucknorris.io/jockes; 
            string url = "https://swapi.dev/api";
            var client = new RestClient(url);
            var request = new RestRequest("people", DataFormat.Json);
            var response = client.Get(request);

            // Se svaret
           Characters allaSkådespelare = JsonSerializer.Deserialize<Characters>(response.Content);

            if (allaSkådespelare.results != null)   // se ifall informationen kan hitas från hemsidan inan programet körs
            {
                foreach (var skådespelare in allaSkådespelare.results)
                {
                    Console.WriteLine(skådespelare.name);
                }
            }


        }
    }

}
