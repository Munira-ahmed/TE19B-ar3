using System;
using System.Collections.Generic;
namespace ConsolLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //skapa en array
            string[] städer = {"Berlin","Paris","London"};

            //Ett annat sätt att skapa arrayer
            string[] frukter = new string[3];
            frukter[0]= "Äpple";
            frukter[1]= "Apelsin";
            frukter[2]= "Banan";

            //Skapa en lista av namn
            List<string> namnen = new List<string>(){"Miriam", "Teo", "Alex"};

            //skapa en lista
            List<string> bären = new List<string>();
            bären.Add("Blåbär");
            bären.Add("Lingon");
            bären.Add("Hallon");
            bären.Add("Björnbär");

            //Skriv ut alla frukter
            for (int i = 0; i < frukter.Length; i++)
            {
                   Console.WriteLine(frukter[i]);
            }

            // En annan loop man kan använda
            foreach (var frukt in frukter)
            {
                Console.WriteLine(frukt);
            }

            //skriv alla bären i Listan
            for (var i = 0; i < bären.Count; i++)
            {
                Console.WriteLine(bären[i]);
            }

            //Om vi ska hitta en stad i arrayen
            foreach (var stad in städer)
            {
                if (stad == "Paris")
                {
                    Console.WriteLine("Paris finns i arrayen");
                }
            }

            //Om vi vill hitta ett bär i listan
            if (bären.Contains("Blåbär"))
            {
                Console.WriteLine("Blåbär finns i listan");
            }

            //Ta bort ett bär (hitta med namner)
            bären.Remove("Hallon");
            //eller (via index)
            bären.RemoveAt(0);

            bären.Insert(1, "Kråkbär");

            foreach (var bär in bären)
            {
                Console.WriteLine(bär);
            }


        }
    }
}
