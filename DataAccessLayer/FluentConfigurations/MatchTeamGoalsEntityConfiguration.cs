﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.FluentConfigurations
{
    class MatchTeamGoalsEntityConfiguration : EntityTypeConfiguration<MatchTeamGoals>
    {
        public MatchTeamGoalsEntityConfiguration()
        {
            this.HasKey(x => x.MatchTeamGoalsId).HasRequired(x => x.Team).WithRequiredDependent();
            this.Property(x => x.MatchTeamGoalsId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}
