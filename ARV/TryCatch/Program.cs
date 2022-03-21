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
                Console.Write("Förnamn Efternamn: ");
                string[] input = Console.ReadLine().Split(" ");

                //kolla att vi fick två text bitar
                if (input.Length == 2)
                {
                    //lagra i en instans
                }
                else
                {
                    Console.WriteLine("Du måste mata in förnamn mellanrum efternamn");
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}
