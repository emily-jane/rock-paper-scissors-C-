using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace RockPaperScissorsTechTest
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void ShouldReturnDrawRockvsRock()
		{
			var main = new MainClass();
			var expected = "It is a tie!";

			var actual = main.RockPaperScissors("rock", "rock");

			CollectionAssert.AreEqual(expected, actual);
		}
		[Test]
		public void ShouldReturnTwoWinsRockvsPaper()
		{
			var main = new MainClass();
			var expected = "Player 2 wins!";

			var actual = main.RockPaperScissors("rock", "paper");

			CollectionAssert.AreEqual(expected, actual);
		}
		[Test]
		public void ShouldReturnOneWinsRockvsScissors()
		{
			var main = new MainClass();
			var expected = "Player 1 wins!";

			var actual = main.RockPaperScissors("rock", "scissors");

			CollectionAssert.AreEqual(expected, actual);
		}
		[Test]
		public void ShouldReturnOneWinsPapervsRock()
		{
			var main = new MainClass();
			var expected = "Player 1 wins!";

			var actual = main.RockPaperScissors("paper", "rock");

			CollectionAssert.AreEqual(expected, actual);
		}
		[Test]
		public void ShouldReturnDrawPapervsPaper()
		{
			var main = new MainClass();
			var expected = "It is a tie!";

			var actual = main.RockPaperScissors("paper", "paper");

			CollectionAssert.AreEqual(expected, actual);
		}
		[Test]
		public void ShouldReturnTwoWinsPapervsScissors()
		{
			var main = new MainClass();
			var expected = "Player 2 wins!";

			var actual = main.RockPaperScissors("paper", "scissors");

			CollectionAssert.AreEqual(expected, actual);
		}
		[Test]
		public void ShouldReturnTwoWinsScissorsvsRock()
		{
			var main = new MainClass();
			var expected = "Player 2 wins!";

			var actual = main.RockPaperScissors("scissors", "rock");

			CollectionAssert.AreEqual(expected, actual);
		}
		[Test]
		public void ShouldReturnOneWinsScissorsvsPaper()
		{
			var main = new MainClass();
			var expected = "Player 1 wins!";

			var actual = main.RockPaperScissors("scissors", "paper");

			CollectionAssert.AreEqual(expected, actual);
		}
		[Test]
		public void ShouldReturnOneWinsScissorsvsScissors()
		{
			var main = new MainClass();
			var expected = "It is a tie!";

			var actual = main.RockPaperScissors("scissors", "scissors");

			CollectionAssert.AreEqual(expected, actual);
		}
		[Test]
		public void ShouldReturnErrorIfNotCorrectOptionForPlayerOne()
		{
			var main = new MainClass();
			var expected = "You must enter rock, paper or scissors.";

			var actual = main.RockPaperScissors("bananas", "scissors");

			CollectionAssert.AreEqual(expected, actual);
		}
		[Test]
		public void ShouldReturnErrorIfNotCorrectOptionForPlayerTwo()
		{
			var main = new MainClass();
			var expected = "You must enter rock, paper or scissors.";

			var actual = main.RockPaperScissors("rock", "oranges");

			CollectionAssert.AreEqual(expected, actual);
		}
		[Test]
		public void ShouldAcceptUpperAndLowerCaseLetters()
		{
			var main = new MainClass();
			var expected = "Player 1 wins!";

			var actual = main.RockPaperScissors("ROCK", "ScIsSoRs");

			CollectionAssert.AreEqual(expected, actual);
		}
	}
}
