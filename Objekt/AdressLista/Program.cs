using System;
using System.Collections.Generic;
namespace Labb9
{
    //skapa klassen NamnAdress
    class NamnAdress
    {
        public string förNamn;
        public string efterNamn;
        public string gatuAdress;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //skapa en lista
            List<NamnAdress> lista = new List<NamnAdress>();

            while (true)
            {
                //skapa objekt 
                NamnAdress objekt = new NamnAdress();

                //mata in namn och gatuadress
                Console.Write("Ange ditt förnamn: ");
                objekt.förNamn = Console.ReadLine();

                Console.Write("Ange ditt efternamn: ");
                objekt.efterNamn = Console.ReadLine();

                Console.Write("Ange din gatuadress: ");
                objekt.gatuAdress = Console.ReadLine();
                //lägg till allt i listan
                lista.Add(objekt);
            }



            //spara i objekt 
            /*objekt.Namn = förNamn;
            objekt.Namn = efterNamn;
            objekt.Gata = gatuAdress;*/





        }
    }
}
