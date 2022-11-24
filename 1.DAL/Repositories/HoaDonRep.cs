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
    public class HoaDonRep : IHoaDonRep
    {
        private ContextDB _Dbcontext;
        private List<HoaDon> _lstHd;
        public HoaDonRep()
        {
            _Dbcontext=new ContextDB();
            _lstHd= new List<HoaDon>();
        }
        public bool Add(HoaDon obj)
        {
            if (obj == null)
            {
                return false;
            }
            _Dbcontext.Add(obj);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon obj)
        {
            if (obj == null) return false;
            var temp = _Dbcontext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
            _Dbcontext.Remove(temp);
            _Dbcontext.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAllHd()
        {
           _lstHd=_Dbcontext.HoaDons.ToList();  
            return _lstHd;
        }

        public bool Update(HoaDon obj)
        {
            if (obj == null) return false;
            var temp = _Dbcontext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
            temp.TrangThai=obj.TrangThai;
            temp.KhuyenMai=obj.KhuyenMai;
            temp.NgayMua=obj.NgayMua;
            _Dbcontext.HoaDons.Update(temp);
            _Dbcontext.SaveChanges();
            return true;
        }
    }
}
