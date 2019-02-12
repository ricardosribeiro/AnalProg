using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Map
{
    public class SalesOrderMap: EntityTypeConfiguration<SalesOrder>
    {
        public SalesOrderMap()
        {
            ToTable("SalesOrder");

            HasKey(p => p.Id)
                .Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(p => p.Title)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);

            Property(p => p.Value)
                .IsRequired();

            Property(p => p.Description)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);
        }
    }
}
