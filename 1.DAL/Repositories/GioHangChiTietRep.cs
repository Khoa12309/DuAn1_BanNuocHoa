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
    public class GioHangChiTietRep : IGioHangChiTietRepcs
    {
        private ContextDB _Dbcontext;
        private List<GioHangChiTiet> _lisGHCT;
        public GioHangChiTietRep()
        {
            _Dbcontext = new ContextDB();
            _lisGHCT = new List<GioHangChiTiet>();  
        }

        public bool Add(GioHangChiTiet obj)
        {
            if (obj == null)
            {
                return false;
            }
            _Dbcontext.Add(obj);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(GioHangChiTiet obj)
        {
            if (obj == null) return false;
            var temp = _Dbcontext.GioHangChiTiets.FirstOrDefault(c => c.IdGH == obj.IdGH);
            _Dbcontext.Remove(temp);
            _Dbcontext.SaveChanges();
            return true;
        }

        public List<GioHangChiTiet> GhCtGetAll()
        {
            _lisGHCT = _Dbcontext.GioHangChiTiets.ToList();
            return _lisGHCT;
        }

        public bool Update(GioHangChiTiet obj)
        {
            if (obj == null) return false;
            var temp = _Dbcontext.GioHangChiTiets.FirstOrDefault(c => c.IdGH == obj.IdGH);
            temp.SoLuong = obj.SoLuong;
            temp.DonGia = obj.DonGia;

            _Dbcontext.GioHangChiTiets.Update(temp);
            _Dbcontext.SaveChanges();
            return true;
        }
    }
}
