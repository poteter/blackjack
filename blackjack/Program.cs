using blackjack.deck;
using blackjack.gameControl;

namespace blackjack
{
    internal class Program {
		static void Main(string[] args) {
			GameControl gameControl = new GameControl();
			gameControl.run();
		}
	}
}