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
    public class LoaiSpSer : ILoaiSer
    {
        private ILoaiSpRep _ILoaiSpr;
        public LoaiSpSer()
        {
            _ILoaiSpr = new LoaiSpRep();
        }
        public string Add(LoaiView obj)
        {
            if (obj == null)
            {
                return "Thêm không thành công";
            }
            LoaiSp loaisp = new LoaiSp()
            {
                Id = obj.Id,
                MaloaiSp = obj.MaloaiSp,
                TenloaiSp = obj.TenloaiSp,
            };
            _ILoaiSpr.Add(loaisp);
            return "Thêm thành công";
        }

        public string Delete(LoaiView obj)
        {
            if (obj == null)
            {
                return "Xóa không thành công";
            }
            LoaiSp loaisp = new LoaiSp()
            {
                Id = obj.Id,
                MaloaiSp = obj.MaloaiSp,
                TenloaiSp = obj.TenloaiSp,
            };
          
            _ILoaiSpr.Delete(loaisp);
            return "Xóa thành công";
        }

        public List<LoaiView> LspGetAll()
        {
            var loaisp = from a in _ILoaiSpr.GetAllLsp().ToList()
                         select new LoaiView()
                         {
                             Id = a.Id,
                             MaloaiSp = a.MaloaiSp,
                             TenloaiSp = a.TenloaiSp,
                         };
            return loaisp.ToList();
        }

        public string Update(LoaiView obj)
        {
            if (obj == null)
            {
                return "Sửa không thành công";
            }
            LoaiSp loaisp = new LoaiSp()
            {
                Id = obj.Id,
                MaloaiSp = obj.MaloaiSp,
                TenloaiSp = obj.TenloaiSp,
            };
           
            _ILoaiSpr.Update(loaisp);
            return "Sửa thành công";
        }
    }
}
