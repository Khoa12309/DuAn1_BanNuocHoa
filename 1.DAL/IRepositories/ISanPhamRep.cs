using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
   public interface ISanPhamRep
    {
        public bool Add(SanPham sanPham);
        public bool Update(SanPham sanPham);
        public bool Delete(SanPham sanPham);
        public List<SanPham> GetAllSp();
    }
}
