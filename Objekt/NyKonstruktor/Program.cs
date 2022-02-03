using System;

namespace NyKonstruktor
{
    //Lägg till klassen bok
    class Bok
    {
        public string Titel { get; set; }
        public string Författare { get; set; }
        public int Antalsidor { get; set; }

        //lägg till konstruktor
        public Bok(string Titel, string Författare, int Antalsidor)
        {
            this.Titel = Titel;
            this.Författare = Författare;
            this.Antalsidor = Antalsidor;
        }

        //"overloading constructors" - skapa flera kontruktorer med samma namn, men olika parametrar/signaturer
       
        public Bok(string Titel)
        {
            this.Titel = Titel;
        }

        //En klassmetod
        public void SkrivUt()
        {
            Console.WriteLine($"Du läser boken {Titel} Skriven av {Författare}. Antal sidor: {Antalsidor}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //, 487
            Console.WriteLine("bokens information:");

            //skapa objekt
            Bok bok1 = new Bok("Divergent");

            //skriv ut innehåll med metoden SkrivUt()
            bok1.SkrivUt();
        }
    }
}
