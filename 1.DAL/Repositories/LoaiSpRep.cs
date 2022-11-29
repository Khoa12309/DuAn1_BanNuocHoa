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
    public class LoaiSpRep : ILoaiSpRep
    {
        private ContextDB _Dbcontext;
        private List<LoaiSpRep> _lstLoaiSP;
        public LoaiSpRep()
        {
            _Dbcontext = new ContextDB();
            _lstLoaiSP = new List<LoaiSpRep>();
        }

        public bool Add(LoaiSp obj)
        {
            if (obj == null)
            {
                return false;
            }
            _Dbcontext.Add(obj);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(LoaiSp obj)
        {
            if (obj == null)
            {
                return false;
            }
            var temp = _Dbcontext.LoaiSps.FirstOrDefault(c => c.Id == obj.Id);
            _Dbcontext.Remove(temp);
            _Dbcontext.SaveChanges();
            return true;
        }

        public List<LoaiSp> GetAllLsp()
        {
            //_lstLoaiSP = _Dbcontext.LoaiSps.ToList();
            //return _lstLoaiSP;
        }

        public bool Update(LoaiSp obj)
        {
            if (obj == null)
            {
                return false;
            }
            var temp = _Dbcontext.LoaiSps.FirstOrDefault(c => c.Id == obj.Id);
            temp.MaloaiSp = obj.MaloaiSp;
            temp.TenloaiSp = obj.TenloaiSp;

            _Dbcontext.Update(temp);
            _Dbcontext.SaveChanges();
            return true;
        }
    }
}
