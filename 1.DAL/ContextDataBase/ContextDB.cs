using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.ContextDataBase
{
    public class ContextDB : DbContext
    {

        public ContextDB()
        {
        }
        public ContextDB(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Thực hiện các ràng buộc kết nối
            base.OnConfiguring(optionsBuilder.
                UseSqlServer("Data Source=LAPTOP-N6FK027M;Initial Catalog=DABanNuocHoa;" +
                "Persist Security Info=True;User ID=khoaph20877;Password=123456"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public virtual DbSet<Account> accounts { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<BaoHanh> BaoHanhs { get; set; }
        public virtual DbSet<GioHang> GioHangs { get; set; }
        public virtual DbSet<GioHangChiTiet> GioHangChiTiets { get; set; }
        public virtual DbSet<HangSp> HangSps { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Kho> Khos { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<LoaiSp> LoaiSps  { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

    }
}
