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
    public class KhachHangSer : IKhachHangSer
    {
        private IKhachHangRep _IkhachHangr;
        public KhachHangSer()
        {
            _IkhachHangr = new KhachHangRep();
        }
        public string Add(KhachHangView obj)
        {
            if (obj == null)
            {
                return "Thêm không thành công";
            }
            var kh = new KhachHang()
            {
                DiaChi = obj.DiaChi,
                TenKH = obj.TenKH,
                MaKH = obj.MaKH,
                GioiTinh = obj.GioiTinh,
                STD = obj.STD,
                Id = obj.Id
            };
            _IkhachHangr.Add(kh);
            return "Thêm thành công";
        }

        public string Delete(KhachHangView obj)
        {
            if (obj == null)
            {
                return "Xóa không thành công";
            }
            var kh = new KhachHang()
            {
                DiaChi = obj.DiaChi,
                TenKH = obj.TenKH,
                MaKH = obj.MaKH,
                GioiTinh = obj.GioiTinh,
                STD = obj.STD,
                Id = obj.Id
            };
            _IkhachHangr.Delete(kh);
            return "Xóa thành công";
        }

        public List<KhachHangView> KhGetAll()
        {
            var kh = from a in _IkhachHangr.GetAllKh().ToList()
                     select new KhachHangView()
                     {
                         Id = a.Id,
                         DiaChi = a.DiaChi,
                         TenKH = a.TenKH,
                         MaKH = a.MaKH,
                         GioiTinh = a.GioiTinh,
                         STD = a.STD,
                     };
            return kh.ToList();
        }

        public string Update(KhachHangView obj)
        {
            if (obj == null)
            {
                return "Sửa không thành công";
            }
            var kh = new KhachHang()
            {
                DiaChi = obj.DiaChi,
                TenKH = obj.TenKH,
                MaKH = obj.MaKH,
                GioiTinh = obj.GioiTinh,
                STD = obj.STD,
                Id = obj.Id
            };
            _IkhachHangr.Update(kh);
            return " Sửa thành công";
        }
    }
}
