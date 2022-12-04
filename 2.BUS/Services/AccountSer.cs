using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class AccountSer : IAccountSer
    {
        private ITaiKhoanRep _Itkr;
        private INhanVienRep _Invr;
        public AccountSer()
        {
            _Itkr = new TaiKhoanRepositories();
            _Invr= new NhanVienRep();
        }
        public string Add(AccountView obj)
        {
            if (obj == null)
            {
                return "Thêm không thành công";
            }
            var tk = new Account()
            {
                Id = obj.Id,
                TaiKhoan = obj.TaiKhoan,
                MatKhau = obj.MatKhau
            };
            _Itkr.Add(tk);
            return "Thêm thành công";
        }


        public string Delete(AccountView obj)
        {
            if (obj == null)
            {
                return "Xóa không thành công";
            }
            var tk = new Account()
            {
                Id = obj.Id,
                TaiKhoan = obj.TaiKhoan,
                MatKhau = obj.MatKhau
            };
            _Itkr.Delete(tk);
            return "Xóa thành công";
        }

        public List<AccountView> GetAll()
        {
            var Acc = from a in _Itkr.GetAllAccounts().ToList()
                      join b in _Invr.GetAllNv() on a.Id equals b.Id
                     select new AccountView()
                     {
                          
                         Id = a.Id, 
                         MatKhau=a.MatKhau,                      
                         TaiKhoan=a.TaiKhoan,
                         ChucVu=b.ChucVu, // chỗ này là sao
                     };


            return Acc.ToList();
        }

        public string Update(AccountView obj)
        {
            if (obj == null)
            {
                return "Sửa không thành công";
            }
            var tk = new Account()
            {
                Id = obj.Id,
                TaiKhoan = obj.TaiKhoan,
                MatKhau = obj.MatKhau
            };
            _Itkr.Update(tk);
            return " Sửa thành công";
        }

        public int check(AccountView obj)
        {
          var a =  GetAll().FirstOrDefault(x => x.TaiKhoan == obj.TaiKhoan && x.MatKhau==obj.MatKhau);
            if (a == null) { return 0 ; }
            if (a.ChucVu=="Nhân Viên")
            {
                
                return 2;
            }
            else if  (a.ChucVu=="Quản Lý")
            {
                return 1;
            }else return 0;

            
        }
    }
}
