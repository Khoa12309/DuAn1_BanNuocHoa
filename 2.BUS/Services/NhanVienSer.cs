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
        private ITaiKhoanRep _Iarep;
        public NhanVienSer()
        {
            _Irep = new NhanVienRep();
            _Iarep = new TaiKhoanRepositories();
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
                Email = obj.Email,
                ChucVu = obj.ChucVu,
                HinhAnh=obj.HinhAnh,
                 
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
                ChucVu = obj.ChucVu,
                HinhAnh = obj.HinhAnh,

            };
            _Irep.Delete(nv);
            return "Xóa thành công";
        }

        public List<NhanVienView> NvGetAll()
        {
            var nv = from a in _Irep.GetAllNv().ToList()
                     join b in _Iarep.GetAllAccounts().ToList() on a.Id equals b.Id  

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
                         HinhAnh = a.HinhAnh,
                          Email=a.Email,
                          tk=b.TaiKhoan,
                          mk=b.MatKhau

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
                ChucVu = obj.ChucVu,
                HinhAnh = obj.HinhAnh,
                Email = obj.Email,
            };
            _Irep.Update(nv);
            return "Sửa thành công";
        }
    }
}
