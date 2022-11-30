﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.ContextDataBase;

namespace _1.DAL.Migrations
{
    [DbContext(typeof(ContextDB))]
    partial class ContextDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_1.DAL.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TaiKhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("_1.DAL.Models.BaoHanh", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaBH")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("DateTime");

                    b.HasKey("Id");

                    b.HasIndex("IdHD");

                    b.ToTable("BaoHanh");
                });

            modelBuilder.Entity("_1.DAL.Models.GioHang", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("DonGia")
                        .HasColumnType("real");

                    b.Property<Guid>("IDKH")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaGH")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("DateTime");

                    b.Property<string>("TinhTrang")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.HasIndex("IDKH");

                    b.ToTable("GioHang");
                });

            modelBuilder.Entity("_1.DAL.Models.GioHangChiTiet", b =>
                {
                    b.Property<Guid>("IdGH")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<double>("SoLuong")
                        .HasColumnType("float");

                    b.HasKey("IdGH", "IdSP");

                    b.HasIndex("IdSP");

                    b.ToTable("GioHangChiTiet");
                });

            modelBuilder.Entity("_1.DAL.Models.HangSp", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("MaHang");

                    b.Property<string>("TenHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenHang");

                    b.HasKey("ID");

                    b.ToTable("HangSp");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKH")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKM")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNV")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaHD")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("NgayMua")
                        .HasColumnType("DateTime");

                    b.Property<double>("TongTien")
                        .HasColumnType("float");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdKH");

                    b.HasIndex("IdKM");

                    b.HasIndex("IdNV");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("IdHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<double>("SoLuong")
                        .HasColumnType("float");

                    b.HasKey("IdHD", "IdSP");

                    b.HasIndex("IdSP");

                    b.ToTable("HoaDonChiTiet");
                });

            modelBuilder.Entity("_1.DAL.Models.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MaKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("STD")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("_1.DAL.Models.Kho", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Hangdoitra")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("HangDoiTra");

                    b.Property<string>("Hangton")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("HangTon");

                    b.HasKey("Id");

                    b.ToTable("Kho");
                });

            modelBuilder.Entity("_1.DAL.Models.KhuyenMai", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("GiaTriKM")
                        .HasColumnType("float");

                    b.Property<string>("MaKM")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("NgayBD")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("NgayKT")
                        .HasColumnType("DateTime");

                    b.HasKey("Id");

                    b.ToTable("KhuyenMai");
                });

            modelBuilder.Entity("_1.DAL.Models.LoaiSp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaloaiSp")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("MaloaiSp");

                    b.Property<string>("TenloaiSp")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenloaiSp");

                    b.HasKey("Id");

                    b.ToTable("LoaiSp");
                });

            modelBuilder.Entity("_1.DAL.Models.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MaNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("STD")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.Models.SanPham", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DungTich")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("GiaBan")
                        .HasColumnType("float");

                    b.Property<double>("GiaNhap")
                        .HasColumnType("float");

                    b.Property<byte[]>("HinhAnh")
                        .IsRequired()
                        .HasColumnType("image");

                    b.Property<Guid>("IDHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDKho")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDLSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaSp")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("MaSp");

                    b.Property<string>("MuiHuong")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Solong")
                        .HasColumnType("int");

                    b.Property<string>("TenSp")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDHang");

                    b.HasIndex("IDKho");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("_1.DAL.Models.BaoHanh", b =>
                {
                    b.HasOne("_1.DAL.Models.HoaDon", "HoaDon")
                        .WithMany()
                        .HasForeignKey("IdHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("_1.DAL.Models.GioHang", b =>
                {
                    b.HasOne("_1.DAL.Models.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("IDKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("_1.DAL.Models.GioHangChiTiet", b =>
                {
                    b.HasOne("_1.DAL.Models.GioHang", "GioHang")
                        .WithMany()
                        .HasForeignKey("IdGH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("IdSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GioHang");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDon", b =>
                {
                    b.HasOne("_1.DAL.Models.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("IdKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.KhuyenMai", "KhuyenMai")
                        .WithMany()
                        .HasForeignKey("IdKM")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("IdNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("KhuyenMai");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("_1.DAL.Models.HoaDon", "HoaDon")
                        .WithMany()
                        .HasForeignKey("IdHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("IdSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("_1.DAL.Models.NhanVien", b =>
                {
                    b.HasOne("_1.DAL.Models.Account", null)
                        .WithOne("NhanVien")
                        .HasForeignKey("_1.DAL.Models.NhanVien", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("_1.DAL.Models.SanPham", b =>
                {
                    b.HasOne("_1.DAL.Models.HangSp", "HangSp")
                        .WithMany()
                        .HasForeignKey("IDHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.Kho", "Kho")
                        .WithMany()
                        .HasForeignKey("IDKho")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.LoaiSp", "LoaiSp")
                        .WithMany()
                        .HasForeignKey("IDKho")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HangSp");

                    b.Navigation("Kho");

                    b.Navigation("LoaiSp");
                });

            modelBuilder.Entity("_1.DAL.Models.Account", b =>
                {
                    b.Navigation("NhanVien");
                });
#pragma warning restore 612, 618
        }
    }
}
