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
    public class NhanVienSer : INhanVienSer
    {
        private INhanVienRep _Irep;
        public NhanVienSer()
        {
            _Irep = new NhanVienRep();
        }
        public string Add(NhanVienView obj)
        {
            if (obj == null)
            {
                return "Thêm không thành công";
            }
            var nv = new NhanVien()
            {
                Id = obj.Id,
                MaNV = obj.MaNV,
                TenNV = obj.TenNV,
                GioiTinh = obj.GioiTinh,
                DiaChi = obj.DiaChi,
                TrangThai = obj.TrangThai,
                STD = obj.STD,
                Email = obj.
                ChucVu = obj.ChucVu
            };
            _Irep.Add(nv);
            return "Thêm thành công";
        }

        public string Delete(NhanVienView obj)
        {
            if (obj == null)
            {
                return "Xóa không thành công";
            }
            var nv = new NhanVien()
            {
                Id = obj.Id,
                MaNV = obj.MaNV,
                TenNV = obj.TenNV,
                GioiTinh = obj.GioiTinh,
                DiaChi = obj.DiaChi,
                TrangThai = obj.TrangThai,
                STD = obj.STD,
                ChucVu = obj.ChucVu
            };
            _Irep.Delete(nv);
            return "Xóa thành công";
        }

        public List<NhanVienView> NvGetAll()
        {
            var nv = from a in _Irep.GetAllNv().ToList()
                     select new NhanVienView()
                     {
                         ChucVu = a.ChucVu,
                         DiaChi = a.DiaChi,
                         GioiTinh = a.GioiTinh,
                         Id = a.Id,
                         MaNV = a.MaNV,
                         STD = a.STD,
                         TenNV = a.TenNV,
                         TrangThai = a.TrangThai,
                     };
            return nv.ToList();
        }

        public string Update(NhanVienView obj)
        {
            if (obj == null)
            {
                return "Sửa không thành công";
            }
            var nv = new NhanVien()
            {
                Id = obj.Id,
                MaNV = obj.MaNV,
                TenNV = obj.TenNV,
                GioiTinh = obj.GioiTinh,
                DiaChi = obj.DiaChi,
                TrangThai = obj.TrangThai,
                STD = obj.STD,
                ChucVu = obj.ChucVu
            };
            _Irep.Update(nv);
            return "Sửa thành công";
        }
    }
}
