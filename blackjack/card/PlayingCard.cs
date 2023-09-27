using blackjack.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack.card
{
    public class PlayingCard
    {
        public int value;
        public Value cardValue;
        public Suit cardSuit;

        public PlayingCard(int inputSuit, int inputValue)
        {
            if (inputValue > 10 && inputValue < 14) { value = 10; }
            else if (inputValue == 1) { value = 11; }
            else { value = inputValue; }

            cardSuit = (Suit)inputSuit;
            cardValue = (Value)inputValue;
        }

        public void printCard()
        {
            UiColors colors = new UiColors();
            colors.colorWriteRed($"[ {cardValue} of {cardSuit} ] ");
        }
    }
}
