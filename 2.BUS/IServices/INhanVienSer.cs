using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface INhanVienSer
    {
        public string Add(NhanVienView obj);
        public string Update(NhanVienView obj);
        public string Delete(NhanVienView obj);
        public List<NhanVienView> NvGetAll();

    }
}
