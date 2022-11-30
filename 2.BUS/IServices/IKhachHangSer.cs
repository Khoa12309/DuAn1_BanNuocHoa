using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IKhachHangSer
    {
        public string Add(KhachHangView obj);
        public string Update(KhachHangView obj);
        public string Delete(KhachHangView obj);

        List<KhachHangView> KhGetAll();
    }
}
