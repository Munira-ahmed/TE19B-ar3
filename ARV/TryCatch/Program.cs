using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //kompakt inmatning
                Console.Write("Förnamn Efternamn Lön Antal-timmar: ");
                string[] input = Console.ReadLine().Split(" ");
               

                //kolla att vi fick två text bitar
                if (input.Length == 4)
                {
                    //lagra i en instans
                    //Person person = new Person(input[0], input[1]);
                    Arbetare arbetare = new Arbetare(input[0], input[1], input[2], input[3]);

                    //skriv ut timlön
                    Console.WriteLine($"Din timlön blir {arbetare.RäknaUtTimlön()}kr/timme");
                    
                }
                else
                {
                    Console.WriteLine("Du måste mata in förnamn mellanrum efternamn");
                }
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
