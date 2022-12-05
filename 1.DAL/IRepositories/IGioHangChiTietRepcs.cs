using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IGioHangChiTietRepcs
    {
        public bool Add(GioHangChiTiet obj);
        public bool Update(GioHangChiTiet obj);
        public bool Delete(GioHangChiTiet obj);
        public List<GioHangChiTiet> GhCtGetAll();
    }
}
