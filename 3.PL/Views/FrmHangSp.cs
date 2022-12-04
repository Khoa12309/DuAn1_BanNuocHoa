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
    public partial class FrmHangSp : Form
    {
        private IHangSer _IHangSpr;
        private HangView _HangSp_view;
        Guid _id;

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
        public HangView GetDataFromGUI()
        {
            _HangSp_view = new HangView()
            {
                ID = Guid.NewGuid(),
                MaHang = tbx_MaSp.Text,
                TenHang = tbx_Tensp.Text,
            };
            return _HangSp_view;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_MaSp.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbx_Tensp.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            _id = Guid.Parse( dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_IHangSpr.Add(GetDataFromGUI()));
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGUI();
            temp.ID = _id;
            
            MessageBox.Show(_IHangSpr.Update(temp));
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGUI();
            temp.ID = _id;
            MessageBox.Show(_IHangSpr.Delete(temp));
            LoadData();
        }
    }
}
