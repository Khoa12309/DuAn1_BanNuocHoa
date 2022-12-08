using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class KhuyenMai
    {
        public Guid Id { get; set; }
        public string MaKM { get; set; }
        public float  GiaTriKM{ get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKT { get; set; }
     
    }
}
