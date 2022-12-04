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
            _lstAcc = new List<Account>();
        }
        public List<Account> GetAllAccounts()
        {
            _lstAcc = _Dbcontext.accounts.ToList();
            return _lstAcc;
        }

        public bool Add(Account account)
        {
            if (account == null)
            {
                return false;
            }
            _Dbcontext.Add(account);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool Update(Account account)
        {
            if (account == null)
            {
                return false;
            }
            var temp = _Dbcontext.accounts.FirstOrDefault(c =>c.Id == account.Id);
            temp.TaiKhoan = account.TaiKhoan;
            temp.MatKhau = account.MatKhau;
            _Dbcontext.Update(temp);
            _Dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(Account account)
        {
            if (account == null)
            {
                return false;
            }
            var temp = _Dbcontext.accounts.FirstOrDefault(c => c.Id == account.Id);
            _Dbcontext.Remove(temp);
            _Dbcontext.SaveChanges();
            return true;
        }
    }
}
