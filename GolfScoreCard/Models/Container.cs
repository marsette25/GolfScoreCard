using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolfScoreCard.Models
{
    public class Container
    {
        public int ContainerId { get; set; }
        public string Title { get; set; }
        public ApplicationUser Owner { get; set; }
        public virtual List<GolfCourseList> Lists { get; set; }
        public  virtual List<ApplicationUser> Followers { get; set; }

        public Container()
        {
            Lists = new List<GolfCourseList>();
            Followers = new List<ApplicationUser>();
        }
    }
}