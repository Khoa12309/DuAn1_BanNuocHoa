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
    public class HoaDonConfigurations : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MaHD).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.TrangThai).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.NgayMua).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.TongTien).HasColumnType("float").IsRequired();

            builder.HasOne(x => x.KhachHang).WithMany().HasForeignKey(x => x.IdKH);
            builder.HasOne(x => x.KhuyenMai).WithMany().HasForeignKey(x => x.IdKM);
            builder.HasOne(x => x.NhanVien).WithMany().HasForeignKey(x => x.IdNV);

        }
    }
}
