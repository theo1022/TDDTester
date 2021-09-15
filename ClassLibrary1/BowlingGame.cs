using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class BowlingGame
    {
        private int[] Rolls = new int[21];
        private int _currentRoll;

        public void Roll(int pins)
        {
            Rolls[_currentRoll++] = pins;
        }

        public int Score()
        {
            int score = 0;
            int i = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                if (Rolls[i] + Rolls[i + 1] == 10)// spare
                {
                    score += 10 + Rolls[i + 2];
                    i += 2;
                }
                else
                {
                    score += Rolls[i] + Rolls[i + 1];
                    i += 2;
                }
            }

            return score;
        }
    }
}
