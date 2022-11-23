using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configurations
{
    public class KhoConfigurations : IEntityTypeConfiguration<Kho>
    {
        public void Configure(EntityTypeBuilder<Kho> builder)
        {
            builder.ToTable("Kho");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Hangdoitra).HasColumnName("HangDoiTra").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.Hangton).HasColumnName("HangTon").HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
