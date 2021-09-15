using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;
using Xunit;

namespace TDDTester
{
    public class BowlingGameTests
    {
        private BowlingGame _game;// heter g i powerpoint

        public BowlingGameTests()
        {
            _game = new BowlingGame();
        }

        private void RollMany(int rounds, int pinsHitPerRoll)
        {
            for (int i = 0; i < rounds; i++)
            {
                _game.Roll(pinsHitPerRoll);
            }
        }

        [Fact]
        public void TestGutterGame()
        {
            RollMany(20, 0);

            Assert.Equal(0, _game.Score());
        }

        [Fact]
        public void TestAllOnes()
        {
            RollMany(20, 1);
            
            Assert.Equal(20, _game.Score());
        }
        
        [Fact]
        public void TestOneSpare()
        {
            _game.Roll(5);
            _game.Roll(5);// spare
            _game.Roll(3);
            RollMany(17, 0);

            Assert.Equal(16, _game.Score());
        }
    }
}
