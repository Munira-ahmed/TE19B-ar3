using System;

namespace Intro
{
    class Person
    {
        public string Namn { get; set; }
        public string Mobil { get; set; }

        //func, prop, ctor
        //en virtuell metoden kan man "skriva över"

        public virtual void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
        }

    }
    class Student : Person
    {
        public string Årskurs { get; set; }
        public string Program { get; set; }

        //en virtuell metoden kan man "skriva över"
        public override void VisaInfo()
        {
            //en metod som skriver över basklassens metod
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
            Console.WriteLine($"Årskurs: {Årskurs}, Program: {Program}");
        }
    }
    class Lärare : Person
    {
        public string Anställningsår { get; set; }
        public string Ämnen { get; set; }

        public override void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
            Console.WriteLine($"Anställningsår: {Anställningsår}, Ämnen: {Ämnen}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arv - regisrera personer på skolan");


          /*
            while (true)
            {
                //Skapa en instans
                Person person = new Person();

                Console.Write("Vad heter personen?: ");
                person.Namn = Console.ReadLine();
                Console.Write("Ange personens mobilnr: ");
                person.Mobil = Console.ReadLine();

                Console.WriteLine("Mata in en till? (j/n)");
                if (Console.ReadLine() != "j")
                    break;
            }*/
            while (true)
            {
                //Skapa en instans
                Student student = new Student();

                Console.Write("Vad heter Studenten?: ");
                student.Namn = Console.ReadLine();
                Console.Write("Ange studentens mobilnr: ");
                student.Mobil = Console.ReadLine();
                Console.Write("Ange årskurs: ");
                student.Årskurs= Console.ReadLine();
                Console.Write("Ange program: ");
                student.Program = Console.ReadLine();

                //metoden från basklassen
                student.VisaInfo();

                Console.WriteLine("Mata in en till? (j/n)");
                if (Console.ReadLine() != "j")
                    break;
            }
        }
    }
}
