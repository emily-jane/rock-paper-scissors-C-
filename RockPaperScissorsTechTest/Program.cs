using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissorsTechTest
{
	class MainClass
	{
		public static string RockPaperScissors (string player1, string player2)
		{
			if (!(new[] { "rock", "paper", "scissors" }.Contains (player1.ToLower ())) || !(new[] { "rock", "paper", "scissors" }.Contains (player2.ToLower ()))) {
				return "You must enter rock, paper or scissors.";
			};
			if (player1 == player2) {
				return "It is a tie!";
			}
			if (player1 == "rock") {
				if (player2 == "paper") {
					return "Player 2 wins!";
				} else if (player2 == "scissors") {
					return "Player 1 wins!";
				}
				;
			} else if (player1 == "paper") {
				if (player2 == "rock") {
					return "Player 1 wins!";
				} else if (player2 == "scissors") {
					return "Player 2 wins!";
				}
				;
			} else if (player1 == "scissors") {
				if (player2 == "rock") {
					return "Player 2 wins!";
				} else if (player2 == "paper") {
					return "Player 1 wins!";
				} 
			}
		}
	}
}
