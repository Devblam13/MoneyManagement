using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace DataAccessLayer.FluentConfigurations
{
    public class TeamEntityConfiguration : EntityTypeConfiguration<Team>
    {
        public TeamEntityConfiguration()
        {
            this.HasKey(x => x.TeamId).Property(x => x.TeamName).IsRequired().HasMaxLength(100)
                .HasColumnAnnotation("TeamName", new IndexAnnotation(new[] { new IndexAttribute("TeamName") { IsUnique = true } }));
            this.Property(x => x.TeamId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}
