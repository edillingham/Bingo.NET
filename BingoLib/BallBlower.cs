using System;
using System.Collections.Generic;
using System.Text;

namespace BingoLib
{
    public class BingoBall
    {
        public string Letter;
        public int Number;

        public override string ToString()
        {
            return this.Letter + this.Number.ToString("0#");
        }
    }

    public class BallBlower
    {
        private const int DEFAULT_NUMBER_OF_BALLS_TO_DRAW = 24;

        private const int LOWEST_BALL = 1;
        private const int HIGHEST_BALL = 75;

        Dictionary<string, int> pulls = new Dictionary<string, int>();
        private List<int> balls = new List<int>();

        private int _maxBalls = DEFAULT_NUMBER_OF_BALLS_TO_DRAW;

        public BallBlower()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.balls.Clear();
            this.pulls.Clear();

            pulls.Add("B", 5);
            pulls.Add("I", 5);
            pulls.Add("N", 4);
            pulls.Add("G", 5);
            pulls.Add("O", 5);
        }

        public BingoBall GetNextBall()
        {
            Random rnd = new Random();
            int nextBall;
            string ballLetter;

            nextBall = rnd.Next(LOWEST_BALL, HIGHEST_BALL);
            ballLetter = getLetterByValue(nextBall);

            if (balls.Count > this.MaxBalls)
            {
                throw new IndexOutOfRangeException("Exceeded maximum number of allowed draws; use BallBlower.Reset() to avoid this message.");
            }
            else
            {
                while (balls.Contains(nextBall) || (pulls[ballLetter] == 0))
                {
                    nextBall = rnd.Next(LOWEST_BALL, HIGHEST_BALL);
                    ballLetter = getLetterByValue(nextBall);
                }
                balls.Add(nextBall);
                pulls[ballLetter]--;
            }

            BingoBall theBall = new BingoBall();
            theBall.Number = nextBall;
            theBall.Letter = getLetterByValue(nextBall);

            return theBall;
        }

        private string getLetterByValue(int val)
        {
            if (val <= 15)
                return "B";
            else if (val > 15 && val <= 30)
                return "I";
            else if (val > 30 && val <= 45)
                return "N";
            else if (val > 45 && val <= 60)
                return "G";
            else if (val > 60)
                return "O";
            else
                throw new ApplicationException();
        }

        public int DrawCount
        {
            get { return this.balls.Count; }
        }
        
        public int MaxBalls
        {
            get { return _maxBalls; }
            set { _maxBalls = value; }
        }
    }
}
