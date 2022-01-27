using System;

namespace NyKonstruktor
{
    //Lägg till klassen bok
    class Bok
    {
        public string Titel {get; set;}
        public string Författare {get; set;}
        public int Antalsidor {get; set;}

        //lägg till konstruktor
        public Bok(string Titel, string Författare, int Antalsidor)
        {
            this.Titel = Titel;
            this.Författare = Författare;
            this.Antalsidor = Antalsidor;
        }

        //En klassmetod
        public void SkrivUt()
        {
            Console.WriteLine("Du läser boken "+ Titel +" "+"Skriven av "+ Författare +". Antal sidor: "+ Antalsidor );
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ut bokens information:");

            //skapa objekt
            Bok bok1 = new Bok("Divergent", "Veronica Roth", 487);

            //skriv ut innehåll med metoden SkrivUt()
            bok1.SkrivUt();
        }
    }
}
