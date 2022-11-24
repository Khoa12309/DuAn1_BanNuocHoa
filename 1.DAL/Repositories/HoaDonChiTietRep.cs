using _1.DAL.ContextDataBase;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class HoaDonChiTietRep : IHoaDonChiTietRepcs
    {
        private ContextDB _Dbcontext;
        private List<HoaDonChiTiet> _lstHDCT;
        public HoaDonChiTietRep()
        {
            _Dbcontext = new ContextDB();
            _lstHDCT = new List<HoaDonChiTiet>();
        }

        public bool Add(HoaDonChiTiet obj)
        {
            if (obj == null)
            {
                return false;
            }
            _Dbcontext.Add(obj);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var temp = _Dbcontext.HoaDonChiTiets.FirstOrDefault(c => c.IdHD == obj.IdHD);
            _Dbcontext.Remove(temp);
            _Dbcontext.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetAllHDCT()
        {
            _lstHDCT = _Dbcontext.HoaDonChiTiets.ToList();
            return _lstHDCT;
        }

        public bool Update(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var temp = _Dbcontext.HoaDonChiTiets.FirstOrDefault(c => c.IdHD == obj.IdHD);
            temp.DonGia=obj.DonGia;
            temp.SoLuong=obj.SoLuong;
            _Dbcontext.HoaDonChiTiets.Update(temp);
            _Dbcontext.SaveChanges();
            return true;
        }
    }
}
