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
        List<Account> GetAllAccounts();
        bool Add(Account account);
        bool Update(Account account);
        bool Delete(Account account);
    }
}
