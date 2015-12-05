using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolfScoreCard.Models
{
    public class GolfCourseYards

    {
        public int GolfCourseYardsID { get; set; }
        public List<BlueYards> Blue { get; set; }
        public List<YellowYards>Yellow { get; set; }
        public List<WhiteYards> White { get; set; }
        public List<RedYards> Red { get; set; }
    }
}