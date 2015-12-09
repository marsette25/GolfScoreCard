using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GolfScoreCard.Models;

namespace GolfScoreCard.Tests.Models
{
    [TestClass]
    public class GolfCourseInformationTests
    {
        [TestMethod]
        public void GolfCourseInformationEnsureICanCreateInstance()
        {
            Game newgame = new Game();
            Assert.IsNotNull(newgame);
        }

        [TestMethod]
        public void GolfCourseInformationEnsurePropertiesWork()
        {
            Game newgame = new Game { ScoreHoleOne = 3 };
        }
    }
}
