using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace DataAccessLayer.FluentConfigurations 
{
    public class BetEntityConfiguration: EntityTypeConfiguration<Bet>
    {
        public BetEntityConfiguration()
        {
            this.HasKey(x => x.BetId);
        }
    }
}
