using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.FluentConfigurations
{
    public class MatchEntityConfiguration : EntityTypeConfiguration<Match>
    {
        public MatchEntityConfiguration()
        {
            this.HasKey(x => x.MatchId);
        }
    }
}
