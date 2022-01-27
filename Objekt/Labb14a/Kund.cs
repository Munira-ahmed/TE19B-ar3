using System;
using System.Collections.Generic;

namespace Labb14a
{
    public class Kund
    {
        public int Id;
        public string Namn;
        public List<Order> Orders;

        public Kund() // Default / parameterless constructor
        {
            Orders = new List<Order>();
        }
        public Kund( int Id)  //overloading constructors - tre olika konstruktorer, med olika parametrar/signaturer
         :this()
        {
            this.Id = Id;
        }
        public Kund(string Namn) //accepterar endast en string som parameter
        {
            this.Namn = Namn;
        }

        public Kund( int Id, string Namn)
         :this(Id) //using "this" keyword för att andra konstruktorn körs först- Denna gör så att pub. Kund int id körs först
        {
          
            this.Namn = Namn;
        }
    }
}