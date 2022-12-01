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
    public class GioHangConfigurations : IEntityTypeConfiguration<GioHang>
    {
        public void Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.ToTable("GioHang");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.MaGH).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.TinhTrang).HasColumnType("int").IsRequired();
            builder.Property(x => x.NgayTao).HasColumnType("DateTime").IsRequired();

            builder.HasOne(x => x.KhachHang).WithMany().HasForeignKey(x => x.IDKH);


        }
    }
}
