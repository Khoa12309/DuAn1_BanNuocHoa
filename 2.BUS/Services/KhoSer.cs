using _1.DAL.ContextDataBase;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class KhoSer : IKhoSer
    {
        private IKhoRep _Irep;
        public KhoSer()
        {
            _Irep = new KhoRep();
        }
        public string Add(KhoView obj)
        {
            throw new NotImplementedException();
        }

        public string Delete(KhoView obj)
        {
            throw new NotImplementedException();
        }

        public List<KhoView> KhoGetAll()
        {
           var kho = from a in _Irep.GetAllKho().ToList()
                     select new KhoView()
                     {
                         Id = a.Id,
                          Hangdoitra = a.Hangdoitra,
                           Hangton=a.Hangton,
                     };
            return kho.ToList();
        }

        public string Update(KhoView obj)
        {
            throw new NotImplementedException();
        }
    }
}
