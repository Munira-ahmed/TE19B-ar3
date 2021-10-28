using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace KlassDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            //skapa en lista
            List<PersonInkomst> listaPerson = new List<PersonInkomst>();
            Console.WriteLine("Räkna ut lönekostnad");
            while (true)
            {
                //skapa objekt - person
                PersonInkomst Person = new PersonInkomst();


                //Ange namn
                Console.Write("Vad heter den anställde: ");
                Person.namn = Console.ReadLine();

                //Avbryter om namn är tomt
                if (Person.namn == "" )
                {
                    break;
                }

                //Ange timlön
                Console.Write("Hur mycket är den anställdes timlön: ");
                Person.timlön = ReadInt();

                // Ange timmar
                Console.Write("Den anställdes arbetstid (i h): ");
                Person.timmar = ReadInt();

                //lagra i listan
                listaPerson.Add(Person);
            }
            //spara ner som JSON
            string jsonText = JsonConvert.SerializeObject(listaPerson, Formatting.Indented);

            // Spara ner json i textfil
            File.WriteAllText(@"personerinkomst.json", jsonText);

        }
        static int ReadInt()
        {
            int heltal;
            while (!int.TryParse(Console.ReadLine(), out heltal))
            {
                Console.WriteLine("Du skrev inte in ett heltal. Försök igen.");
            }
            return heltal;
        }
    }
}
