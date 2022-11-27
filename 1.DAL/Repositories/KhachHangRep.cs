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
            _Dbcontext.Add(obj);
            _Dbcontext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAllKh()
        {
            throw new NotImplementedException();
        }

        public bool Update(KhachHang obj)
        {
            throw new NotImplementedException();
        }
    }
}
