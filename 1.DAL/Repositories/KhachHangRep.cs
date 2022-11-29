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
    public class KhachHangRep : IKhachHangRep
    {
        private ContextDB _Dbcontext;
        private List<KhachHang> _lstKh;
        public KhachHangRep()
        {
            _Dbcontext=new ContextDB();
            _lstKh=new List<KhachHang>();
        }
        public bool Add(KhachHang obj)
        {
            if (obj == null)
            {
                return false;
            }
            _Dbcontext.Add(obj);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            if (obj == null)
            {
                return false;
            }
            var temp = _Dbcontext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
            _Dbcontext.Remove(temp);
            _Dbcontext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAllKh()
        {
            _lstKh = _Dbcontext.KhachHangs.ToList();
            return _lstKh;
        }

        public bool Update(KhachHang obj)
        {
            if (obj == null)
            {
                return false;
            }
            var temp = _Dbcontext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
            temp.STD = obj.STD;
            temp.DiaChi = obj.DiaChi;
            temp.TenKH = obj.TenKH;
            temp.MaKH = obj.MaKH;
            temp.GioiTinh = obj.GioiTinh;
            _Dbcontext.Update(temp);
            _Dbcontext.SaveChanges();
            return true; 
        }
    }
}
