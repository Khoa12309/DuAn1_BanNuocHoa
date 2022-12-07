using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
   public class NhanVien
    {
        public Guid Id { get; set; }
        public string? MaNV { get; set; }
        public string? TenNV { get; set; }
        public string? GioiTinh { get; set; }
        public string? DiaChi { get; set; }
        public int? TrangThai { get; set; }
        public string? STD { get; set; }
        public string? ChucVu { get; set; }
        public string? Email { get; set; }
        public byte[]? HinhAnh { get; set; }

        public virtual  Account? Account { get; set; }    
    }
}
