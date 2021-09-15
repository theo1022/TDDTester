using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class BowlingGame
    {
        private int _score;
        public void Roll(int pins)
        {
            _score += pins;
        }

        public int Score()
        {
            return _score;
        }
    }
}
