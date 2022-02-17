using System;

namespace Intro
{
    /// <summary>
    /// Basklassen
    /// </summary>
    class Person
    {
        //prop
        public string Namn { get; set; }
        public string Mobil { get; set; }

        //ctor
        //körs automatiskt vid "new"
        public Person(string namn, string mobil)
        {
            Namn = namn;
            Mobil = mobil;
        }

        //func
        //en virtuell metoden kan man "skriva över"
        public virtual void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
        }

    }
    /// <summary>
    /// Klassen student bygger på klassen person
    /// </summary>
    class Student : Person
    {
        public string Årskurs { get; set; }
        public string Program { get; set; }

        public Student(string n, string m, string årskurs, string program) : base(n, m)
        {
            Årskurs = årskurs;
            Program = program;
        }

        //en virtuell metoden kan man "skriva över"
        public override void VisaInfo()
        {
            //en metod som skriver över basklassens metod
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
            Console.WriteLine($"Årskurs: {Årskurs}, Program: {Program}");
        }
    }
    /// <summary>
    /// Klassen Lärare bygger på klassen person
    /// </summary>
    class Lärare : Person
    {
        public string Anställningsår { get; set; }
        public string Ämnen { get; set; }

        public Lärare(string n, string m, string anställningsår, string ämne) : base(n, m)
        {
            Anställningsår = anställningsår;
            Ämnen = ämne;
        }

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



            /*   while (true)
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

            Person person = new Person("Max", "1234567");
            while (true)
            {
                //Skapa en instans
                Student student = new Student();

                Console.Write("Vad heter Studenten?: ");
                student.Namn = Console.ReadLine();
                Console.Write("Ange studentens mobilnr: ");
                student.Mobil = Console.ReadLine();
                Console.Write("Ange årskurs: ");
                student.Årskurs = Console.ReadLine();
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
