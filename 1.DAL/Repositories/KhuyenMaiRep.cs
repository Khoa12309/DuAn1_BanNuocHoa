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
    public class KhuyenMaiRep : IKhuyenMaiRep
    {
        private ContextDB _Dbcontext;
        private List<KhuyenMai> _lstKhuyenMai;
        public KhuyenMaiRep()
        {
            _Dbcontext = new ContextDB();
            _lstKhuyenMai = new List<KhuyenMai>();
        }

        public bool Add(KhuyenMai obj)
        {
            if (obj == null)
            {
                return false;
            }
            _Dbcontext.Add(obj);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(KhuyenMai obj)
        {
            if (obj == null)
            {
                return false;
            }
            var temp = _Dbcontext.KhuyenMais.FirstOrDefault(c => c.Id == obj.Id);
            _Dbcontext.Remove(obj);
            _Dbcontext.SaveChanges();
            return true;
        }

        public List<KhuyenMai> GetAllKm()
        {
            _lstKhuyenMai = _Dbcontext.KhuyenMais.ToList();
            return _lstKhuyenMai;
        }

        public bool Update(KhuyenMai obj)
        {
            if (obj == null)
            {
                return false;
            }
            var temp = _Dbcontext.KhuyenMais.FirstOrDefault(c => c.Id == obj.Id);
            temp.MaKM = obj.MaKM;
            temp.NgayBD = obj.NgayBD;
            temp.GiaTriKM = obj.GiaTriKM;
            temp.NgayKT = obj.NgayKT;
            _Dbcontext.Update(obj);
            _Dbcontext.SaveChanges();
            return true;
        }
    }
}
