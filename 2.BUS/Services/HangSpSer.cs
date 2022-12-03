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
        private IHangSpRep _IhangSpr;
        public HangSpSer()
        {
            _IhangSpr = new HangSpRep();
        }
        public string Add(HangView obj)
        {
            if (obj == null)
            {
                return "Thêm không thành công";
            }
            var hangsp = new HangSp()
            {
                ID = obj.ID,
                TenHang = obj.TenHang,
                MaHang = obj.MaHang,
            };
            _IhangSpr.Add(hangsp);
            return "Thêm  thành công";
        }

        public string Delete(HangView obj)
        {

            if (obj == null)
            {
                return "Xóa không thành công";
            }
            var hangsp = new HangSp()
            {
                ID = obj.ID,
                TenHang = obj.TenHang,
                MaHang = obj.MaHang,
            };
            _IhangSpr.Delete(hangsp);
            return "Xóa thành công";
        }

        public List<HangView> HspGetAll()
        {
            var hangsp = from a in _IhangSpr.GetAllHsp().ToList()
                         select new HangView()
                         {
                             ID = a.ID,
                             TenHang = a.TenHang,
                             MaHang = a.MaHang,
                         };
            return hangsp.ToList();
        }

        public string Update(HangView obj)
        {

            if (obj == null)
            {
                return "Sửa không thành công";
            }
            var hangsp = new HangSp()
            {
                ID = obj.ID,
                TenHang = obj.TenHang,
                MaHang = obj.MaHang,
            };
            _IhangSpr.Update(hangsp);
            return "Sửa thành công";
        }
    }
}
