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

    public class GioHangSer : IGioHang
    {
        private IGioHangRep _IgioHangr;
        private IKhachHangRep _IkhachHangr;
        public GioHangSer()
        {
            _IgioHangr = new GioHangRep();
            _IkhachHangr = new KhachHangRep();
        }
        public string Add(GioHangView obj)
        {
            if (obj == null)
            {
                return "Thêm không thành công";
            }
            var gioHang = new GioHang()
            {
                ID = obj.ID,
                IDKH = obj.IDKH,
                MaGH = obj.MaGH,
                DonGia = obj.DonGia,
                TinhTrang = obj.TinhTrang,
                NgayTao = obj.NgayTao
            };
            _IgioHangr.Add(gioHang);
            return "Thêm thành công";
        }

        public string Delete(GioHangView obj)
        {
            if (obj == null)
            {
                return "Xóa không thành công";
            }
            var gioHang = new GioHang()
            {
                ID = obj.ID,
                IDKH = obj.IDKH,
                MaGH = obj.MaGH,
                DonGia = obj.DonGia,
                TinhTrang = obj.TinhTrang,
                NgayTao = obj.NgayTao
            };
            _IgioHangr.Delete(gioHang);
            return "Xóa thành công";
        }

        public List<GioHangView> GhGetAll()
        {
            var gioHang = from a in _IgioHangr.GetAllGh().ToList()
                          join b in _IkhachHangr.GetAllKh() on a.IDKH equals b.Id
                          select new GioHangView()
                          {
                              ID = a.ID,
                              IDKH = b.Id,
                              MaGH = a.MaGH,
                              DonGia = a.DonGia,
                              TinhTrang = a.TinhTrang,
                              NgayTao = a.NgayTao
                          };
            return gioHang.ToList();
        }

        public string Update(GioHangView obj)
        {
            if (obj == null)
            {
                return "Sửa không thành công";
            }
            var gioHang = new GioHang()
            {
                ID = obj.ID,
                IDKH = obj.IDKH,
                MaGH = obj.MaGH,
                DonGia = obj.DonGia,
                TinhTrang = obj.TinhTrang,
                NgayTao = obj.NgayTao
            };
            _IgioHangr.Update(gioHang);
            return "Sửa thành công";
        }
    }
}
