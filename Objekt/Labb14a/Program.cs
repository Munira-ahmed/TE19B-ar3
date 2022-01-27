using System;


namespace Labb14a
{

  
    class Program
    {
        static void Main(string[] args)
        {// I default konstruktorn kan man lägga både Id & Namn
           Kund kunden = new Kund("munira");//konstruktor man anvämder beror på parametern.
           System.Console.WriteLine(kunden.Id);
           System.Console.WriteLine(kunden.Namn);

        }
    }
}

