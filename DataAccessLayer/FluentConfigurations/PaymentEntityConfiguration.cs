using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.FluentConfigurations
{
    public class PaymentEntityConfiguration : EntityTypeConfiguration<Payment>
    {
        public PaymentEntityConfiguration()
        {
            this.HasKey(x => x.PaymentId);
            this.Property(x => x.PaymentId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}
