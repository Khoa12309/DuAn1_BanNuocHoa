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
    public class SanPhamConfigurations : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("SanPham");
            builder.HasKey(x=>x.ID);
            builder.Property(x => x.MaSp).HasColumnName("MaSp").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.TenSp).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.MuiHuong).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.DungTich).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.HinhAnh).HasColumnType("image").IsRequired();
           
            builder.Property(x => x.Solong).HasColumnType("int").IsRequired();
            builder.Property(x => x.TrangThai).HasColumnType("int").IsRequired();
            builder.Property(x => x.GiaBan).HasColumnType("float").IsRequired();
            builder.Property(x => x.GiaNhap).HasColumnType("float").IsRequired();

            
            builder.HasOne(x=>x.HangSp).WithMany().HasForeignKey(x=>x.IDHang);
            builder.HasOne(x=>x.LoaiSp).WithMany().HasForeignKey(x=>x.IDLSp);
        }
    }
}
