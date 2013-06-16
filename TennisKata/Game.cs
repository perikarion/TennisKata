using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TennisKata
{
    public class Game : IGame
    {
        Tuple<string,string> _score = Tuple.Create("0","0");


        public void BallWonByPlayer1()
        {
            AdjustScorePlayer1();
        }

        public Tuple<string, string> CheckScore()
        {
            return _score;
        }

        public void BallWonByPlayer2()
        {
            AdjustScorePlayer2();
        }

        private void AdjustScorePlayer1()
        {
            switch (_score.Item1)
            {
                case "0":
                    _score = Tuple.Create("15", _score.Item2);
                     break;
                case "15":
                   _score = Tuple.Create("30", _score.Item2);
                     break;
                case "30":
                    _score = Tuple.Create("40", _score.Item2);
                    break;
                case "40":
                    if (_score.Item2 == "40")
                        _score = Tuple.Create("Advance", "");
                    else
                        _score = Tuple.Create("Winner", "");

                    break;
                case "":
                    if (_score.Item2 == "Advance")
                        _score = Tuple.Create("Douce", "Douce");
                    break;
                case "Douce":
                        _score = Tuple.Create("Advance", "");
                    break;
                case "Advance":
                        _score = Tuple.Create("Winner", "");
                    break;

            }
        }

        private void AdjustScorePlayer2()
        {
            switch (_score.Item2)
            {
                case "0":
                    _score = Tuple.Create(_score.Item1, "15");
                    break;
                case "15":
                    _score = Tuple.Create(_score.Item1, "30");
                    break;
                case "30":
                    _score = Tuple.Create(_score.Item1, "40");
                    break;
                case "40":
                    if (_score.Item1 == "40")
                        _score = Tuple.Create("", "Advance");
                     else
                        _score = Tuple.Create("", "Winner");
                    break;
                case "":
                    if (_score.Item1 == "Advance")
                        _score = Tuple.Create("Douce", "Douce");
                   break;
                case "Douce":
                   _score = Tuple.Create("", "Advance");
                   break;
                case "Advance":
                   _score = Tuple.Create("", "Winner");
                   break;
            }
        }
     }
}
