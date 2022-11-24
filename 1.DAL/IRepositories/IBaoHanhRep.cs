using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IBaoHanhRep
    {
        public bool Add(BaoHanh obj);
        public bool Update(BaoHanh obj);
        public bool Delete(BaoHanh obj);
        public List<BaoHanh> GetAllBh();
    }
}
