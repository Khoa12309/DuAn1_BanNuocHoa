using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Net;
using System.Net.Mail;
=======
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
>>>>>>> origin/giangnt

namespace _3.PL.Views
{
    public partial class FrmKhachHang : Form
    {
        private IKhachHangSer _IkhachHangr;
        private KhachHangView _KhachHang_view;
        Guid _Id;
        string chuoidung = "1234567890QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopas dfghjklzxcvbnm";
        string chuoisdt = "1234567890";
        string chuoiten = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopas dfghjklzxcvbnm";
        string ma;
        public FrmKhachHang()
        {
            InitializeComponent();
            _KhachHang_view = new KhachHangView();
            _IkhachHangr = new KhachHangSer();
            rbtn_Nam.Checked = true;
            LoadData();
        }
        public void LoadData()
        {
            int stt = 1;
            dgird_KhachHang.ColumnCount = 7;
            dgird_KhachHang.Columns[0].Name = "Stt";
            dgird_KhachHang.Columns[1].Name = "ID";
            dgird_KhachHang.Columns[1].Visible = false;
            dgird_KhachHang.Columns[2].Name = "Ten khach hang";
            dgird_KhachHang.Columns[3].Name = "Ma khach hang";
            dgird_KhachHang.Columns[4].Name = "Gioi tinh";
            dgird_KhachHang.Columns[5].Name = "Dia chi";
            dgird_KhachHang.Columns[6].Name = "So dien thoai";
            dgird_KhachHang.Rows.Clear();
            foreach (var x in _IkhachHangr.KhGetAll())
            {
                dgird_KhachHang.Rows.Add(stt++, x.Id, x.TenKH, x.MaKH, x.GioiTinh, x.DiaChi, x.STD);
            }

        }
        private bool kiemtrakitu(string chuoiCanKiemTra)
        {
            foreach (char kiTu in chuoiCanKiemTra)
            {
                bool dung = false;

                foreach (char kitu2 in chuoidung)
                {
                    if (kiTu == kitu2) dung = true;
                }
                if (dung == false) return false;
            }


            return true;
        }
        public bool checktrung(string masp)
        {
            var r = _IkhachHangr.KhGetAll().Any(c => c.MaKH == masp);
            if (r == true) { return true; }
            return false;
        }
        public bool checkma(string ma2)
        {
            if (ma2 == ma) { return true; }
            else if (checktrung(ma2) == true) { return false; }
            else { return true; }
            return true;

        }
        private bool kiemtraten(string chuoiCanKiemTra)
        {
            foreach (char kiTu in chuoiCanKiemTra)
            {
                bool dung = false;

                foreach (char kitu2 in chuoiten)
                {
                    if (kiTu == kitu2) dung = true;
                }
                if (dung == false) return false;
            }


            return true;
        }
        private bool kiemtrasdt(string chuoiCanKiemTra)
        {
            Regex chechdt = new Regex(@"^0");
      
            foreach (char kiTu in chuoiCanKiemTra)
            {
                bool dung = false;

                foreach (char kitu2 in chuoisdt)
                {
                    if (kiTu == kitu2) dung = true;
                }
                if (dung == false) return false;
            }

            if (!chechdt.IsMatch(chuoiCanKiemTra))
            {
                return false;
            }
            /*else*/
            if (chuoiCanKiemTra.Length != 10)
            {
                return false;
                }

            return true;
        }
        public KhachHangView GetDataFromUI()
        {
            _KhachHang_view = new KhachHangView()
            {
                Id = Guid.NewGuid(),
                MaKH = tbx_MaKhachHang.Text,
                TenKH = tbx_TenKhachHang.Text,
                DiaChi = tbx_DiaChi.Text,
                STD = tbx_SoDienThoai.Text,
                GioiTinh = rbtn_Nam.Checked == true ? "Nam" : "Nu"

            };
            return _KhachHang_view;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thực hiện chức năng này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                _KhachHang_view = new KhachHangView();
                _KhachHang_view.Id = Guid.NewGuid();
                if (tbx_MaKhachHang.Text.Trim() == "" || kiemtrakitu(tbx_MaKhachHang.Text.Trim()) == false)
                {

                    MessageBox.Show("Bạn đang để trống mã khách hàng hoặc mã khách hàng có kí tự đặc biệt");
                    return;
                }
                else if (checktrung(tbx_MaKhachHang.Text.Trim()) == true)
                {
                    MessageBox.Show("Trùng mã khách hàng");
                    return;
                }
                else if (tbx_TenKhachHang.Text.Trim() == "" || kiemtraten(tbx_TenKhachHang.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống tên khách hàng hoặc tên khách hàng có kí tự đặc biệt");
                    return;
                }
                else if (tbx_SoDienThoai.Text.Trim() == "" || kiemtrasdt(tbx_SoDienThoai.Text.Trim()) == false)
                {

                    MessageBox.Show("Bạn đang để trống SDT khách hàng hoặc SDT khách hàng sai định dạng");
                    return;
                }
          
                else
                {
                    _KhachHang_view.MaKH = tbx_MaKhachHang.Text;
                    _KhachHang_view.TenKH = tbx_TenKhachHang.Text;
                    _KhachHang_view.DiaChi = tbx_DiaChi.Text;
                    _KhachHang_view.STD = tbx_SoDienThoai.Text;
                    _KhachHang_view.GioiTinh = rbtn_Nam.Checked == true ? "Nam" : "Nu";
                    MessageBox.Show(_IkhachHangr.Add(_KhachHang_view));
                    LoadData();
                }

            }
            else
            {
                return;

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thực hiện chức năng này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                _KhachHang_view = new KhachHangView();
            
                if (tbx_MaKhachHang.Text.Trim() == "" || kiemtrakitu(tbx_MaKhachHang.Text.Trim()) == false)
                {

                    MessageBox.Show("Bạn đang để trống mã khách hàng hoặc mã khách hàng có kí tự đặc biệt");
                    return;
                }
                else if (checkma(tbx_MaKhachHang.Text.Trim())==false) 
                {
                    MessageBox.Show("Trùng mã khách hàng");
                    return;
                }
                else if (tbx_TenKhachHang.Text.Trim() == "" || kiemtraten(tbx_TenKhachHang.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống tên khách hàng hoặc tên khách hàng có kí tự đặc biệt");
                    return;
                }
                else if (tbx_SoDienThoai.Text.Trim() == "" || kiemtrasdt(tbx_SoDienThoai.Text.Trim()) == false)
                {

                    MessageBox.Show("Bạn đang để trống SDT khách hàng hoặc SDT khách hàng sai định dạng");
                    return;
                }

                else
                {
                    _KhachHang_view.Id = _Id;
                    _KhachHang_view.MaKH = tbx_MaKhachHang.Text;
                    _KhachHang_view.TenKH = tbx_TenKhachHang.Text;
                    _KhachHang_view.DiaChi = tbx_DiaChi.Text;
                    _KhachHang_view.STD = tbx_SoDienThoai.Text;
                    _KhachHang_view.GioiTinh = rbtn_Nam.Checked == true ? "Nam" : "Nu";
                    MessageBox.Show(_IkhachHangr.Update(_KhachHang_view));
                    LoadData();
                }

            }
            else
            {
                return;

            }
        }

        private void btn_Datete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thực hiện chức năng này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var temp = _KhachHang_view;
                temp.Id = _Id;
                MessageBox.Show(_IkhachHangr.Delete(temp));
                LoadData();
            }
            else
            {
                return;
            }
        }

        private void dgird_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _Id = Guid.Parse(dgird_KhachHang.Rows[e.RowIndex].Cells[1].Value.ToString()); 
            tbx_TenKhachHang.Text = dgird_KhachHang.Rows[e.RowIndex].Cells[2].Value.ToString(); 
            tbx_MaKhachHang.Text = dgird_KhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
            var Kh = _IkhachHangr.KhGetAll().FirstOrDefault(c => c.Id == _Id);

            if (Kh.GioiTinh == "Nam")
            {
                rbtn_Nam.Checked = true;
            }
            if (Kh.GioiTinh == "Nu")
            {
                rbtn_Nu.Checked = true;
            }
            tbx_DiaChi.Text = dgird_KhachHang.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbx_SoDienThoai.Text = dgird_KhachHang.Rows[e.RowIndex].Cells[6].Value.ToString();
            _KhachHang_view = _IkhachHangr.KhGetAll().FirstOrDefault(c => c.Id == Guid.Parse(dgird_KhachHang.Rows[e.RowIndex].Cells[1].Value.ToString()));
         
            ma = dgird_KhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

       
    }
}
