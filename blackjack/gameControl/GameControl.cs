﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using blackjack.player;
using blackjack.deck;
using blackjack.UI;

namespace blackjack.gameControl {
	internal class GameControl {
		bool gameRunning;
		Dealer dealer = new Dealer();
		Player player = new Player();
		CardDeck cardDeck = new CardDeck();
		UiColors colors = new UiColors();

		public void setUp() {
			gameRunning = true;

			dealer.addtoHand(cardDeck.drawCard());
			dealer.addtoHand(cardDeck.drawCard());

			player.addtoHand(cardDeck.drawCard());
			player.addtoHand(cardDeck.drawCard());
			player.initiateScore();
		}

		public void run() {
			setUp();

			if(player.score == 21) {
                colors.colorWriteRed("Blackjack - player wins");
            }
			else if(player.score > 21) {
				colors.colorWriteRed($"Player loses with a score of {player.calculateScore}");
				
			}
			else {
				while (gameRunning) {
					Console.Clear();
					printPlayerDialog();
					checkForDraw((char)Console.Read());
				}
			}
		}

		public void checkForDraw(char input) {
			switch (input) {
				case 'y': {
						player.addtoHand(cardDeck.drawCard());
						checkforPlayerWin(player.score);
						break;
					}
				case 'n': {
						while (gameRunning) {
							checkforDealerWin(dealer.score);
						}
						break;
					}

			}
		}

		public void checkforDealerWin(int score) {
			if (score > 21) {
				gameRunning = false;
				colors.colorWriteGreen($"Dealer have lost with a score of {score}");
			}
			else if (score < 17) {
				dealer.addtoHand(cardDeck.drawCard());
			}
			else if(score >= 17) {
				if(score > player.score) {
					colors.colorWriteGreen($"The dealer loses with a score of {dealer.score} over the players score of {player.score}");
					gameRunning = false;
                }
				else if(score <= player.score) {
					colors.colorWriteGreen($"The dealer has won with a score of {dealer.score} equals to or below the players score of {player.score}");
					gameRunning = false;
                }
			}
		}

		public void checkforPlayerWin(int score) {
			if(score > 21) {
				gameRunning = false;
				colors.colorWriteRed($"You have lost with a score of {score}");
            }
			else if(score == 21) {
				gameRunning = false;
				colors.colorWriteGreen("21 - You win");
            }
		}

		public void printPlayerDialog() {
			Console.Write($"The dealer has ");
			dealer.displayHand();
            Console.WriteLine("\n\n\n");
			Console.Write("The player has ");
			player.displayHand();
			Console.WriteLine("\nAnd a score of " + player.score);
			Console.Write("\nDraw new card? ");
			colors.colorWriteBlue("(y/n)");
            Console.Write(" > ");
        }

	}
}
