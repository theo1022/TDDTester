using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;
using Xunit;

namespace TDDTester
{
    public class BowlingGameTests
    {
        [Fact]
        public void TestGutterGame()
        {
            BowlingGame game = new BowlingGame();

            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }

            Assert.Equal(0, game.Score());
        }

        [Fact]
        public void TestAllOnes()
        {
            BowlingGame game = new BowlingGame();

            for (int i = 0; i < 20; i++)
            {
                game.Roll(1);
            }

            Assert.Equal(20, game.Score());

        }
    }
}
