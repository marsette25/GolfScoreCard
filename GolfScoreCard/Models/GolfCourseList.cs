using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolfScoreCard.Models
{
    public class GolfCourseList
    {
        public int GolfCourseListId { get; set; }
        public string GolfCourseName { get; set; }
        public DateTime GolfCoursePlayedDate { get; set; }
        public List<GolfCourseYards> Yards {get; set;}
        public List<GolfCoursePar> Par { get; set; }

    }
}