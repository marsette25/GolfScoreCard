using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolfScoreCard.Models
{
    public class GameInformation
    {
        public int GameInformationId { get; set; }
        public List<ApplicationUser> User { get; set; }
        public List<GolfCourseInformation> CourseName { get; set; }
        public List<GolfCourseInformation> FrontNine { get; set; }
        public List<GolfCourseInformation> BackNine { get; set; }
        public List<GolfCourseInformation> DefaultEighteen { get; set; }
        public DateTime GamePlayedDate { get; set; }
        public int ScoreHoleOne { get; set; }
        public int ScoreHoleTwo { get; set; }
        public int ScoreHoleThree { get; set; }
        public int ScoreHoleFour { get; set; }
        public int ScoreHoleFive { get; set; }
        public int ScoreHoleSix { get; set; }
        public int ScoreHoleSeven { get; set; }
        public int ScoreHoleEight { get; set; }
        public int ScoreHoleNine { get; set; }
        public int ScoreHoleTen { get; set; }
        public int ScoreHoleEleven { get; set; }
        public int ScoreHoleTwelve { get; set; }
        public int ScoreHoleThirteen { get; set; }
        public int ScoreHoleFourteen { get; set; }
        public int ScoreHoleFifteen { get; set; }
        public int ScoreHoleSixteen { get; set; }
        public int ScoreHoleSeventeen { get; set; }
        public int ScoreHoleEighteen { get; set; }

    }
}