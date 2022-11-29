using _1.DAL.ContextDataBase;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class NhanVienRep :INhanVienRep
    {
        private ContextDB _Dbcontext;
        private List<NhanVien> _lstNv;
        public NhanVienRep()
        {
            _Dbcontext=new ContextDB();
            _lstNv=new List<NhanVien>();
        }

        public bool Add(NhanVien obj)
        {
            if (obj == null)
            {
                return false;
            }
            _Dbcontext.Add(obj);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            if (obj == null)
            {
                return false;
            }
            var temp = _Dbcontext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);
            _Dbcontext.Remove(temp);
            _Dbcontext.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAllNv()
        {
           _lstNv=_Dbcontext.NhanViens.ToList();
            return _lstNv;
        }

        public bool Update(NhanVien obj)
        {
            if (obj == null)
            {
                return false;
            }
            var temp = _Dbcontext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);
            temp.STD = obj.STD;
            temp.ChucVu = obj.ChucVu;
            temp.TenNV = obj.TenNV;
            temp.MaNV = obj.MaNV;
            temp.DiaChi = obj.DiaChi;
            temp.TrangThai = obj.TrangThai;
            temp.GioiTinh = obj.GioiTinh;
            _Dbcontext.Remove(temp);
            _Dbcontext.SaveChanges();
            return true;
        }
    }
}
