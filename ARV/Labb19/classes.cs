using System;

namespace Labb19
{
   
         class Media
    {
        public string Titel { get; set; }

        public Media(string titel)
        {
            Titel = titel;
        }
        public virtual string TillText()
        {
             string text = $"{Titel}";
            return text;
        }
    }
    class Film : Media
    {
        public string Regissör { get; set; }
        public int Längd { get; set; }

        public Film(string titel, string regissör, int längd) : base(titel)
        {
            Titel = titel;
            Regissör = regissör;
            Längd = längd;
        }
        public override string TillText()
        {
           string text = $"{Titel}({Regissör},{Längd})";
            return text;
        }
    }
    class Bok : Media
    {
        public string Författare { get; set; }
        public int Sidor { get; set; }

        public Bok(string t, string författare, int sidor) : base(t)
        {
            Titel = t;
            Författare = författare;
            Sidor = sidor;
        }
        public override string TillText()
        {
            string text = $"{Titel}({Författare},{Sidor})";
            return  text;
        }
    }
    }
