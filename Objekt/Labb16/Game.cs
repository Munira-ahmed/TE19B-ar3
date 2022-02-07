using System;

namespace Labb16
{
    public class Game
    {
        public Player Player { get; set; }
        public Player Dealer { get; set; }
        public Deck Deck { get; set; }
        public GameStatus Status { get; set; }

        public Game()
        {
            
        }
        public void PlayerDraw()
        {}
        public void DealerDraw()
        {}
        /* public Card Draw()
         {

         }*/
    }
}