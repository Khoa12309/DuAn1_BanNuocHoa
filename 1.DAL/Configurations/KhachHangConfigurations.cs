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
    public class KhachHangConfigurations : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("KhachHang");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MaKH).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.STD).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.TenKH).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.DiaChi).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.GioiTinh).HasColumnType("nvarchar(100)").IsRequired();

        }
    }
}
