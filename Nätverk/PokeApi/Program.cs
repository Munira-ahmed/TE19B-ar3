using System;
using RestSharp;
using System.Text.Json;
using System.Collections.Generic;

namespace PokeApi
{
    class Program
    {
        class Pokemon
        {
            public string name { get; set; }
        }

        class Pokemons
        {
            public int count { get; set; }
            public List<Pokemon> results { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hämta alla pokemon");

            //Hämta ett skämt från api.chucknorris.io
            string url = "https://pokeapi.co/api/v2";
            var client = new RestClient(url);
            var request = new RestRequest("pokemon", DataFormat.Json);
            var response = client.Get(request);

            //kolla på svaret 
            //System.Console.WriteLine(response.Content);

            //avkoda json-svaret
            Pokemons lista = new Pokemons();
            lista = JsonSerializer.Deserialize<Pokemons>(response.Content);

            //skriv ut skämtet, med foreach
            if (lista != null) //kolla att det gick att avkoda; annars kraschar det. 
            {
                foreach (var item in lista.results)
            {
                Console.WriteLine(item.name);
            } 
            }
           

        }
    }
}
