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
    public class BaoHanhRep : IBaoHanhRep
    {
        private ContextDB _Dbcontext;
        private List<BaoHanh> _lstBaoHanh;
        public BaoHanhRep()
        {
            _Dbcontext = new ContextDB();
            _lstBaoHanh = new List<BaoHanh>();  
        }

        public bool Add(BaoHanh obj)
        {
            if (obj == null)
            {
                return false;
            }
            _Dbcontext.Add(obj);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(BaoHanh obj)
        {
            if (obj == null) return false;
            var temp = _Dbcontext.BaoHanhs.FirstOrDefault(c => c.Id == obj.Id);
            _Dbcontext.Remove(temp);
            _Dbcontext.SaveChanges();
            return true;
        }

        public List<BaoHanh> GetAllBh()
        {
            _lstBaoHanh = _Dbcontext.BaoHanhs.ToList();
            return _lstBaoHanh;
        }

        public bool Update(BaoHanh obj)
        {
            if (obj == null) return false;
            var temp = _Dbcontext.BaoHanhs.FirstOrDefault(c => c.Id == obj.Id);
            temp.NgayBatDau=obj.NgayBatDau;
            temp.NgayKetThuc = obj.NgayKetThuc;
        

            _Dbcontext.BaoHanhs.Update(temp);
            _Dbcontext.SaveChanges();
            return true;
        }
    }
}
