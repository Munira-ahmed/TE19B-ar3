using System;
using System.Collections.Generic;

namespace ArvVideo
{
    class Creature
    {
        public int Power { get; set; }
        public int Toughness { get; set; }
        public string Type { get; set; } // vilken sorts creature är det?

        public Creature(string type, int power, int toughness) //tala om vilken typ av creatur.
        {
            type = Type;
            power = Power;
            toughness = Toughness;
        }
        public virtual void Attack()
        {
            System.Console.WriteLine( Type + "attacks with power" + Power);
        }
        public override string ToString()
        {
            return "Power: " + Power;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           /*List<Creature> creatures = new List<Creature>();
           creatures.Add(new Creature("Knight", 5 , 5)); // typ, powwe & toughness
           creatures.Add(new Creature("Wizard", 7 , 5));*/

           /*var Knight =  new Creature("Knight", 5, 5);

           if (Knight is Creature)
           {
               System.Console.WriteLine("knight är en creature");
           }
           Console.ReadKey();*/

           object o1 = new Creature("", 1 , 1); // det är två olika objekt oavsett innehåll. 
           object o2 = new Creature("", 1 , 1);

           if (o1 == o2)
           {
               System.Console.WriteLine("samma");
           }
           else
           System.Console.WriteLine("inte samma");

           System.Console.WriteLine(o1.ToString());
         Console.ReadKey();
        }
    }
}
