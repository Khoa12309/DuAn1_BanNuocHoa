using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IGioHangRep
    {
        public bool Add(GioHang obj);
        public bool Update(GioHang obj);
        public bool Delete(GioHang obj);
        public List<GioHang> GetAllGh();
    }
}
