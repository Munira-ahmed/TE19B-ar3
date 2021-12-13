using System;

namespace Labb13a
{
    class Namn
    {
        public string Förnamn {get;set;}
        public string Efternamn {get;set;}
        public float Vikt {get;set;}
        
        public float Längd {get;set;}

        public DateTime Födelsedatum {get;set;}

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
        public float BMI()
        {
          return (Vikt/(Längd*Längd));
            
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

             Console.WriteLine("Ange din Längd i meter: ");
                objekt.Längd = float.Parse(Console.ReadLine());

             Console.WriteLine("Ange din Vikt: ");
            objekt.Vikt = float.Parse(Console.ReadLine());
            

            Console.WriteLine("Ange ditt födelsedatum (år-mån-dag): ");
            objekt.Födelsedatum = DateTime.Parse(Console.ReadLine());

           Console.WriteLine("-------------------");
            objekt.VisaNamn();
            objekt.Myndig();
            Console.WriteLine($"Ditt BMI är ungefär{Math.Round(objekt.BMI())}");
            
        }
    }
}
