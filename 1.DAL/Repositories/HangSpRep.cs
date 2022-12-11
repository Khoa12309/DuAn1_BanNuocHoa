using _1.DAL.ContextDataBase;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class HangSpRep : IHangSpRep
    {
        private ContextDB _Dbcontext;
        private List<HangSp> _lstHang;
        public HangSpRep()
        {
                _Dbcontext= new ContextDB();
            _lstHang = new List<HangSp>();

        }

        public bool Add(HangSp obj)
        {
            if (obj == null)
            {
                return false;
            }
            _Dbcontext.Add(obj);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(HangSp obj)
        {
            if (obj == null) return false;
            var temp = _Dbcontext.HangSps.FirstOrDefault(c => c.ID == obj.ID);
            _Dbcontext.Remove(temp);
            _Dbcontext.SaveChanges();
            return true;
        }

        public List<HangSp> GetAllHsp()
        {
            _lstHang = _Dbcontext.HangSps.ToList();
            return _lstHang;
        }

        public bool Update(HangSp obj)
        {
            if (obj == null) return false;
            var temp = _Dbcontext.HangSps.FirstOrDefault(c => c.ID == obj.ID);
            temp.TenHang = obj.TenHang;
            temp.MaHang = obj.MaHang;
           
            _Dbcontext.HangSps.Update(temp);
            _Dbcontext.SaveChanges();
            return true;
        }
    }
}
