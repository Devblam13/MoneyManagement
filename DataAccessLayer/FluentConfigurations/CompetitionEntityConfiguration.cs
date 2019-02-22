using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.FluentConfigurations
{
    public class CompetitionEntityConfiguration : EntityTypeConfiguration<Competition>
    {
        public CompetitionEntityConfiguration()
        {
            this.HasKey(x => x.CompetitionId).Property(x => x.Name).HasColumnAnnotation("Name", new IndexAnnotation(new[] { new IndexAttribute("Name") { IsUnique = true } }));
            this.Property(x => x.CompetitionId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}
