using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IKhachHangRep
    {
        public bool Add(KhachHang obj);
        public bool Update(KhachHang obj);
        public bool Delete(KhachHang obj);
        public List<KhachHang> GetAllKh();
    }
}
