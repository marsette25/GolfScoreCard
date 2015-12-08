using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GolfScoreCard.Models;

namespace GolfScoreCard.Tests.Models
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void NewGameEnsureICanCreateInstance()
        {
            Game newgame = new Game();
            Assert.IsNotNull(newgame);
        }

        [TestMethod]
        public void NewGameInformationEnsurePropertiesWork()
        {
            Game newgame = new Game { ScoreHoleOne = 3 };
        }
    }
}
