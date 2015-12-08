﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GolfScoreCard.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GolfScoreCard.Models
{

    public class GameInformationContext : DbContext
    {


        // Uses the connection string from the Web.config named "BoardContext"
        
        public GameInformationContext() : base ("GameInformation")
        {
            
        }

        public virtual IDbSet<GolfCourseInformation> GolfCourseInformation { get; set; }
        public virtual DbSet<Game> Game { get; set; }

        // IQueryable, IList/List, ICollection/Collection, IDbSet/Dbset

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}