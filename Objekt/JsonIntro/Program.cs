using System;
using Newtonsoft.Json;
using System.IO;

namespace JsonIntro
{
    //Mallen
    class Film{
        public string Titel;
        public string Årtal;
        public string Regissör;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skapa JSON-objekt");

            //objektet avatar
            Film avatar = new Film()
            {
                Titel = "Avatar",
                Årtal = "2009",
                Regissör = "James Cameron"
            };
            Film legend = new Film()
            {
                Titel = "I Am Legend",
                Årtal = "2008",
                Regissör = "Francis Lawrence"
            };
            Film interstellar = new Film()
            {
                Titel = "Interstellar",
                Årtal = "2014",
                Regissör = "Christopher Nolan"
            };

            //skriv ut lite json
            string jsonText = JsonConvert.SerializeObject(avatar, Formatting.Indented);
            jsonText += ",\n " + JsonConvert.SerializeObject(legend, Formatting.Indented);
            jsonText += ",\n " + JsonConvert.SerializeObject(interstellar, Formatting.Indented);
            Console.WriteLine(jsonText);

            //spara i en json-fil
            File.WriteAllText("filmer.json", jsonText);
        }
    }
}
