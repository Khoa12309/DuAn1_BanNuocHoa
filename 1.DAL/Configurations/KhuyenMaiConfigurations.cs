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
    public class KhuyenMaiConfigurations : IEntityTypeConfiguration<KhuyenMai>
    {
        public void Configure(EntityTypeBuilder<KhuyenMai> builder)
        {
            builder.ToTable("KhuyenMai");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MaKM).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.GiaTriKM).HasColumnType("float").IsRequired();
            builder.Property(x => x.NgayBD).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.NgayKT).HasColumnType("DateTime").IsRequired();

        }
    }
}
