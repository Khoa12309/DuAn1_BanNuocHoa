using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IKhuyenMaiSer
    {
        public string Add(KhuyenMaiView obj);
        public string Update(KhuyenMaiView obj);
        public string Delete(KhuyenMaiView obj);

        List<KhuyenMaiView> KmGetAll();
    }
}
