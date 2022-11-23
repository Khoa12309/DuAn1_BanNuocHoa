using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonChiTietRepcs
    {
        public bool Add(HoaDonChiTiet obj);
        public bool Update(HoaDonChiTiet obj);
        public bool Delete(HoaDonChiTiet obj);
        public List<HoaDonChiTiet> GetAllHDCT();
    }
}
