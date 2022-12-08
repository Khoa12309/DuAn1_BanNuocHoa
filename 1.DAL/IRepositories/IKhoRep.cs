using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
   public interface IKhoRep
    {
        public bool Add(Kho obj);
        public bool Update(Kho obj);
        public bool Delete(Kho obj);
        public List<Kho> GetAllKho();
    }
}
