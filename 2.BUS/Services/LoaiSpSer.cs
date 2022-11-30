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
    public class LoaiSpSer : ILoaiSer
    {
        private LoaiSpRep _Irep;
        public LoaiSpSer()
        {
            _Irep = new LoaiSpRep();
        }
        public string Add(LoaiView obj)
        {
            throw new NotImplementedException();
        }

        public string Delete(LoaiView obj)
        {
            throw new NotImplementedException();
        }

        public List<LoaiView> LspGetAll()
        {
            var lSp = from a in _Irep.GetAllLsp().ToList()
                      select new LoaiView()
                      {
                           Id = a.Id,
                            MaloaiSp= a.MaloaiSp,
                             TenloaiSp = a.TenloaiSp,
                      };
            return lSp.ToList();
        }

        public string Update(LoaiView obj)
        {
            throw new NotImplementedException();
        }
    }
}
