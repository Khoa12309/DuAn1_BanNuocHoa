using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
public interface IKhoSer
    {
        public string Add(KhoView obj);
        public string Update(KhoView obj);
        public string Delete(KhoView obj);

        List<KhoView> KhoGetAll();
    }
}
