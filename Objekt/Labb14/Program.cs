using System;

namespace Labb14
{
    class Bok 
    {
        public string Titel {get;set;}
        public string Författare {get;set;}
        public int Sidor {get;set;}

        public void SkrivUt()
        {
            System.Console.WriteLine("-------------------");
            Console.WriteLine($"Info för boken: {Titel}");
            Console.WriteLine($"författare: {Författare}");
            Console.WriteLine($"Antal sidor: {Sidor}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Bok objekt = new Bok();
            Console.WriteLine("Skriv ut bokens info");

            Console.Write("Ange bokens titel:");
            objekt.Titel = Console.ReadLine();

            Console.Write("Ange bokens författare:");
            objekt.Författare = Console.ReadLine();

            Console.Write("Ange antal sidor i boken:");
            objekt.Sidor = int.Parse(Console.ReadLine());

            objekt.SkrivUt();
            
        }
    }
}
