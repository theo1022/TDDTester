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
            RollSpare();
            _game.Roll(3);
            RollMany(17, 0);

            Assert.Equal(16, _game.Score());
        }

        [Fact]
        public void TestOneStrike()
        {
            RollStrike();
            _game.Roll(3);
            _game.Roll(4);
            RollMany(16, 0);

            Assert.Equal(24, _game.Score());
        }

        [Fact]
        public void TestPerfectGame()
        {
            RollMany(12, 10);

            Assert.Equal(300, _game.Score());
        }

        private void RollStrike()
        {
            _game.Roll(10);
        }

        private void RollSpare()
        {
            _game.Roll(5);
            _game.Roll(5);
        }
    }
}
