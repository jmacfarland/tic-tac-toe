using System;

namespace tictactoe
{
	public class GameBoard
	{
		int[,] board;

		public GameBoard ()
		{
			board = new int[3,3];

			for (int y = 0; y < 3; y++) 
			{
				for (int x = 0; x < 3; x++) 
				{
					board [x, y] = 0;
				}
			}
		}

		public void Draw()
		{
			for (int y = 0; y < 3; y++) 
			{
				for (int x = 0; x < 3; x++) 
				{
					Console.Write (board [x, y] + " ");
				}
				Console.Write ("\n");
			}
		}
	}
}

