using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using blackjack.card;

namespace blackjack.player {
	internal class Player {
		public List<PlayingCard> playerHand = new List<PlayingCard>();
		public int score;

		public void initiateScore() {
			int temp = 0;
			foreach (PlayingCard card in playerHand) {
				temp += (int)card.value;
			}
			score = temp;
		}

		public void calculateScore() {
			int temp = 0;
			foreach (var card in playerHand) {
				temp += (int)card.value;
			}
			score = temp;
		}

		public void addtoHand(PlayingCard card) {
			playerHand.Add(card);
			calculateScore();
		}

		public void displayHand() {
			foreach(PlayingCard card in playerHand) {
				card.printCard();
            }
		}

		public void emptyHand() {

		}



	}
}
