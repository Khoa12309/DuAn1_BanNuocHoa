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
    public class KhoRep : IKhoRep
    {
        private ContextDB _Dbcontext;
        private List<Kho> _lstKho;
        public KhoRep()
        {
            _Dbcontext = new ContextDB();
            _lstKho = new List<Kho>();
        }

        public bool Add(Kho obj)
        {
            if (obj == null)
            {
                return false;
            }
            _Dbcontext.Add(obj);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(Kho obj)
        {
            if (obj == null)
            {
                return false;
            }
            var temp = _Dbcontext.Khos.FirstOrDefault(c => c.Id == obj.Id);
            _Dbcontext.Remove(temp);
            _Dbcontext.SaveChanges();
            return true;
        }

        public List<Kho> GetAllKho()
        {
            _lstKho = _Dbcontext.Khos.ToList();
            return _lstKho;
        }

        public bool Update(Kho obj)
        {
            if (obj == null)
            {
                return false;
            }
            var temp = _Dbcontext.Khos.FirstOrDefault(c => c.Id == obj.Id);
            temp.Hangton = obj.Hangton;
            temp.Hangdoitra = obj.Hangdoitra;
            _Dbcontext.Update(temp);
            _Dbcontext.SaveChanges();
            return true;
        }
    }
}
