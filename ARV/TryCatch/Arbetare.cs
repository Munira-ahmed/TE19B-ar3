using System;

namespace TryCatch
{
    public class Arbetare : Person
    {
        //Två skyddade interna variabler
        private int lön;
        private int antalTimmar;
        //Två tillgängliga metoder för att läsa och ändra variablernas värden
        public int Lön
        {
            get
            {
                return lön;
            }
            //Kolla att användarens input är rimligt
            set
            {
                if (value >= 0 && value <= 20000)
                {
                    lön = value;
                }else // om input är orimligt så kastar man en exeption
                 {
                     throw new ArgumentException ("Lönen måste vara mellan 0 och 20000 kr/vecka.");
                 }
            }
        }
        public int AntalTimmar
        {
            get
            {
                return antalTimmar;
            }

            set
            {
                 if (value >= 0 && value <= 55)
                {
                    antalTimmar = value;
                }else // om input är orimligt så kastar man en exeption
                 {
                     throw new ArgumentException ("Arbetstimmarna måste vara mellan 0 och 55 timmar/vecka.");
                 }
            }
        }
        //Konstruktor för att sätta variablerna vid skapelse av instansen. stoppa in lön och antaltimmar som string och omvandla det senare och se ifall felmeddelanden behövs.
        public Arbetare(string förnamn, string efternamn, string lön, string antalTimmar) : base(förnamn, efternamn)
        {
            //omvandla string till tal. Går det inte --> Kasta en exeption.
            // Lön = lön;AntalTimmar = antalTimmar;
            int resultat;

            if (!int.TryParse(lön, out resultat))
            {
                throw new ArgumentException("Lön måste vara ett heltal");
            }
            else
            {
                Lön = resultat;
            }
            if (!int.TryParse(antalTimmar, out resultat))
            {
                throw new ArgumentException("Antal timmar måste vara i heltal");
            }
            else
            {
                AntalTimmar = resultat;
            }

        }
        public float RäknaUtTimlön()
        {
            return lön/antalTimmar;
        }
        public override string Sammanfattning()
        {
            return "override";
        }
    }
}