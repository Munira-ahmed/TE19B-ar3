using System;


namespace Labb14a
{

  
    class Program
    {
        static void Main(string[] args)
        {
           Kund kunden = new Kund(1, "john");
           System.Console.WriteLine(kunden.Id);
           System.Console.WriteLine(kunden.Namn);

        }
    }
}

