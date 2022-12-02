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
    public class HoaDonSer : IHoaDonSer
    {
        private KhuyenMaiRep _IkhuyenMair;
        private NhanVienRep _InhanVienr;
        private HoaDonChiTietRep _IhoaDonCTr;
        public HoaDonSer()
        {
            _IkhuyenMair = new KhuyenMaiRep();
            _InhanVienr = new NhanVienRep();
            _IhoaDonCTr = new HoaDonChiTietRep();
        }
        public string Add(HoaDonView obj)
        {
            throw new NotImplementedException();
        }

        public string Delete(HoaDonView obj)
        {
            throw new NotImplementedException();
        }

        public List<HoaDonView> HdGetAll()
        {
            throw new NotImplementedException();
        }

        public string Update(HoaDonView obj)
        {
            throw new NotImplementedException();
        }
    }
}
