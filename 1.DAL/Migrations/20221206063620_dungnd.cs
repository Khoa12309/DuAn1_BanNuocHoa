using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
<<<<<<<< HEAD:1.DAL/Migrations/20221207145752_migration.cs
    public partial class migration : Migration
========
    public partial class dungnd : Migration
>>>>>>>> origin/Dungndph20833:1.DAL/Migrations/20221206063620_dungnd.cs
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaiKhoan = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HangSp",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHang = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TenHang = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangSp", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKH = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    STD = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kho",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HangTon = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    HangDoiTra = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kho", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKM = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GiaTriKM = table.Column<double>(type: "float", nullable: false),
                    NgayBD = table.Column<DateTime>(type: "DateTime", nullable: false),
                    NgayKT = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaloaiSp = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TenloaiSp = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNV = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    STD = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ChucVu = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_Account_Id",
                        column: x => x.Id,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaGH = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DonGia = table.Column<float>(type: "real", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GioHang_KhachHang_IDKH",
                        column: x => x.IDKH,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDLSp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSp = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TenSp = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MuiHuong = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DungTich = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    HinhAnh = table.Column<byte[]>(type: "image", nullable: false),
                    Solong = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    GiaNhap = table.Column<double>(type: "float", nullable: false),
                    GiaBan = table.Column<double>(type: "float", nullable: false),
                    LoaiSpId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SanPham_HangSp_IDHang",
                        column: x => x.IDHang,
                        principalTable: "HangSp",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSp_LoaiSpId",
                        column: x => x.LoaiSpId,
                        principalTable: "LoaiSp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKM = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHD = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NgayMua = table.Column<DateTime>(type: "DateTime", nullable: false),
                    TongTien = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_IdKH",
                        column: x => x.IdKH,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhuyenMai_IdKM",
                        column: x => x.IdKM,
                        principalTable: "KhuyenMai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_IdNV",
                        column: x => x.IdNV,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHangChiTiet",
                columns: table => new
                {
                    IdGH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangChiTiet", x => new { x.IdGH, x.IdSP });
                    table.ForeignKey(
                        name: "FK_GioHangChiTiet_GioHang_IdGH",
                        column: x => x.IdGH,
                        principalTable: "GioHang",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHangChiTiet_SanPham_IdSP",
                        column: x => x.IdSP,
                        principalTable: "SanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaoHanh",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaBH = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "DateTime", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaoHanh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaoHanh_HoaDon_IdHD",
                        column: x => x.IdHD,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    IdHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => new { x.IdHD, x.IdSP });
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_IdHD",
                        column: x => x.IdHD,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_SanPham_IdSP",
                        column: x => x.IdSP,
                        principalTable: "SanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaoHanh_IdHD",
                table: "BaoHanh",
                column: "IdHD");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_IDKH",
                table: "GioHang",
                column: "IDKH");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiet_IdSP",
                table: "GioHangChiTiet",
                column: "IdSP");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKH",
                table: "HoaDon",
                column: "IdKH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKM",
                table: "HoaDon",
                column: "IdKM");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNV",
                table: "HoaDon",
                column: "IdNV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdSP",
                table: "HoaDonChiTiet",
                column: "IdSP");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_IDHang",
                table: "SanPham",
                column: "IDHang");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_LoaiSpId",
                table: "SanPham",
                column: "LoaiSpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaoHanh");

            migrationBuilder.DropTable(
                name: "GioHangChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "Kho");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "KhuyenMai");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "HangSp");

            migrationBuilder.DropTable(
                name: "LoaiSp");

            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}
