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
            MessageBox.Show(_IloaiSpr.Add(GetDataFromUI()));
            LoadData();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromUI();
            temp.Id = _id;
            MessageBox.Show(_IloaiSpr.Update(temp));
            LoadData();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromUI();
            temp.Id = _id;
            MessageBox.Show(_IloaiSpr.Delete(temp));
            LoadData();
        }

        private void FrmLoaiSp_Load(object sender, EventArgs e)
        {

        }

        private void dgird_LoaiSp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgird_LoaiSp.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox2.Text = dgird_LoaiSp.Rows[e.RowIndex].Cells[3].Value.ToString();
            _id = Guid.Parse(dgird_LoaiSp.Rows[e.RowIndex].Cells[1].Value.ToString());
        }
    }
}
