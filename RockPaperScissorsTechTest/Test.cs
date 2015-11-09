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
		public void ShouldReturnOneWinsRockvsScissors()
		{
			var main = new MainClass();
			var expected = "Player 1 wins!";

			var actual = main.RockPaperScissors("rock", "scissors");

			CollectionAssert.AreEqual(expected, actual);
		}
	}
}

