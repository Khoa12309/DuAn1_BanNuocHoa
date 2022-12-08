using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IBaoHanhSer
    {
        public string Add(BaoHanhView obj);
        public string Update(BaoHanhView obj);
        public string Delete(BaoHanhView obj);

        List<BaoHanhView> BhGetAll();
    }
}
