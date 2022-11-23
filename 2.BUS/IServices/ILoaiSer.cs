using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ILoaiSer
    {
        public string Add(LoaiView obj);
        public string Update(LoaiView obj);
        public string Delete(LoaiView obj);

        List<LoaiView> LspGetAll();
    }
}
