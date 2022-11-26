using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ILoaiSpRep
    {
        public bool Add(LoaiSp obj);
        public bool Update(LoaiSp obj);
        public bool Delete(LoaiSp obj);
        public List<LoaiSp> GetAllLsp();
    }
}
