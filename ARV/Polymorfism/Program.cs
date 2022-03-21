using System;

namespace Polymorfism
{
    class Program
    {
        abstract class Creature
        {
            //baskklass
            //dynamisk polymorfism - omdefinera något från basklassen med virtual och override och abstract
            public abstract void SaySomething();
            public Creature()
            {
                Console.WriteLine("A creature was created");
            }
             public Creature( int i )
            {
                Console.WriteLine("A creature was created " + i);
            }
        }
        //subklass
        class Wizard : Creature
        {
             //standard konstruktorn i casklassen körs först
            public Wizard() : base(5)
            {
                Console.WriteLine("A wizard was created");
            }
            public Wizard(string name) : this() // innan konstruktorn körs kör man this()
            {
                System.Console.WriteLine("Name was: " + name);
            }
            //Statisk polymorfism - lägga till samma funktion i subklassen, utan override eller virtual
            public override void SaySomething()
            {
              // kör basklassens implementation =>  base.SaySomething();
              System.Console.WriteLine("Wizard says hi");
            }
           
        }
        static void Main(string[] args)
        {
            //I dynamisk polymorfism avgör instansesn typ vilken version av SaySomething() som körs. 
            var c = new Wizard("Munira");
            Creature creature = c;
            creature.SaySomething();
           
        }
    }
}
