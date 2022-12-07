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
        private IKhuyenMaiRep _IkhuyenMair;
        private INhanVienRep _InhanVienr;
        private IKhachHangRep _IkhachHangr;
        private IHoaDonRep _IhoaDonr;
        public HoaDonSer()
        {
            _IkhachHangr = new KhachHangRep();
            _IkhuyenMair = new KhuyenMaiRep();
            _InhanVienr = new NhanVienRep();
            _IhoaDonr = new HoaDonRep();
        }

        public string Add(HoaDonView obj)
        {
            if (obj == null)
            {
                return "Thêm không thành công";
            }
            var hoaDon = new HoaDon()
            {
                Id = obj.Id,
                MaHD = obj.MaHD,
                TongTien = (float)obj.TongTien,
                IdKH = obj.IdKH,
                IdKM = (Guid)obj.IdKM,
                IdNV = obj.IdNV,
                TrangThai = obj.TrangThai,
                NgayMua = obj.NgayMua,
            };
            _IhoaDonr.Add(hoaDon);
            return "Thêm thành công";
        }

        public string Delete(HoaDonView obj)
        {
            if (obj == null)
            {
                return "Xóa không thành công";
            }
            var hoaDon = new HoaDon()
            {
                Id = obj.Id,
                MaHD = obj.MaHD,
                TongTien = (float)obj.TongTien,
                IdKH = obj.IdKH,
                IdKM = (Guid)obj.IdKM,
                IdNV = obj.IdNV,
                TrangThai = obj.TrangThai,
                NgayMua = obj.NgayMua,

            };
            _IhoaDonr.Delete(hoaDon);
            return "Xóa thành công";
        }

        public List<HoaDonView> HdGetAll()
        {
            var hd = from a in _IhoaDonr.GetAllHd()
                     join b in _IkhachHangr.GetAllKh() on a.IdKH equals b.Id
                     join c in _IkhuyenMair.GetAllKm() on a.IdKM equals c.Id
                     join d in _InhanVienr.GetAllNv() on a.IdNV equals d.Id
                     select new HoaDonView()
                     {
                         Id = a.Id,

                         IdKH = b.Id,

                         IdKM = c.Id,

                         IdNV = d.Id,

                         TrangThai = a.TrangThai,
                         TongTien = a.TongTien,
                         NgayMua = a.NgayMua,
                         MaHD = a.MaHD,
                     };
            return hd.ToList();
        }

        public string Update(HoaDonView obj)
        {
            if (obj == null)
            {
                return "Sửa không thành công";
            }
            var hoaDon = new HoaDon()
            {
                Id = obj.Id,
                MaHD = obj.MaHD,
                TongTien = (float)obj.TongTien,
                IdKH = obj.IdKH,
                IdKM = (Guid)obj.IdKM,
                IdNV = obj.IdNV,
                TrangThai = obj.TrangThai,
                NgayMua = obj.NgayMua,
                 

            };
            _IhoaDonr.Update(hoaDon);
            return "Sửa thành công";
        }
    }
   
}
