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
    public class GioHangChiTietConfigurations : IEntityTypeConfiguration<GioHangChiTiet>
    {
        public void Configure(EntityTypeBuilder<GioHangChiTiet> builder)
        {
            builder.ToTable("GioHangChiTiet");
            builder.HasKey(x => new {x.IdGH,x.IdSP});
            builder.Property(x => x.SoLuong).HasColumnType("float").IsRequired();
            builder.Property(x => x.DonGia).HasColumnType("float").IsRequired();

            builder.HasOne(x => x.SanPham).WithMany().HasForeignKey(x => x.IdSP);
            builder.HasOne(x => x.GioHang).WithMany().HasForeignKey(x => x.IdGH);



        }
    }
}
