using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface INhanVienRep
    {
        public bool Add(NhanVien obj);
        public bool Update(NhanVien obj);
        public bool Delete(NhanVien obj);
        public List<NhanVien> GetAllNv();
    }
}
