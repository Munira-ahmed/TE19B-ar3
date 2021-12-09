using System;

namespace Labb13a
{
    class Namn
    {
        public string Förnamn;
        public string Efternamn;

        public DateTime Födelsedatum;

        //Klassmetod
        public void VisaNamn()
        {
            Console.WriteLine($"{Förnamn} {Efternamn}");
        }
        public void Myndig()
        {
            DateTime Now = DateTime.Now;
            int ålder = Now.Year - Födelsedatum.Year;
            if (ålder >= 18)
            {
             Console.WriteLine($"Du är {ålder} år gammal och är därför myndig");
        
                
            }else
            {
             Console.WriteLine("Du är inte myndig");
                
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Namn objekt = new Namn();

            Console.WriteLine("Ange ditt Förnamn: ");
                objekt.Förnamn = Console.ReadLine();

             Console.WriteLine("Ange ditt Efternamn: ");
            objekt.Efternamn = Console.ReadLine();

            Console.WriteLine("Ange ditt födelsedatum (år-mån-dag): ");
            objekt.Födelsedatum = DateTime.Parse(Console.ReadLine());

            System.Console.WriteLine("");
            objekt.VisaNamn();
            objekt.Myndig();

          
        }
    }
}
