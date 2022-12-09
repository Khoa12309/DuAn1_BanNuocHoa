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
    public class HoaDonCtSer : IHoaDonChiTietSer
    {
        private ISanPhamRep _Isp;
        private IHoaDonChiTietRepcs _Ihdct;
        public HoaDonCtSer()
        {
            _Ihdct = new HoaDonChiTietRep();
            _Isp = new SanPhamRep();
        }
        public string Add(HoaDonChiTietView obj)
        {
            if (obj == null)
            {
                return "Thêm không thành công";
            }
            HoaDonChiTiet hdct = new HoaDonChiTiet()
            {
                DonGia = obj.DonGia,
                IdHD = obj.IdHD,
                IdSP = obj.IdSP,
                SoLuong = obj.SoLuong,
            };
            _Ihdct.Add(hdct);

            return "Thêm thành công";
        }

        public string Delete(HoaDonChiTietView obj)
        {
            if (obj == null)
            {
                return "Xóa không thành công";
            }

            HoaDonChiTiet hdct = new HoaDonChiTiet()
            {
                DonGia = obj.DonGia,
                IdHD = obj.IdHD,
                IdSP = obj.IdSP,
                SoLuong = obj.SoLuong,
            };
            _Ihdct.Delete(hdct);
            return "Xóa thành công";
        }

        public List<HoaDonChiTietView> HDCTGetAll()
        {
            var hdct = from a in _Ihdct.GetAllHDCT()
                       join b in _Isp.GetAllSp() on a.IdSP equals b.ID
                       select new HoaDonChiTietView()
                       {
                           DonGia = a.DonGia,
                           IdHD = a.IdHD,
                           IdSP = a.IdSP,
                           SoLuong = a.SoLuong,
                           tensp = b.TenSp
                       };
            return hdct.ToList();
        }

        public string Update(HoaDonChiTietView obj)
        {
            if (obj == null)
            {
                return "Sửa không thành công";
            }
            HoaDonChiTiet hdct = new HoaDonChiTiet()
            {
                DonGia = obj.DonGia,
                IdHD = obj.IdHD,
                IdSP = obj.IdSP,
                SoLuong = obj.SoLuong,
            };
            _Ihdct.Delete(hdct);
            return "Sửa không thành công";

        }
    }




}