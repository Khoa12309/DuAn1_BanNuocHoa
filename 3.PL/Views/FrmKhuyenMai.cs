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
        public KhuyenMaiView GetDataFromUI()
        {
            _KhuyenMaiView = new KhuyenMaiView()
            {
                Id  =  Guid.NewGuid(),
                GiaTriKM = int.Parse( tbx_GiaTriKM.Text),
                MaKM = tbx_Ma.Text,
                NgayBD = dtp_BatDau.Value,
                NgayKT = dtpKetThuc.Value,
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
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_IkhuyenMair.Add(GetDataFromUI()));
            LoadData();
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
            var temp = GetDataFromUI();
            temp.Id = _id;
            MessageBox.Show(_IkhuyenMair.Update(temp));
            LoadData();
        }
    }
}
