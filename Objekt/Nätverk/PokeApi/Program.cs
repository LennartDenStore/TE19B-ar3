using System;
using RestSharp;
using System.Text.Json;
using System.Collections.Generic;

namespace PokeApi
{
    class Pokemon
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    class Pokemons
    {
        public int count { get; set; }
        public string next { get; set; }
        public List<Pokemon> results { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hämta Pokemon från PokeAPI");

            // Hämmta ett skämt från api.chucknorris.io/jockes; 
            string url = "https://pokeapi.co/api/v2";
            var client = new RestClient(url);
            var request = new RestRequest("pokemon", DataFormat.Json);
            var response = client.Get(request);

            // Se svaret
            Pokemons lista = new Pokemons();
            lista = JsonSerializer.Deserialize<Pokemons>(response.Content);

            if(lista != null)   // se ifall informationen kan hitas från hemsidan inan programet körs
            {
                foreach (var item in lista.results)
            {
                Console.WriteLine(item.name);
            }
            }
            
             
        }
    }

}
