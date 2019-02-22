using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.FluentConfigurations
{
    public class MatchBetEntityConfiguration : EntityTypeConfiguration<MatchBet>
    {
        public MatchBetEntityConfiguration()
        {
            this.HasKey(x => x.MatchBetId).HasRequired(x => x.Match).WithRequiredDependent();
            this.Property(x => x.MatchBetId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}
