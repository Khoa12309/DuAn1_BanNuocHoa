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
using System.Text.RegularExpressions;
using ZXing;

namespace _3.PL.Views
{
    public partial class FrmHangSp : Form
    {
        private IHangSer _IHangSpr;
        private HangView _HangSp_view;
        Guid _id;
        string chuoidung = "1234567890QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopas dfghjklzxcvbnm";
        string chuoisdt = "1234567890";
        string ma;
        public FrmHangSp()
        {
            InitializeComponent();
            _IHangSpr = new HangSpSer();
            _HangSp_view = new HangView();
            LoadData();
        }
        public void LoadData()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Name = "Ten";
            dataGridView1.Columns[2].Name = "Ma";
            dataGridView1.Rows.Clear();
            foreach (var x in _IHangSpr.HspGetAll())
            {
                dataGridView1.Rows.Add(x.ID, x.TenHang, x.MaHang);
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_MaSp.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbx_Tensp.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            _id = Guid.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            _HangSp_view = _IHangSpr.HspGetAll().FirstOrDefault(c => c.ID == Guid.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
           ma = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(); 
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
            var r = _IHangSpr.HspGetAll().Any(c=>c.MaHang == masp);
            if ( r ==true) { return true; }
            return false;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {



            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thực hiện chức năng này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                _HangSp_view = new HangView();
                _HangSp_view.ID = Guid.NewGuid();
                if (tbx_MaSp.Text.Trim() == "" || kiemtrakitu(tbx_MaSp.Text.Trim()) == false)
                {

                    MessageBox.Show("Bạn đang để trống mã hãng sản phẩm hoặc mã hãng sản phẩm có kí tự đặc biệt");
                    return;
                }
                else if (checktrung(tbx_MaSp.Text.Trim()) == true)
                {
                    MessageBox.Show("Trùng mã hãng sản phẩm");
                    return;
                }
                else if (tbx_Tensp.Text.Trim() == "" || kiemtrakitu(tbx_Tensp.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống tên hãng sản phẩm hoặc tên hãng sản phẩm có kí tự đặc biệt");
                    return;
                }
                else
                {
                    _HangSp_view.MaHang = tbx_MaSp.Text;
                    _HangSp_view.TenHang = tbx_Tensp.Text;
                    MessageBox.Show(_IHangSpr.Add(_HangSp_view));
                    LoadData();
                }

            }
            else
            {
                return;

            }
        }


        public bool checkma(string ma2)
        {
            if (ma2 == ma) { return true; }
            else if (checktrung(ma2) == true) { return false; }
            else { return true; }
            return true;

        }
            private void btn_Sua_Click(object sender, EventArgs e)
            {



                DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thực hiện chức năng này không ? ", "Thông báo", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    
               
                    if (tbx_MaSp.Text.Trim() == "" || kiemtrakitu(tbx_MaSp.Text.Trim()) == false)
                    {

                        MessageBox.Show("Bạn đang để trống mã hãng sản phẩm hoặc mã hãng sản phẩm có kí tự đặc biệt");
                        return;
                    }
                    else if (checktrung(tbx_MaSp.Text.Trim()) && (tbx_MaSp.Text.Trim() != ma == true))
                    {
                        MessageBox.Show("Trùng mã hãng sản phẩm");
                        return;
                    }
                    else if (tbx_Tensp.Text.Trim() == "" || kiemtrakitu(tbx_Tensp.Text.Trim()) == false)
                    {
                        MessageBox.Show("Bạn đang để trống tên hãng sản phẩm hoặc tên hãng sản phẩm có kí tự đặc biệt");
                        return;
                    }
                    else
                    {
                        _HangSp_view.ID = _id;
                        _HangSp_view.MaHang = tbx_MaSp.Text;
                        _HangSp_view.TenHang = tbx_Tensp.Text;
                        MessageBox.Show(_IHangSpr.Update(_HangSp_view));
                        LoadData();
                    }

                }
                else
                {
                    return;

                }

            } 

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thực hiện chức năng này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                var temp = _HangSp_view;
                temp.ID = _id;
                MessageBox.Show(_IHangSpr.Delete(temp));
                LoadData();
            }
            else
            {
                return;
            }
        }
    }
}
