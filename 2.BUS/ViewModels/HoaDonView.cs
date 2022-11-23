using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class HoaDonView
    {
        public Guid Id { get; set; }
        public Guid IdKH { get; set; }
        public Guid IdKM { get; set; }
        public Guid IdNV { get; set; }
        public string MaHD { get; set; }
        public string TrangThai { get; set; }
        public DateTime NgayMua { get; set; }
        public float TongTien { get; set; }

    }
}
