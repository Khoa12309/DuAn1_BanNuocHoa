using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
   public class AccountView
    {
        public Guid Id { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string ChucVu { get; set; }

        
    }
}
