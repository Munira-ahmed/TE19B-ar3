using System;
using System.Collections.Generic;
namespace Inkomster
{
    class PersonInkomst
    {
        //"Variabler" för att lagra data (Egenskaper)
        public string Namn {get;set;} //get-set skyddar variabeln
        public int Lön {get;set;}
        public int Timmar {get;set;}

        //Klassmetod
        public void VisaTimlön()
        {
          Console.WriteLine($"Timlön för {Namn} är {Lön/Timmar}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program för att registrera löner");

            //lagra uppgifterna i ett objekt
            PersonInkomst objekt = new PersonInkomst();

            List<PersonInkomst> lista = new List<PersonInkomst>();

            //Upprepa tills användaren skriver tomt
            while (true)
            {
                //Ange namn och lön
                Console.WriteLine("Ange ditt namn: ");
                objekt.Namn = Console.ReadLine();

                //avbryt om namn är tomt
                if (objekt.Namn == "")
                {
                    break;
                }
                Console.WriteLine("Ange din månadslön: ");
                objekt.Lön = ReadInt();

                Console.WriteLine("Ange antal timmar: ");
                objekt.Timmar = ReadInt();

                 //lägg till i listan 
              lista.Add(objekt);

            }
            
            //skriv ut den totala lönen & timmarna
            int allLön = 0;
            int allaTimmar = 0;
            foreach (var anställd in lista)
            {
                allLön += anställd.Lön;
                allaTimmar += anställd.Timmar;
                anställd.VisaTimlön();
      
            }
            Console.WriteLine($"Den totala lönekostnaden är {allLön}");
            Console.WriteLine($"Dem totala arbetstimmarna är {allaTimmar}");
            
           
        }
        static int ReadInt()
        {
            int heltal;
            while (!int.TryParse(Console.ReadLine(), out heltal))
            {
                Console.WriteLine("Du skrev inte in ett heltal. Försök igen.");
            }
            return heltal;
        }
    }
}
