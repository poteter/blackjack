using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using blackjack.card;
using blackjack.UI;

namespace blackjack.player {
	internal class Dealer {
		public List<PlayingCard> dealerHand = new List<PlayingCard>();
		public int score;


		public void initiateScore() {
			int temp = 0;
			foreach (PlayingCard card in dealerHand) {
				temp += (int)card.value;
			}
			score = temp;
		}

		public void calculateScore() {
			int temp = 0;
			foreach (var card in dealerHand) {
				temp += (int)card.value;
			}
			score = temp;
		}

		public void addtoHand(PlayingCard card) {
			dealerHand.Add(card);
			calculateScore();
		}

		public void displayHand() {
            UiColors colors = new UiColors();
			colors.colorWriteRed("[ Hidden Card ] ");
            for (int i = 1; i < dealerHand.Count; i++) {
				dealerHand[i].printCard();
			}
		}
	}
}
