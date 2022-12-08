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
    public class BaoHanhConfigurations : IEntityTypeConfiguration<BaoHanh>
    {
        public void Configure(EntityTypeBuilder<BaoHanh> builder)
        {
            builder.ToTable("BaoHanh");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MaBH).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.NgayBatDau).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.NgayKetThuc).HasColumnType("DateTime").IsRequired();

            builder.HasOne(x => x.HoaDon).WithMany().HasForeignKey(x=>x.IdHD);
        }
    }
}
