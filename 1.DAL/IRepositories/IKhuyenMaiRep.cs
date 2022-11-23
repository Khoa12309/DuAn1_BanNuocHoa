using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IKhuyenMaiRep
    {
        public bool Add(KhuyenMai obj);
        public bool Update(KhuyenMai obj);
        public bool Delete(KhuyenMai obj);
        public List<KhuyenMai> GetAllKm();
    }
}
