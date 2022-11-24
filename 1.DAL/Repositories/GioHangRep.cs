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
    public class GioHangRep : IGioHangRep
    {
        private ContextDB _Dbcontext;
        private List<GioHang> _lisGH;
        public GioHangRep()
        {
                _Dbcontext=new ContextDB();
            _lisGH=new List<GioHang>();
        }

        public bool Add(GioHang obj)
        {
            if (obj == null)
            {
                return false;
            }
            _Dbcontext.Add(obj);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(GioHang obj)
        {
            if (obj == null) return false;
            var temp = _Dbcontext.GioHangs.FirstOrDefault(c => c.ID == obj.ID);
            _Dbcontext.Remove(temp);
            _Dbcontext.SaveChanges();
            return true;
        }

        public List<GioHang> GetAllGh()
        {
            _lisGH = _Dbcontext.GioHangs.ToList();
            return _lisGH;
        }

        public bool Update(GioHang obj)
        {
            if (obj == null) return false;
            var temp = _Dbcontext.GioHangs.FirstOrDefault(c => c.ID == obj.ID);
            temp.TinhTrang = obj.TinhTrang;
            temp.NgayTao = obj.NgayTao;
            _Dbcontext.GioHangs.Update(temp);
            _Dbcontext.SaveChanges();
            return true;
        }
    }
}
