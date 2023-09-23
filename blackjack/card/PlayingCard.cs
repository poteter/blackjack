using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack.card
{
    public class PlayingCard
    {
        public Value cardValue;
        public Suit cardSuit;

        public PlayingCard(int inputSuit, int inputValue)
        {
            cardSuit = (Suit)inputSuit;
            cardValue = (Value)inputValue;
        }

        public void printCard()
        {
            Console.WriteLine($"{cardValue} of {cardSuit}");
        }
    }
}
