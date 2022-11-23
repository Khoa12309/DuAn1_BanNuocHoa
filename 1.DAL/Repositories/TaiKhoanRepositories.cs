using _1.DAL.ContextDataBase;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
   public class TaiKhoanRepositories : ITaiKhoanRep
    {
        private ContextDB _Dbcontext;
        private List<Account> _lstAcc;
        public TaiKhoanRepositories()
        {
            _Dbcontext = new ContextDB();
        }
        public List<Account> GetAllAccounts()
        {
            _lstAcc = _Dbcontext.accounts.ToList();
            return _lstAcc;
        }

        public bool Add(Account account)
        {
            throw new NotImplementedException();
        }

        public bool Update(Account account)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
