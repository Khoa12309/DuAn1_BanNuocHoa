using _2.BUS.IServices;
using _2.BUS.Services;
using Accessibility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmSanPham : Form
    {
        private ISanPhamSer _Iser;
        private IKhoSer _KhoSer;
        private ILoaiSer _LoaiSer;
        private IHangSer _HangSer;
        private Guid _id;


        public FrmSanPham()
        {
            InitializeComponent();
            _KhoSer = new KhoSer();
            _HangSer = new HangSpSer();
            _Iser = new SanPhamSer();
            _LoaiSer = new LoaiSpSer();
            loadcmb();
            loadfrm();
        }

        private void loadfrm()
        {
            var stt = 1;
            dgrid_sp.ColumnCount = 14;
            dgrid_sp.Columns[0].Name = "Stt";
            dgrid_sp.Columns[1].Name = "ID";
            dgrid_sp.Columns[2].Name = "Mã SP";
            dgrid_sp.Columns[3].Name = "Tên SP";
            dgrid_sp.Columns[4].Name = "Mùi Hương";
            dgrid_sp.Columns[5].Name = "Dung Tích";
            dgrid_sp.Columns[6].Name = "Hình Ảnh";
            dgrid_sp.Columns[7].Name = "Số Lượng";
            dgrid_sp.Columns[8].Name = "Trạng Thái";
            dgrid_sp.Columns[9].Name = "Loại";
            dgrid_sp.Columns[10].Name = "Kho";
            dgrid_sp.Columns[11].Name = "Hãng";
            dgrid_sp.Columns[12].Name = "Giá Nhập";
            dgrid_sp.Columns[13].Name = "Giá Bán";
           
            dgrid_sp.Rows.Clear();
            this.dgrid_sp.Columns["ID"].Visible=false;
            foreach (var x in _Iser.SpGetAll())
            {
                dgrid_sp.Rows.Add(stt, x.MaSp, x.TenSp, x.MuiHuong, x.DungTich, x.HinhAnh, x.Solong, x.TrangThai, x.TrangThai,x.tenloai,x.IDKho,x.tenhang,x.GiaNhap,x.GiaBan);
            }
        }

        private void loadcmb()
        {
            foreach (var x in _HangSer.HspGetAll())
            {
                cmb_Hang.Items.Add(x.TenHang);
            }
            cmb_Hang.SelectedIndex = 0;
            foreach (var x in _LoaiSer.LspGetAll())
            {
                cmb_loai.Items.Add(x.TenloaiSp);
            }
            //cmb_loai.SelectedIndex = 0;
            foreach (var x in _KhoSer.KhoGetAll())
            {
                cmb_kho.Items.Add(x.Id);
            }
            //cmb_kho.SelectedIndex = 0;
        }

        private byte[] epbyte(PictureBox pc)
        {
            MemoryStream ms= new MemoryStream();
            pcb_anh.Image.Save(ms, pcb_anh.Image.RawFormat);
            return ms.ToArray();
        }

        private void btn_chonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Chọn Hình Ảnh";
            opf.Filter = "Image Files (*.gif;*.jpg;*.png)|*.gif;*.jpg;*.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pcb_anh.ImageLocation = opf.FileName;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dgrid_sp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
