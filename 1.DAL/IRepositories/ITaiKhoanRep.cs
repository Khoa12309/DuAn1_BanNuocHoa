using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ITaiKhoanRep
    {
      
      public  bool Add(Account account);
       public bool Update(Account account);
       public bool Delete(Account account);
       public List<Account> GetAllAccounts();
    }
}
