using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.FluentConfigurations
{
    public class LegacyBetEntityConfiguration : EntityTypeConfiguration<LegacyBet>
    {
        public LegacyBetEntityConfiguration()
        {
            this.HasKey(x => x.LegacyBetId).HasRequired(x => x.Image).WithRequiredDependent();
            this.Property(x => x.LegacyBetId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}
