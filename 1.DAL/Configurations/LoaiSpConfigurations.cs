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
    public class LoaiSpConfigurations : IEntityTypeConfiguration<LoaiSp>
    {
        public void Configure(EntityTypeBuilder<LoaiSp> builder)
        {
            builder.ToTable("LoaiSp");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MaloaiSp).HasColumnName("MaloaiSp").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.TenloaiSp).HasColumnName("TenloaiSp").HasColumnType("nvarchar(100)").IsRequired();
            
        }
    }
}
