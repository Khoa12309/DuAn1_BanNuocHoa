using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
   public class SanPhamView
    {
        public Guid ID { get; set; }
        public Guid IDSp { get; set; }
        public Guid IDKho { get; set; }
        public Guid IDHang { get; set; }

        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public string MuiHuong { get; set; }
        public string DungTich { get; set; }

        public byte[] HinhAnh { get; set; }
        public int Solong { get; set; }
        public int TrangThai { get; set; }
        public float GiaNhap { get; set; }
        public float GiaBan { get; set; }

    }
}
