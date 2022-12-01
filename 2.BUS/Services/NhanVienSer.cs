using _1.DAL.IRepositories;
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
            throw new NotImplementedException();
        }

        public string Delete(NhanVienView obj)
        {
            throw new NotImplementedException();
        }

        public List<NhanVienView> NvGetAll()
        {
            var nv = from a in _Irep.GetAllNv().ToList()
                     select new NhanVienView()
                     {
                         ChucVu = a.ChucVu,
                         DiaChi = a.DiaChi,
                         GioiTinh = (int)a.GioiTinh,
                         Id = a.Id,
                         MaNV = a.MaNV,
                         STD = a.STD,
                         TenNV = a.TenNV,
                         TrangThai = (int)a.TrangThai,
                     };
            return nv.ToList();
        }

        public string Update(NhanVienView obj)
        {
            throw new NotImplementedException();
        }
    }
}
