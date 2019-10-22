using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
	public class Methods
	{
		char current = 'X';
		int[] fields = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //solely for testing, will have a test to check if there are 9 fields
		public int CreateBoard()
		{
			int _count = 0, i = 0;
			
			for (i = 0; i < 9; i++)
			{
				if (fields[i] != '\0')
				{
					_count++;
				}
			}

			return _count;

		}

		public char CurrentPlayer()
		{
			
			return current;
		}

		public char ChangePlayer()
		{
			if (current == 'X')
			{
				current = 'O';
			}
			else
			{
				current = 'X';
			}

			return current;
		}

		public char MakeMove(int player, int n, char [] array)
		{
			if (player == 'X')
			{
				array[n] = 'X'; //occupy this element in array and mark according to currentplayer
			}
			else if (player == 'O')
			{
				array[n] = 'O';
			}
			return array[n];
		}

	}
}
