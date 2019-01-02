using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.FluentConfigurations
{
    public class BetImageEntityConfiguration : EntityTypeConfiguration<BetImage>
    {
        public BetImageEntityConfiguration()
        {
            this.HasKey(x => x.BetImageId);
        }
    }
}
