using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class BaoHanh
    {
        public Guid Id { get; set; }
        public Guid IdHD { get; set; }
        public string MaBH{ get; set; }
        public  DateTime NgayBatDau { get; set; }
        public  DateTime NgayKetThuc { get; set; }

        public virtual HoaDon? HoaDon { get; set; }
    }
}
