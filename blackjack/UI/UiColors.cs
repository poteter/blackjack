using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack.UI {
	internal class UiColors {

		public void colorWriteRed(string text) {
            Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(text);
			Console.ResetColor();
        }

		public void colorWriteGreen(string text) {
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write(text);
			Console.ResetColor();
		}

		public void colorWriteBlue(string text) {
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write(text);
			Console.ResetColor();
		}
	}
}
