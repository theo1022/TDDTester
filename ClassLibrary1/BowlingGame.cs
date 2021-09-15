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
                if (IsStrike(frameIndex))
                {
                    score += 10 + StrikeBonus(frameIndex);
                    frameIndex++;//varför?
                }
                else if (IsSpare(frameIndex))
                {
                    score += 10 + SpareBonus(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    score += SumOfBallsInFrame(frameIndex);
                    frameIndex += 2;
                }
            }
            return score;
        }

        private bool IsStrike(int frameIndex)
        {
            return Rolls[frameIndex] == 10;
        }

        private int SumOfBallsInFrame(int frameIndex)
        {
            return Rolls[frameIndex] + Rolls[frameIndex + 1];
        }

        private int SpareBonus(int frameIndex)
        {
            return Rolls[frameIndex + 2];
        }

        private int StrikeBonus(int frameIndex)
        {
            return Rolls[frameIndex + 1] + Rolls[frameIndex + 2];
        }

        private bool IsSpare(int frameIndex)
        {
            return Rolls[frameIndex] + Rolls[frameIndex + 1] == 10;
        }
    }
}
