using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IGioHangChiTietSer
    {
        public string Add(GioHangChiTietView obj);
        public string Update(GioHangChiTietView obj);
        public string Delete(GioHangChiTietView obj);

        List<GioHangChiTietView> GHCTGetAll();
    }
}
