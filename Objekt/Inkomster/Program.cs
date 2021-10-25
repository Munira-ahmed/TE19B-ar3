using System;
using System.Collections.Generic;
namespace Inkomster
{
    class PersonInkomst
    {
        public string Namn = "";
        public int Lön = 0;
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
   
            }
            
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
