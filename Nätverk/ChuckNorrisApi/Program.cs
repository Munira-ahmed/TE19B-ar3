using System;
using RestSharp;
using System.Text.Json;

namespace ChuckNorrisApi
{
    class Program
    {
        //skämtets originella format är i json

        //skapa klass som tar emot vissa delar av skämtet
        class Joke
        {
            public string icon_url {get;set;}
            public string value {get;set;} // gör det till metoder

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Chuck Norris skämt: ");

            //Hämta ett skämt från api.chucknorris.io
            string url = "https://api.chucknorris.io/jokes";
            var client = new RestClient(url);
            var request = new RestRequest("random", DataFormat.Json);
            var response = client.Get(request);

            //kolla svar
           // System.Console.WriteLine(response.Content);

            //avkoda JSON-svaret
            Joke skämtet = new Joke();
            skämtet = JsonSerializer.Deserialize<Joke>(response.Content);

            //skriv ut skämtet 
            Console.WriteLine(skämtet.value);


        }
    }
}
