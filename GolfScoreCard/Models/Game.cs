using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolfScoreCard.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string Title { get; set; }
        public ApplicationUser Owner { get; set; }

        // Changed from ICollection to List
        public virtual List<GameInformation> GamesPlayed { get; set; }
        public virtual List<ApplicationUser> Followers { get; set; }

        public Game()
        {
            GamesPlayed = new List<GameInformation>();
            Followers = new List<ApplicationUser>();
        }

    }
}