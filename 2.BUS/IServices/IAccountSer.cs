using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IAccountSer
    {
        public string Add(AccountView obj);
        public string Update(AccountView obj);
        public string Delete(AccountView obj);
        public int check(AccountView obj);
        List<AccountView> GetAll();
    }
}
