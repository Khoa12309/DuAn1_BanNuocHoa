using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class SanPhamSer : ISanPhamSer
    {
        private ISanPhamRep _Irep;
        private IHangSpRep _hangSpRep;
        private ILoaiSpRep _loaiSpRep;
        
        public SanPhamSer()
        {
            _Irep = new SanPhamRep();
          //  _khoRep = new KhoRep();
            _loaiSpRep=new LoaiSpRep();
            _hangSpRep = new HangSpRep();

        }
        public string Add(SanPhamView obj)
        {
            SanPham sp = new SanPham()
            {
                DungTich = obj.DungTich,
                GiaBan = obj.GiaBan,
                GiaNhap = obj.GiaNhap,
                HinhAnh = obj.HinhAnh,
                ID = obj.ID,
                IDHang = obj.IDHang,
                
                IDLSp = obj.IDLSp,
                MaSp = obj.MaSp,
                MuiHuong = obj.MuiHuong,
                Solong = obj.Solong,
                TenSp = obj.TenSp,
                TrangThai = obj.TrangThai,
                      
            };
            if (_Irep.Add(sp))
            {

                return "Thêm  thành công";
            }
            return "Thêm không Thành công";
        }

        public string Delete(SanPhamView obj)
        {
            SanPham sp = new SanPham()
            {
                DungTich = obj.DungTich,
                GiaBan = obj.GiaBan,
                GiaNhap = obj.GiaNhap,
                HinhAnh = obj.HinhAnh,
                ID = obj.ID,
                IDHang = obj.IDHang,
                
                IDLSp = obj.IDLSp,
                MaSp = obj.MaSp,
                MuiHuong = obj.MuiHuong,
                Solong = obj.Solong,
                TenSp = obj.TenSp,
                TrangThai = obj.TrangThai,
                 

            };
            var temp = SpGetAll().FindIndex(c => c.ID == obj.ID);
            if (temp == -1)
            {

                return "Không tìm thấy";
            }
            if (_Irep.Delete(sp))
            {

                return "Xóa  thành công";
            }
            return "Xóa không Thành công";
        }

        public List<SanPhamView> SpGetAll()
        {
            var sp = from a in _Irep.GetAllSp().ToList()
                     join b in _hangSpRep.GetAllHsp().ToList() on a.IDHang equals b.ID
                     join c in _loaiSpRep.GetAllLsp().ToList() on a.IDLSp equals c.Id
                   //  join d in _khoRep.GetAllKho().ToList() on a.IDKho equals d.Id
                     select new SanPhamView()
                     {
                         ID = a.ID,
                       //  IDKho = d.Id,
                         DungTich = a.DungTich,
                         GiaBan = (float)a.GiaBan,
                         GiaNhap = (float)a.GiaNhap,
                         HinhAnh = a.HinhAnh,
                         IDHang = b.ID,
                         IDLSp = c.Id,
                         MaSp = a.MaSp,
                         MuiHuong = a.MuiHuong,
                         Solong = (int)a.Solong,
                         TenSp = a.TenSp,
                         TrangThai = (int)a.TrangThai,
                          Tenhang=b.TenHang,
                           Tenloai=c.TenloaiSp,
                     };
            return sp.ToList();
        }

        public string Update(SanPhamView obj)
        {
            SanPham sp = new SanPham()
            {
                DungTich = obj.DungTich,
                GiaBan = obj.GiaBan,
                GiaNhap = obj.GiaNhap,
                HinhAnh = obj.HinhAnh,
                ID = obj.ID,
                IDHang = obj.IDHang,
                IDLSp = obj.IDLSp,
                MaSp = obj.MaSp,
                MuiHuong = obj.MuiHuong,
                Solong = obj.Solong,
                TenSp = obj.TenSp,
                TrangThai = obj.TrangThai,

            };
            var temp = SpGetAll().FindIndex(c => c.ID == obj.ID);
            if (temp == -1)
            {

                return "Không tìm thấy";
            }
            if (_Irep.Update(sp))
            {

                return "Sửa  thành công";
            }
            return "Sửa không Thành công";
        }
    }
}
