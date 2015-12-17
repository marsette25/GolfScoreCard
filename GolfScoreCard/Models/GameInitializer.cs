//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Data.Entity;
//using GolfScoreCard.Models;

//namespace GolfScoreCard.Models
//{

//    public class GameInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<GameContext>
//    {
//        protected override void Seed(GameContext context)
//        {
//            var golfcourse = new List<GolfCourseInformation>
//            {
//            new GolfCourseInformation{GolfCourseName="Harpeth Hills",BlackHoleOne=372,BlackHoleTwo=364,BlackHoleThree=183,BlackHoleFour=434,BlackHoleFive=556,BlackHoleSix=170,BlackHoleSeven=430,BlackHoleEight=565,BlackHoleNine=411,BlackHoleTen=443,BlackHoleEleven=210,BlackHoleTwelve=343,BlackHoleThirteen=402,BlackHoleFourteen=395,BlackHoleFifteen=167,BlackHoleSixteen=525,BlackHoleSeventeen=502,BlackHoleEighteen=427,BlueHoleOne=352,BlueHoleTwo=338,BlueHoleThree=169,BlueHoleFour=411,BlueHoleFive=530,BlueHoleSix=153,BlueHoleSeven=381,BlueHoleEight=542,BlueHoleNine=397,BlueHoleTen=420,BlueHoleEleven=191,BlueHoleTwelve=318,BlueHoleThirteen=385,BlueHoleFourteen=351,BlueHoleFifteen=155,BlueHoleSixteen=506,BlueHoleSeventeen=481,BlueHoleEighteen=401,YellowHoleOne=289,YellowHoleTwo=294,YellowHoleThree=123,YellowHoleFour=338,YellowHoleFive=473,YellowHoleSix=124,YellowHoleSeven=323,YellowHoleEight=466,YellowHoleNine=315,YellowHoleTen=377,YellowHoleEleven=156,YellowHoleTwelve=276,YellowHoleThirteen=307,YellowHoleFourteen=279,YellowHoleFifteen=96,YellowHoleSixteen=432,YellowHoleSeventeen=442,YellowHoleEighteen=328,WhiteHoleOne=330,WhiteHoleTwo=315,WhiteHoleThree=150,WhiteHoleFour=375,WhiteHoleFive=510,WhiteHoleSix=148,WhiteHoleSeven=355,WhiteHoleEight=493,WhiteHoleNine=377,WhiteHoleTen=415,WhiteHoleEleven=171,WhiteHoleTwelve=312,WhiteHoleThirteen=340,WhiteHoleFourteen=328,WhiteHoleFifteen=145,WhiteHoleSixteen=475,WhiteHoleSeventeen=459,WhiteHoleEighteen=360,RedHoleOne=271,RedHoleTwo=255,RedHoleThree=123,RedHoleFour=338,RedHoleFive=439,RedHoleSix=124,RedHoleSeven=323,RedHoleEight=414,RedHoleNine=261,RedHoleTen=254,RedHoleEleven=154,RedHoleTwelve=252,RedHoleThirteen=307,RedHoleFourteen=279,RedHoleFifteen=96,RedHoleSixteen=335,RedHoleSeventeen=424,RedHoleEighteen=255,ParHoleOne=4,ParHoleTwo=4,ParHoleThree=3,ParHoleFour=4,ParHoleFive=5,ParHoleSix=3,ParHoleSeven=4,ParHoleEight=5,ParHoleNine=4,ParHoleTen=4,ParHoleEleven=3,ParHoleTwelve=4,ParHoleThirteen=4,ParHoleFourteen=4,ParHoleFifteen=3,ParHoleSixteen=5,ParHoleSeventeen=5,ParHoleEighteen=4}
//            };
   
//            golfcourse.ForEach(s => context.GolfCourseInformation.Add(s));
//            context.SaveChanges();
//            var games = new List<Game>
//            {
//            new Game{GamePlayedDate=DateTime.Parse("2015-09-01"),ScoreHoleOne=5,ScoreHoleTwo=8,ScoreHoleThree=2,ScoreHoleFour=3,ScoreHoleFive=5,ScoreHoleSix=7,ScoreHoleSeven=6,ScoreHoleEight=3,ScoreHoleNine=2,ScoreHoleTen=6,ScoreHoleEleven=11,ScoreHoleTwelve=7,ScoreHoleThirteen=3,ScoreHoleFourteen=4,ScoreHoleFifteen=5,ScoreHoleSixteen=6,ScoreHoleSeventeen=7,ScoreHoleEighteen=5},
//            new Game{GamePlayedDate=DateTime.Parse("2015-10-01"),ScoreHoleOne=2,ScoreHoleTwo=8,ScoreHoleThree=2,ScoreHoleFour=3,ScoreHoleFive=5,ScoreHoleSix=7,ScoreHoleSeven=6,ScoreHoleEight=3,ScoreHoleNine=2,ScoreHoleTen=6,ScoreHoleEleven=11,ScoreHoleTwelve=7,ScoreHoleThirteen=3,ScoreHoleFourteen=54,ScoreHoleFifteen=5,ScoreHoleSixteen=6,ScoreHoleSeventeen=15,ScoreHoleEighteen=10},
//            new Game{GamePlayedDate=DateTime.Parse("2015-06-29"),ScoreHoleOne=12,ScoreHoleTwo=38,ScoreHoleThree=32,ScoreHoleFour=3,ScoreHoleFive=5,ScoreHoleSix=7,ScoreHoleSeven=6,ScoreHoleEight=3,ScoreHoleNine=2,ScoreHoleTen=6,ScoreHoleEleven=11,ScoreHoleTwelve=7,ScoreHoleThirteen=3,ScoreHoleFourteen=4,ScoreHoleFifteen=5,ScoreHoleSixteen=6,ScoreHoleSeventeen=7,ScoreHoleEighteen=5}
//            };
//            games.ForEach(s => context.Game.Add(s));
//            context.SaveChanges();

//        }
//    }
//}