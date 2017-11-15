using System;

namespace tictactoe
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("This is an attempt at playing tic-tac-toe.");
			Console.WriteLine ("Enjoy!");

			var board = new GameBoard ();
			board.Draw ();
		}
	}
}
