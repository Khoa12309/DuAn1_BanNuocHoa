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
    public class HangSpSer : IHangSer
    {
        private IHangSpRep _Irep;
        public HangSpSer()
        {
            _Irep = new HangSpRep();
        }
        public string Add(HangView obj)
        {
            throw new NotImplementedException();
        }

        public string Delete(HangView obj)
        {
            throw new NotImplementedException();
        }

        public List<HangView> HspGetAll()
        {
            var hSp = from a in _Irep.GetAllHsp().ToList()
                      select new HangView()
                      {
                           ID = a.ID,
                            MaHang=a.MaHang,
                             TenHang=a.TenHang,
                      };
            return hSp.ToList();
        }

        public string Update(HangView obj)
        {
            throw new NotImplementedException();
        }
    }
}
