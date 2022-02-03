using System;

namespace Labb14
{
    public class Bok
    {
      
    
        private string Titel { get; set; }
        private string Författare { get; set; }
        private int Sidor { get; set; }

        //Konstruktro = speciell metod


        public void SkrivUt()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine($"Boken heter {Titel}, författare är {Författare} och den har {Sidor} sidor. ");

        }
          public Bok(string _titel, string _författare, int _antalSidor)
        {
            Titel = _titel;
            Författare = _författare;
            Sidor = _antalSidor;
        }
    
    }
}