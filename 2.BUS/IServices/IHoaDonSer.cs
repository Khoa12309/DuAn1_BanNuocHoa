using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IHoaDonSer
    {
        public string Add(HoaDonView obj);
        public string Update(HoaDonView obj);
        public string Delete(HoaDonView obj);

        List<HoaDonView> HdGetAll();
    }
}
