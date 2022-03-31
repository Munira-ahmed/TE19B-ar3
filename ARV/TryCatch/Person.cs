using System;

namespace TryCatch
{
    public class Person
    {
        //lagra input
        private string förnamn;
        private string efternamn;
        public string Förnamn
        {
            get
            {
                return förnamn;
            }

            set
            {
                //Börjar den med en versal
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Förnamn måste börja med en Versal");
                }
                //föranmnet ska vara minst 4 tecken långt
                else if(value.Length < 4)
                {
                    throw new ArgumentException("Förnamn måste ha minst 4 tecken långt");
                }
                else
                {
                    förnamn = value;
                }
            }
        }
        public string Efternamn 
        { 
            get
            {
                return efternamn;
            } 

            set
            {
                //Börjar den med en versal
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Efternamn måste börja med en Versal");
                }
               else if(value.Length < 3)
                {
                    throw new ArgumentException("EFternamn måste ha minst 3 tecken långt");
                }
                else
                {
                    efternamn = value;
                }
            } 
        }
        public Person(string förnamn, string efternamn)
        {
            Förnamn = förnamn;
            Efternamn = efternamn;
        }
        //virtual betyder att man kan skriva över den i subklasserna.
        public virtual string Sammanfattning()
        {
            return "sammanfattningen";
        }
    }

}