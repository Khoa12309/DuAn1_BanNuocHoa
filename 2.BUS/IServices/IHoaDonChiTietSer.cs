using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IHoaDonChiTietSer
    {
        public string Add(HoaDonChiTietView obj);
        public string Update(HoaDonChiTietView obj);
        public string Delete(HoaDonChiTietView obj);

        List<HoaDonChiTietView> HDCTGetAll();
    }
}
