using System;

namespace Labb15
{
    class Tärning
    {
        private int AntalSidor { get; set; }

        public Tärning(int sidor)
        {
            AntalSidor = sidor;
        }

        public void Kasta()
        {
            Random random = new Random();
             int dice = random.Next(1, AntalSidor+1);
             Console.WriteLine($"Du fick: {dice}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //instans av tärning
            //Tärning tärning = new Tärning();
            Console.WriteLine("Kasta en tärning!");
            Console.Write("Hur många sidor har tärningen: ");
            int sidor = int.Parse(Console.ReadLine());

            Tärning tärning = new Tärning(sidor);

            tärning.Kasta();

        }
    }
}
