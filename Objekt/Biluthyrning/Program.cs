using System;
using System.Collections.Generic;

namespace Biluthyrning
{
    class Kund
    {
        public string Personnr { get; set; }
        public string Fnamn { get; set; }
        public string Enamn { get; set; }
        public string Mobil { get; set; }

        //använd genväg prop
    }
    class Avtal
    {

        //Egenskaper
        public DateTime Datum { get; set; }
        public string Regnr { get; set; }
        public int Km { get; set; }
        public int Kostnad { get; set; }
        public int Tidsram { get; set; }
        public string Personnr { get; set; }

        public bool finnsRegnr()
        {
            if (bilar.ContainsKey(Regnr))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Privat variabler som bara ska användas inuti klassen
        private IDictionary<string, int> bilar = new Dictionary<string, int>{
        {"ABC123", 500},
        {"DEF456", 400},
        {"GHI789", 199}
    };
        //@todo inte krascha när regnr inte finns (klar)
        //@todo 100 km ingår i hyran, bara betala för extra kilometer
        //@todo att kunna registrera fler avtal (klar)

        /// <summary>
        /// Räkna ut bilens dygnskostnad + antal dygn + 2:-/km
        /// </summary>
        /// <returns></returns>
        public float RäknaKostnad()
        {
            if (bilar.ContainsKey(Regnr))
            {
                Kostnad = bilar[Regnr] * Tidsram + Km * 2;

            }
            return Kostnad;

        }

        /// <summary>
        /// Räkna ut datum + Tidsram
        /// </summary>
        /// <returns></returns>
        public string RäknaInlämningsDatum()
        {
            return Datum.AddDays(Tidsram).ToString("dd MMMM yyyy");
        }

    }

    class Program
    {
        //För att spara alla avtal
        static List<Avtal> listaAvtal = new List<Avtal>();
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till biluthyrningen!");
            string svar = "j";
            while (svar == "j")
            {
                //skapa ett första avtal
                Avtal avtal1 = new Avtal();

                //spara avtalet i listan
                listaAvtal.Add(avtal1);


                Console.Write("Ange kundens personnr: ");
                avtal1.Personnr = Console.ReadLine();

                Console.Write("Ange bilens regnr: ");
                avtal1.Regnr = Console.ReadLine();
                while (!avtal1.finnsRegnr())
                {
                    Console.Write("Ange bilens regnr: ");
                    avtal1.Regnr = Console.ReadLine();
                }


                Console.Write("Ange antal kilometer: ");
                avtal1.Km = int.Parse(Console.ReadLine());

                Console.Write("Ange antal dygn: ");
                avtal1.Tidsram = int.Parse(Console.ReadLine());

                //Lägg till datum
                avtal1.Datum = DateTime.Today;

                //Räkna ut kostnad 

                Console.WriteLine($" Den totala hyran blir {avtal1.RäknaKostnad()}:-");
                Console.WriteLine($"Bilen ska återlämnas {avtal1.RäknaInlämningsDatum()}");


                System.Console.WriteLine();
                System.Console.Write("vill du mata in ett till avtal (j/n): ");
                svar = Console.ReadLine().ToLower();
            }

        }
    }
}
