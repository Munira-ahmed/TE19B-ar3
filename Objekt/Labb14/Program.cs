using System;

namespace Labb14
{
   

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv ut bokens info");

            Console.Write("Vad heter boken:");
            string titel = Console.ReadLine();

            Console.Write("Vad heter författaren:");
            string författare = Console.ReadLine();

            Console.Write("Ange antal sidor i boken:");
            int antalSidor = int.Parse(Console.ReadLine());

            // bok av typen Bok --- bok kallas även en instans av Bok
            //skapa och ge värdena samtidigt!
            Bok bok = new Bok(titel, författare, antalSidor);

            //skriv ut sammanfattning
            bok.SkrivUt();

        }
    }
}
