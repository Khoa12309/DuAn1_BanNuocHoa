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
    public class HoaDonChiTietConfigurations : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiet");
            builder.HasKey(x => new {x.IdHD,x.IdSP});
            builder.Property(x => x.SoLuong).HasColumnType("float").IsRequired();
            builder.Property(x => x.DonGia).HasColumnType("float").IsRequired();

            builder.HasOne(x => x.HoaDon).WithMany().HasForeignKey(x => x.IdHD);
            builder.HasOne(x => x.SanPham).WithMany().HasForeignKey(x => x.IdSP);

        }
    }
}
