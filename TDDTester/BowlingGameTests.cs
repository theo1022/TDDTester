using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;
using Xunit;

namespace TDDTester
{
    public class BowlingGameTests
    {
        private BowlingGame _game;

        public BowlingGameTests()
        {
            _game = new BowlingGame();
        }

        [Fact]
        public void TestGutterGame()
        {
            MakeRolls(20, 0);

            Assert.Equal(0, _game.Score());
        }

        [Fact]
        public void TestAllOnes()
        {
            MakeRolls(20, 1);
            
            Assert.Equal(20, _game.Score());
        }

        private void MakeRolls(int rounds, int pinsHitPerRoll)
        {
            for (int i = 0; i < rounds; i++)
            {
                _game.Roll(pinsHitPerRoll);
            }
        }
    }
}
