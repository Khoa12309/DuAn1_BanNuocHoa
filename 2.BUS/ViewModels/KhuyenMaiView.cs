using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class KhuyenMaiView
    {
        public Guid Id { get; set; }
        public string MaKM { get; set; }
        public float GiaTriKM { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKT { get; set; }
    }
}
