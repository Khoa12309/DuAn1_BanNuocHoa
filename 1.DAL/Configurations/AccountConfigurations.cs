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
    public class AccountConfigurations : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TaiKhoan).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.MatKhau).HasColumnType("nvarchar(100)").IsRequired();

           // builder.HasOne(x => x.NhanVien).WithOne().HasForeignKey<NhanVien>(x=>x.Id);

        }
    }
}
