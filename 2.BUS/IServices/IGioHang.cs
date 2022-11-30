using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IGioHang
    {
        public string Add(GioHangView obj);
        public string Update(GioHangView obj);
        public string Delete(GioHangView obj);

        List<GioHangView > GhGetAll();
    }
}
