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
    public class HangConfigurations : IEntityTypeConfiguration<HangSp>
    {
        public void Configure(EntityTypeBuilder<HangSp> builder)
        {
            builder.ToTable("HangSp");
            builder.HasKey(x => x.ID);       
            builder.Property(x => x.MaHang).HasColumnName("MaHang").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.TenHang).HasColumnName("TenHang").HasColumnType("nvarchar(100)").IsRequired();


        }
    }
}
