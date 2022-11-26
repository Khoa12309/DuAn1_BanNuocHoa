using _1.DAL.ContextDataBase;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class SanPhamRep : ISanPhamRep
    {
        private ContextDB _Dbcontext;
        private List<SanPham> _lstSp;
        public SanPhamRep()
        {
            _Dbcontext = new ContextDB();
            _lstSp=new List<SanPham>();
        }
        public bool Add(SanPham sanPham)
        {
            if (sanPham == null)
            {
                return false;
            }
            _Dbcontext.Add(sanPham);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(SanPham sanPham)
        {
            if (sanPham == null) return false;
            var temp = _Dbcontext.SanPhams.FirstOrDefault(c => c.ID == sanPham.ID);
            _Dbcontext.Remove(temp);
            _Dbcontext.SaveChanges();
            return true;
        }

        public List<SanPham> GetAllSp()
        {
            _lstSp = _Dbcontext.SanPhams.ToList();
            return _lstSp;
        }

        public bool Update(SanPham sanPham)
        {
            if (sanPham == null) return false;
            var temp = _Dbcontext.SanPhams.FirstOrDefault(c => c.ID == sanPham.ID);
            temp.TenSp = sanPham.TenSp;
            temp.MaSp = sanPham.MaSp;
            temp.TrangThai = sanPham.TrangThai;
            temp.DungTich = sanPham.DungTich;
            temp.GiaBan = sanPham.GiaBan;
            temp.GiaNhap = sanPham.GiaNhap;
            temp.HinhAnh= sanPham.HinhAnh;
            temp.IDHang= sanPham.IDHang;
            temp.Solong = sanPham.Solong;
            temp.MuiHuong= sanPham.MuiHuong;
            temp.IDLSp = sanPham.IDLSp;

            _Dbcontext.SanPhams.Update(temp);
            _Dbcontext.SaveChanges();
            return true;
        }
    }
}
