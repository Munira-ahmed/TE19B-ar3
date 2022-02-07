using System;
using System.Collections.Generic;
namespace Labb16
{
    public class Player
    {
        List<Card> Hand = new List<Card>();
        public Card LastDrawnCard { get; set; }
        public int LowValue { get; set; }
        public int HighValue { get; set; }
        public int BestValue { get; set; }

        public void Reset()
        {

        }

        /*public string ToString()
        {
            metod
        } */
    }
}