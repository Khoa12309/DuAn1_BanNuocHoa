using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IHangSer
    {
        public string Add(HangView obj);
        public string Update(HangView obj);
        public string Delete(HangView obj);

        List<HangView> HspGetAll();
    }
}
