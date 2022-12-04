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
    public class NhanVienConfigurations : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MaNV).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.STD).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.TenNV).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.DiaChi).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.GioiTinh).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.TrangThai).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.ChucVu).HasColumnType("nvarchar(100)").IsRequired();

        }
    }
}
