using System;

namespace Datum
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datum = DateTime.Now;
            Console.WriteLine($"Dagens datum är {datum}");
            Console.WriteLine($"Vi är i månad {datum.Month}");
            Console.WriteLine($"Vi är datum {datum.Day}");

            //formatera datumet
            Console.WriteLine($"Dagens dag är {datum.ToString("dddd")}");
            Console.WriteLine($"Tiden är {datum.ToString("hh:mm")}");

            //om 40 dagar skall arbete vara klart, vilken dag är det?
            DateTime deadline = datum.AddDays(40);
            Console.WriteLine($"Arbetet ska vara klart {deadline.ToString("dddd dd/MM-yy")}");

            //Be användaren om födelsedatum
            Console.Write("När är du född? (dd/mm/yy):");
            DateTime födelsedag = DateTime.Parse(Console.ReadLine());
            //  Console.WriteLine($"Du är {datum.Year - födelsedag.Year} år gammal");

            //få den exakta ålder med hänsyn på månaderna!
           // Console.WriteLine($"Du är {datum.Year - födelsedag.Year} år gammal");
            int now = int.Parse(datum.ToString("yyyyMMdd"));
            int dob = int.Parse(födelsedag.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;
            Console.WriteLine($"Du är {age} år gammal");


        }
     /*   public int GetAge(DateTime datum){
            int age = 0;
            age
        }*/
    }
}

