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
            this.HasKey(x => x.LegacyBetId);
        }
    }
}
