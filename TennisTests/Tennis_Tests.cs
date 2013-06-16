using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisKata;

namespace TennisTests
{
    [TestClass]
    public class Tennis_Tests
    {
        [TestMethod]
        public void CanCreateGame()
        {
            IGame game = new Game();
            Assert.IsNotNull(game);
        }

 
        [TestMethod]
        public void CanCheckScore()
        {
            IGame game = new Game();
            game.BallWonByPlayer1();
            Tuple<string,string> score = game.CheckScore();
            Assert.IsTrue(score.Item1 == "15");
        }


        [TestMethod]
        public void CanWinTwice()
        {
            IGame game = new Game();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            Tuple<string,string> score = game.CheckScore();
            Assert.IsTrue(score.Item1 == "30");
        }


        [TestMethod]
        public void CanWinThreeTimes()
        {
            IGame game = new Game();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            Tuple<string,string> score = game.CheckScore();
            Assert.IsTrue(score.Item1 == "40");
        }

        [TestMethod]
        public void Player2ShouldScore()
        {
            IGame game = new Game();
            game.BallWonByPlayer2();
            Tuple<string,string> score = game.CheckScore();
            Assert.IsTrue(score.Item2 == "15");
       
        }


        [TestMethod]
        public void CanWinTwicePlayer2()
        {
            IGame game = new Game();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            Tuple<string,string> score = game.CheckScore();
            Assert.IsTrue(score.Item2 == "30");
        }


        [TestMethod]
        public void CanWinThreeTimesPlayer2()
        {
            IGame game = new Game();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            Tuple<string,string> score = game.CheckScore();
            Assert.IsTrue(score.Item2 == "40");
        }


        [TestMethod]
        public void Player1ShouldAdvance()
        {
            IGame game = new Game();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            game.BallWonByPlayer1(); 
            Tuple<string, string> score = game.CheckScore();
            Assert.IsTrue(score.Item1 == "Advance");
            Assert.IsTrue(score.Item2 == "");

        }

        [TestMethod]
        public void Player2ShouldAdvance()
        {
            IGame game = new Game();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            Tuple<string, string> score = game.CheckScore();
            Assert.IsTrue(score.Item1 == "");
            Assert.IsTrue(score.Item2 == "Advance");
        }


        [TestMethod]
        public void ShouldBeDouce()
        {
            IGame game = new Game();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            game.BallWonByPlayer1();
            game.BallWonByPlayer2();
            Tuple<string, string> score = game.CheckScore();
            Assert.IsTrue(score.Item1 == "Douce");
            Assert.IsTrue(score.Item2 == "Douce");

        }


        [TestMethod]
        public void Player1ShouldWinTheGame()
        {
            IGame game = new Game();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            Tuple<string, string> score = game.CheckScore();
            Assert.IsTrue(score.Item1 == "Winner");
 
        }

        [TestMethod]
        public void Player2ShouldWinTheGame()
        {
            IGame game = new Game();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            Tuple<string, string> score = game.CheckScore();
            Assert.IsTrue(score.Item2 == "Winner");

        }

        [TestMethod]
        public void Player1ShouldAdvanceAfterDouce()
        {
            IGame game = new Game();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            game.BallWonByPlayer1();
            game.BallWonByPlayer2();
            game.BallWonByPlayer1();
            Tuple<string, string> score = game.CheckScore();
            Assert.IsTrue(score.Item1 == "Advance");
            Assert.IsTrue(score.Item2 == "");
        }

        [TestMethod]
        public void Player2ShouldAdvanceAfterDouce()
        {
            IGame game = new Game();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            game.BallWonByPlayer1();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            Tuple<string, string> score = game.CheckScore();
            Assert.IsTrue(score.Item1 == "");
            Assert.IsTrue(score.Item2 == "Advance");
        }

        [TestMethod]
        public void Player1ShouldWinTheGameAfterAdvance()
        {
            IGame game = new Game();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            Tuple<string, string> score = game.CheckScore();
            Assert.IsTrue(score.Item1 == "Winner");
            Assert.IsTrue(score.Item2 == "");
        }


        [TestMethod]
        public void Player2ShouldWinTheGameAfterAdvance()
        {
            IGame game = new Game();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            game.BallWonByPlayer1();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            game.BallWonByPlayer2();
            Tuple<string, string> score = game.CheckScore();
            Assert.IsTrue(score.Item1 == "");
            Assert.IsTrue(score.Item2 == "Winner");
        }
    }
}
