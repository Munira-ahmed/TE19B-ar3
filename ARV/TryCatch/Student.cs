using System;
using System.Linq;

namespace TryCatch
{

    public class Student : Person
    {
        private string studieProgram;
        private string StudieProgram 
        {
            get
            {
                return studieProgram;
            }
            set
            {
                //kolla att programmet är Teknik, Estet eller El
               // if (value.ToLower() != "teknik" && value.ToLower() != "el" && value.ToLower() != "estet")
               string[] lista = {"teknik", "estet", "el"};
               if(!lista.Contains(value.ToLower()))
                {
                    throw new ArgumentException("Ogiltigt studieprogram");
                }
            }
        }
        public Student(string förnamn, string efternamn, string studieProgram) : base(förnamn, efternamn)
        {
            StudieProgram = studieProgram;
        }
         public override string Sammanfattning()
        {
            return "override2";
        }
    }

}