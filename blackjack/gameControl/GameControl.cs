using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using blackjack.player;
using blackjack.deck;

namespace blackjack.gameControl {
	internal class GameControl {
		bool gameRunning;

		public void run() {
			gameRunning = true;
			Dealer dealer = new Dealer();
			Player player = new Player();
			CardDeck cardDeck = new CardDeck();

			dealer.addtoHand(cardDeck.drawCard());
			dealer.addtoHand(cardDeck.drawCard());

			player.addtoHand(cardDeck.drawCard());
			player.addtoHand(cardDeck.drawCard());
			player.initiateScore();

			while (gameRunning) {
				Console.Write($"The dealer has ");
				dealer.displayHand();

				gameRunning = false;

			}
		}



	}
}
