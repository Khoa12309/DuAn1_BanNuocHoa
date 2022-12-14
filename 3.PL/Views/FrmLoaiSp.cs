﻿using _1.DAL.Models;
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
        string chuoiten = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopas dfghjklzxcvbnm ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơ" +
                          "ƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂẾưăạảấầẩẫậắằẳẵặẹẻẽềềểếỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ 1234567890";
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
            dgird_LoaiSp.Columns[2].Name = "Tên Loai san pham";
            dgird_LoaiSp.Columns[3].Name = "Mã loai san pham";
            dgird_LoaiSp.Rows.Clear();
            foreach (var x in _IloaiSpr.LspGetAll())
            {
                dgird_LoaiSp.Rows.Add(stt++, x.Id, x.TenloaiSp, x.MaloaiSp);
            }
        }
        public LoaiView GetDataFromUI()
        {
            _LoaiView = new LoaiView()
            {
                Id = Guid.NewGuid(),
                MaloaiSp = txt_ma.Text,
                TenloaiSp =txt_ten.Text,

            };
            return _LoaiView;
        }

        private bool kiemtrakitu(string chuoiCanKiemTra)
        {
            foreach (var kiTu in chuoiCanKiemTra)
            {
                bool dung = false;

                foreach (var kitu2 in chuoiten)
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
        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thực hiện chức năng này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {


                if (txt_ma.Text.Trim() == "" ||kiemtrakitu(txt_ma.Text.Trim()) == false)
                {

                    MessageBox.Show("Bạn đang để trống mã loai sản phẩm hoặc mã loai sản phẩm có kí tự đặc biệt");
                    return;
                }
                else if (checktrung(txt_ma.Text.Trim()) && (txt_ma.Text.Trim() != ma == true))
                {
                    MessageBox.Show("Trùng mã loai sản phẩm");
                    return;
                }
                else if (txt_ten.Text.Trim() == "" || kiemtrakitu(txt_ten.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống tên loai sản phẩm hoặc tên loai sản phẩm có kí tự đặc biệt");
                    return;
                }
                else
                {
                    _LoaiView.Id = Guid.NewGuid();
                    _LoaiView.MaloaiSp = txt_ma.Text;
                    _LoaiView.TenloaiSp = txt_ten.Text;
                    MessageBox.Show(_IloaiSpr.Add(GetDataFromUI()));
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


                if (txt_ma.Text.Trim() == "" || kiemtrakitu(txt_ma.Text.Trim()) == false)
                {

                    MessageBox.Show("Bạn đang để trống mã loai sản phẩm hoặc mã loai sản phẩm có kí tự đặc biệt");
                    return;
                }
                else if (txt_ten.Text.Trim() == "" || kiemtrakitu(txt_ten.Text.Trim()) == false)
                {
                    MessageBox.Show("Bạn đang để trống tên loai sản phẩm hoặc tên loai sản phẩm có kí tự đặc biệt");
                    return;
                }
                else
                {
                    _LoaiView.Id = _id;
                    _LoaiView.MaloaiSp = txt_ma.Text;
                    _LoaiView.TenloaiSp = txt_ten.Text;
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
            txt_ten.Text = dgird_LoaiSp.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_ma.Text = dgird_LoaiSp.Rows[e.RowIndex].Cells[3].Value.ToString();
            _id = Guid.Parse(dgird_LoaiSp.Rows[e.RowIndex].Cells[1].Value.ToString());
            _LoaiView = _IloaiSpr.LspGetAll().FirstOrDefault(c => c.Id == Guid.Parse(dgird_LoaiSp.Rows[e.RowIndex].Cells[1].Value.ToString()));
            ma = dgird_LoaiSp.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        void close()
        {
            label3.Click += label3_Click;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
