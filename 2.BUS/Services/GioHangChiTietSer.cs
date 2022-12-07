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
    public class GioHangChiTietSer :IGioHangChiTietSer
    {
      
       
        private IGioHangChiTietRepcs _Irep;
        public GioHangChiTietSer()
        {
            _Irep = new GioHangChiTietRep();
        }
       

        public string Add(GioHangChiTietView obj)
        {
            throw new NotImplementedException();
        }

        

        public string Delete(GioHangChiTietView obj)
        {
            throw new NotImplementedException();
        }

      

        public List<GioHangChiTietView> GHCTGetAll()
        {
            var lst = from a in _Irep.GhCtGetAll()
                      select new GioHangChiTietView()
                      {
                          DonGia = (float)a.DonGia,
                          SoLuong = (int)a.SoLuong

                      };
            return lst.ToList();
        }

      
        public string Update(GioHangChiTietView obj)
        {
            throw new NotImplementedException();
        }
    }
}
