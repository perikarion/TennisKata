using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TennisKata
{
    public interface IGame
    {
        void BallWonByPlayer1();

        Tuple<string,string> CheckScore();

        void BallWonByPlayer2();
    }
}
