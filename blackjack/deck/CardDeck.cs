using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using blackjack.card;

namespace blackjack.deck
{
    public class CardDeck
    {
        public List<PlayingCard> deck = new();
        public List<PlayingCard> discardPile = new();


        public CardDeck()
        {
            populateDeck();
            randomizedeck();
        }

        public void discard() { 

        }

        public void shuffle() {
            for(int i = 0; i < 52; i++) {
                deck[i] = discardPile[i];
            }
            randomizedeck();
        }

        public void drawCard()
        {
            if (deck.Count == 0)
            {
                shuffle();
            }
            discardPile.Add(deck[0]);
            deck.RemoveAt(0);
        }

        public void populateDeck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    PlayingCard card = new PlayingCard(i, j);
                    deck.Add(card);
                }
            }
        }

        public void randomizedeck()
        {
			Random random = new Random();
            int cycle = 4;
            while(cycle > 0) {
				for (int i = 0; i < 52; i++) {
					int rnd = random.Next(1, 52);
					PlayingCard temp = deck[rnd];
					deck[rnd] = deck[i];
					deck[i] = temp;
				}
                cycle--;
			}
        }

        public void printDeck()
        {
            Console.WriteLine($"size of deck is {deck.Count}");
            foreach (PlayingCard card in deck)
            {
                card.printCard();
            }
        }

    }
}
