using _1.DAL.Models;
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
    public partial class FrmLoaiSp : Form
    {
        private ILoaiSer _IloaiSpr;
        private LoaiView _LoaiView;
        Guid _id;
        string chuoidung = "1234567890QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopas dfghjklzxcvbnm";
        string chuoisdt = "1234567890";
        string ma;

        public FrmLoaiSp()
        {
            InitializeComponent();
            _IloaiSpr = new LoaiSpSer();
            _LoaiView = new LoaiView();
            LoadData();
        }

        public void LoadData()
        {
            dgird_LoaiSp.ColumnCount = 4;
            int stt = 1;
            dgird_LoaiSp.Columns[0].Name = "Stt";
            dgird_LoaiSp.Columns[1].Name = "ID";
            dgird_LoaiSp.Columns[1].Visible = false;
            dgird_LoaiSp.Columns[2].Name = "Ma Loai san pham";
            dgird_LoaiSp.Columns[3].Name = "Ten loai san pham";
            dgird_LoaiSp.Rows.Clear();
            foreach (var x in _IloaiSpr.LspGetAll())
            {
                dgird_LoaiSp.Rows.Add(stt++, x.Id, x.MaloaiSp, x.TenloaiSp);
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
            var r = _IloaiSpr.LspGetAll().Any(c => c.MaloaiSp == masp);
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
        public LoaiView GetDataFromUI()
        {
            _LoaiView = new LoaiView()
            {
                Id = Guid.NewGuid(),
                MaloaiSp = textBox1.Text,
                TenloaiSp = textBox2.Text,
            };
            return _LoaiView;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {


            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thực hiện chức năng này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                _LoaiView = new LoaiView();
                _LoaiView.Id = Guid.NewGuid();
                if (textBox1.Text.Trim() == "" || kiemtrakitu(textBox1.Text.Trim()) == false)
                {

                    MessageBox.Show("Bạn đang để trống mã hãng sản phẩm hoặc mã hãng sản phẩm có kí tự đặc biệt");
                    return;
                }
                else if (checktrung(textBox1.Text.Trim()) == true)
                {
                    MessageBox.Show("Trùng mã hãng sản phẩm");
                    return;
                }
                else if (textBox2.Text.Trim() == "" || kiemtrakitu(textBox2.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống tên hãng sản phẩm hoặc tên hãng sản phẩm có kí tự đặc biệt");
                    return;
                }
                else
                {
                    _LoaiView.Id = Guid.NewGuid();
                    _LoaiView.MaloaiSp = textBox1.Text;
                    _LoaiView.TenloaiSp = textBox2.Text;
                    MessageBox.Show(_IloaiSpr.Add(_LoaiView));
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


                if (textBox1.Text.Trim() == "" || kiemtrakitu(textBox1.Text.Trim()) == false)
                {

                    MessageBox.Show("Bạn đang để trống mã loai sản phẩm hoặc mã loai sản phẩm có kí tự đặc biệt");
                    return;
                }
                else if (checktrung(textBox1.Text.Trim()) && (textBox1.Text.Trim() != ma == true))
                {
                    MessageBox.Show("Trùng mã loai sản phẩm");
                    return;
                }
                else if (textBox2.Text.Trim() == "" || kiemtrakitu(textBox2.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống tên loai sản phẩm hoặc tên loai sản phẩm có kí tự đặc biệt");
                    return;
                }
                else
                {
                    _LoaiView.Id= _id;
                    _LoaiView.MaloaiSp = textBox1.Text;
                    _LoaiView.TenloaiSp = textBox2.Text;
                    MessageBox.Show(_IloaiSpr.Update(_LoaiView));
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
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thực hiện chức năng này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var temp = _LoaiView;
                temp.Id = _id;
                MessageBox.Show(_IloaiSpr.Delete(temp));
                LoadData();
            }
            else
            {
                return;
            }
        }

        private void FrmLoaiSp_Load(object sender, EventArgs e)
        {

        }

        private void dgird_LoaiSp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgird_LoaiSp.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox2.Text = dgird_LoaiSp.Rows[e.RowIndex].Cells[3].Value.ToString();
            _id = Guid.Parse(dgird_LoaiSp.Rows[e.RowIndex].Cells[1].Value.ToString());
            _LoaiView = _IloaiSpr.LspGetAll().FirstOrDefault(c => c.Id == Guid.Parse(dgird_LoaiSp.Rows[e.RowIndex].Cells[1].Value.ToString()));
            ma = dgird_LoaiSp.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
