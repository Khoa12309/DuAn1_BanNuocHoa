using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonRep
    {
        public bool Add(HoaDon obj);
        public bool Update(HoaDon obj);
        public bool Delete(HoaDon obj);
        public List<HoaDon> GetAllHd();
    }
}
