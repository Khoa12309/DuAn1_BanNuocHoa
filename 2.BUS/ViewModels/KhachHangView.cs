﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
   public class KhachHangView
    {
        public Guid Id { get; set; }
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string STD { get; set; }
    }
}
