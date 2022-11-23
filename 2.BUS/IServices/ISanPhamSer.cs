using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
  public interface ISanPhamSer
    {
        public string Add(SanPhamView obj);
        public string Update(SanPhamView obj);
        public string Delete(SanPhamView obj);
      
        List<SanPhamView> SpGetAll();
    }
}
