using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.FluentConfigurations
{
    public class AccountEntityConfiguration : EntityTypeConfiguration<Account>
    {
        public AccountEntityConfiguration()
        {
            this.HasKey(x => x.AccountId).Property(x => x.AccountId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(x => x.UserId).IsRequired();
        }
    }
}
