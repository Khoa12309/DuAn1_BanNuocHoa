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
    public class NhanVienRep :INhanVienRep
    {
        private ContextDB _Dbcontext;
        private List<NhanVien> _lstNv;
        public NhanVienRep()
        {
            _Dbcontext=new ContextDB();
        }

        public bool Add(NhanVien obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(NhanVien obj)
        {
            throw new NotImplementedException();
        }

        public List<NhanVien> GetAllNv()
        {
           _lstNv=_Dbcontext.NhanViens.ToList();
            return _lstNv;
        }

        public bool Update(NhanVien obj)
        {
            throw new NotImplementedException();
        }
    }
}
