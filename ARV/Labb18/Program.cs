using System;

namespace Labb18
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Skapa en spelkaraktär (svara på engelska)");
            //användarens ska skapa knight
            Console.WriteLine("Ange ett namn till karaktären");
            string name = Console.ReadLine();
            Console.WriteLine("Ge karaktären ett vapen");
            string weapon = Console.ReadLine();
            Knight knight = new Knight(name, weapon);

            //det går inte att ändra värdet på dem skyddade egenskaperna
            name = "protected";
            weapon = "sss";
            
           knight.Attack();
        }
    }
}
