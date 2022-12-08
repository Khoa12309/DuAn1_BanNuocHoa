using _3.PL.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new FrmMain());
=======
            //   Application.Run(new FrmDangNhap());
           //  A/pplication.Run(new FrmHangSp());
             Application.Run(new FrmBanHang());
           //  Application.Run(new FrmLoaiSp());
>>>>>>> origin/Dungndph20833
            

        }
    }
}
