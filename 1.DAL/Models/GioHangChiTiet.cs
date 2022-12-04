using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class GioHangChiTiet
    {
        public Guid IdGH { get; set; }
        public Guid IdSP { get; set; }
        public float DonGia { get; set; }
        public float SoLuong { get; set; }
        public virtual SanPham? SanPham { get; set; }

        public virtual GioHang? GioHang { get; set; }

    }
}
