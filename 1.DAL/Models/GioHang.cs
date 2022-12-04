using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public  class GioHang
    {
        public Guid ID { get; set; }
        public Guid IDKH { get; set; }
        public string MaGH { get; set; }
        public float DonGia { get; set; }
        public string TinhTrang { get; set; }
        public DateTime NgayTao { get; set; }

        public virtual KhachHang? KhachHang { get; set; }
    }
}
