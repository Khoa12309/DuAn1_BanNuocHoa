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
    public class KhuyenMaiSer : IKhuyenMaiSer
    {
        private IKhuyenMaiRep _IKhuyenMair;
        public KhuyenMaiSer()
        {
            _IKhuyenMair = new KhuyenMaiRep();
        }

        public string Add(KhuyenMaiView obj)
        {
            if (obj == null)
            {
                return "Thêm không thành công";
            }
            var km = new KhuyenMai()
            {
                Id = obj.Id,
                MaKM = obj.MaKM,
                GiaTriKM = obj.GiaTriKM,
                NgayBD = obj.NgayBD,
                NgayKT = obj.NgayKT
            };
            _IKhuyenMair.Add(km);
            return "Thêm thành công";
        }

        public string Delete(KhuyenMaiView obj)
        {
            if (obj == null)
            {
                return "Xóa không thành công";
            }
            var km = new KhuyenMai()
            {
                Id = obj.Id,
                MaKM = obj.MaKM,
                GiaTriKM = obj.GiaTriKM,
                NgayBD = obj.NgayBD,
                NgayKT = obj.NgayKT
            };
            _IKhuyenMair.Delete(km);
            return "Xóa thành công";
        }

        public List<KhuyenMaiView> KmGetAll()
        {
            var km = from a in _IKhuyenMair.GetAllKm().ToList()
                     select new KhuyenMaiView()
                     {
                         Id = a.Id,
                         MaKM = a.MaKM,
                         GiaTriKM = a.GiaTriKM,
                         NgayBD = a.NgayBD,
                         NgayKT = a.NgayKT,
                     };
            return km.ToList();
        }

        public string Update(KhuyenMaiView obj)
        {
            if (obj == null)
            {
                return "Sửa không thành công";
            }
            var km = new KhuyenMai()
            {
                Id = obj.Id,
                MaKM = obj.MaKM,
                GiaTriKM = obj.GiaTriKM,
                NgayBD = obj.NgayBD,
                NgayKT = obj.NgayKT
            };
            _IKhuyenMair.Update(km);
            return "Sửa thành công";
        }
    }
}
