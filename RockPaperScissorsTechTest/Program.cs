using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissorsTechTest
{
	class MainClass
	{
		public string RockPaperScissors (string playerOne, string playerTwo)
		{
			string player1 = playerOne.ToLower();
			string player2 = playerTwo.ToLower();
			if (player1 == "rock") {
				if (player2 == "paper") {
					return "Player 2 wins!";
				} else if (player2 == "scissors") {
					return "Player 1 wins!";
				} else if (player1 == player2) {
					return "It is a tie!";
				} else {
					return "You must enter rock, paper or scissors.";
				}
			} else if (player1 == "paper") {
				if (player2 == "rock") {
					return "Player 1 wins!";
				} else if (player2 == "scissors") {
					return "Player 2 wins!";
				} else if (player1 == player2) {
					return "It is a tie!";
				} else {
					return "You must enter rock, paper or scissors.";
				}
			} else if (player1 == "scissors") {
				if (player2 == "rock") {
					return "Player 2 wins!";
				} else if (player2 == "paper") {
					return "Player 1 wins!";
				} else if (player1 == player2) {
					return "It is a tie!";
				} else {
					return "You must enter rock, paper or scissors.";
				}
			} else {
				return "You must enter rock, paper or scissors.";
			}
		}
	}
}
