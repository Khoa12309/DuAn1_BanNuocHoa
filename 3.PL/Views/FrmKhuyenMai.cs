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

namespace _3.PL.Views
{
    public partial class FrmKhuyenMai : Form
    {
        private IKhuyenMaiSer _IkhuyenMair;
        private KhuyenMaiView _KhuyenMaiView;
        Guid _id;
        string chuoidung = "1234567890QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopas dfghjklzxcvbnm";
        string chuoisdt = "1234567890";
        string ma;
        public FrmKhuyenMai()
        {
            InitializeComponent();
            _IkhuyenMair = new KhuyenMaiSer();
            _KhuyenMaiView = new KhuyenMaiView();
            LoadData();
        }
        public void LoadData()
        {
            int stt = 1;
            dgird_KhuyenMai.ColumnCount = 6;
            dgird_KhuyenMai.Columns[0].Name = "Stt";
            dgird_KhuyenMai.Columns[1].Name = "ID";
            dgird_KhuyenMai.Columns[0].Visible = false;
            dgird_KhuyenMai.Columns[2].Name = "Gia tri KM";
            dgird_KhuyenMai.Columns[3].Name = "Ma khuyen mai";
            dgird_KhuyenMai.Columns[4].Name = "Ngay bat dau ";
            dgird_KhuyenMai.Columns[5].Name = "Ngay ket thuc ";
            dgird_KhuyenMai.Rows.Clear();
            foreach (var x in _IkhuyenMair.KmGetAll())
            {
                dgird_KhuyenMai.Rows.Add(stt++, x.Id, x.GiaTriKM, x.MaKM, x.NgayBD, x.NgayKT);
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

        private bool kiemtraten(string chuoiCanKiemTra)
        {
            foreach (char kiTu in chuoiCanKiemTra)
            {
                bool dung = false;

                foreach (char kitu2 in chuoisdt)
                {
                    if (kiTu == kitu2) dung = true;
                }
                if (dung == false) return false;
            }


            return true;
        }
        public bool checktrung(string masp)
        {
            var r = _IkhuyenMair.KmGetAll().Any(c => c.MaKM == masp);
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
        public KhuyenMaiView GetDataFromUI()
        {
            _KhuyenMaiView = new KhuyenMaiView()
            {
                Id  =  Guid.NewGuid(),
                GiaTriKM = int.Parse( tbx_GiaTriKM.Text),
                MaKM = tbx_Ma.Text,
                NgayBD = DateTime.Parse(dtp_BatDau.Text),
                NgayKT = DateTime.Parse(dtpKetThuc.Text)
            };
            return _KhuyenMaiView;
        }
        private void dgird_KhuyenMai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_Ma.Text = dgird_KhuyenMai.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbx_GiaTriKM.Text = dgird_KhuyenMai.Rows[e.RowIndex].Cells[2].Value.ToString();
           dtp_BatDau. Text = dgird_KhuyenMai.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtpKetThuc .Text = dgird_KhuyenMai.Rows[e.RowIndex].Cells[5].Value.ToString();
            _id = Guid.Parse( dgird_KhuyenMai.Rows[e.RowIndex].Cells[1].Value.ToString());
            ma=dgird_KhuyenMai.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            TimeSpan songaykm = dtpKetThuc.Value - dtp_BatDau.Value;
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thực hiện chức năng này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                _KhuyenMaiView = new KhuyenMaiView();
                _KhuyenMaiView.Id = Guid.NewGuid();
                if (tbx_Ma.Text.Trim() == "" || kiemtrakitu(tbx_Ma.Text.Trim()) == false)
                {

                    MessageBox.Show("Bạn đang để trống mã khuyến mại hoặc mã khuyến mại có kí tự đặc biệt");
                    return;
                }
                else if (checktrung(tbx_Ma.Text.Trim()) == true)
                {
                    MessageBox.Show("Trùng mã khuyến mại");
                    return;
                }
                else if (tbx_GiaTriKM.Text.Trim() == "" || kiemtraten(tbx_GiaTriKM.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống giá trị khuyến mại hoặc giá trị khuyến mại không đúng định dạng");
                    return;
                }
                else if (songaykm.Days <= 0)
                {

                    MessageBox.Show("Số ngày khuyến mại không hợp lí");
                    return;
                }
                else
                {

                    _KhuyenMaiView.GiaTriKM = int.Parse(tbx_GiaTriKM.Text);
                    _KhuyenMaiView.MaKM = tbx_Ma.Text;
                    _KhuyenMaiView.NgayBD = dtp_BatDau.Value;
                    _KhuyenMaiView.NgayKT = dtpKetThuc.Value;
                    MessageBox.Show(_IkhuyenMair.Add(_KhuyenMaiView));
                    LoadData();
                }

            }
            else
            {
                return;

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromUI();
            temp.Id = _id;
            MessageBox.Show(_IkhuyenMair.Delete(temp));
            LoadData();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            TimeSpan songaykm = dtpKetThuc.Value - dtp_BatDau.Value;

            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thực hiện chức năng này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                _KhuyenMaiView = new KhuyenMaiView();
        
                if (tbx_Ma.Text.Trim() == "" || kiemtrakitu(tbx_Ma.Text.Trim()) == false)
                {

                    MessageBox.Show("Bạn đang để trống mã khuyến mại hoặc mã khuyến mại có kí tự đặc biệt");
                    return;
                }
                else if (checkma(tbx_Ma.Text.Trim()) == false)
                {
                    MessageBox.Show("Trùng mã khuyến mại");
                    return;
                }
                else if (tbx_GiaTriKM.Text.Trim() == "" || kiemtraten(tbx_GiaTriKM.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống giá trị khuyến mại hoặc giá trị khuyến mại không đúng định dạng");
                    return;
                }
                else if(songaykm.Days<=0){

                    MessageBox.Show("Số ngày khuyến mại không hợp lí");
                    return;
                }
                else
                {
                    _KhuyenMaiView.Id = _id;
                    _KhuyenMaiView.GiaTriKM = int.Parse(tbx_GiaTriKM.Text);
                    _KhuyenMaiView.MaKM = tbx_Ma.Text;
                    _KhuyenMaiView.NgayBD = dtp_BatDau.Value;
                    _KhuyenMaiView.NgayKT = dtpKetThuc.Value;
                    MessageBox.Show(_IkhuyenMair.Update(_KhuyenMaiView));
                    LoadData();
                }

            }
            else
            {
                return;

            }
        }
    }
}
