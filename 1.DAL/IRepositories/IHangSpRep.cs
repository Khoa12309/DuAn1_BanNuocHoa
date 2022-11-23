using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHangSpRep
    {
        public bool Add(HangSp obj);
        public bool Update(HangSp obj);
        public bool Delete(HangSp obj);
        public List<HangSp> GetAllHsp();
    }
}
