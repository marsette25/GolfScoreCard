using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GolfScoreCard.Models;

namespace GolfScoreCard.Tests.Controllers.Models
{
    [TestClass]
    public class GameInformationTests
    {
        [TestMethod]
        public void GameInformationEnsureICanCreateInstance()
        {
            GameInformation newgame = new GameInformation();
            Assert.IsNotNull(newgame);
        }

        [TestMethod]
        public void GameInformationEnsurePropertiesWork()
        {
            GameInformation newgame = new GameInformation { ScoreHoleOne = 3 };
        }
    }
}
