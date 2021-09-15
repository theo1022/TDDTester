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
            int frameIndex = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                if (Rolls[frameIndex] == 10)//strike
                {
                    score += 10 + Rolls[frameIndex + 1] + Rolls[frameIndex + 2];
                    frameIndex++;//varför
                }
                else if (IsSpare(frameIndex))
                {
                    score += 10 + Rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    score += Rolls[frameIndex] + Rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return score;
        }

        private bool IsSpare(int frameIndex)//spare
        {
            return Rolls[frameIndex] + Rolls[frameIndex + 1] == 10;
        }
    }
}
