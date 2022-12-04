namespace _3.PL.Views
{
    partial class FrmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_chonAnh = new System.Windows.Forms.Button();
            this.pcb_anh = new System.Windows.Forms.PictureBox();
            this.dgrid_sp = new System.Windows.Forms.DataGridView();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.txt_muisp = new System.Windows.Forms.TextBox();
            this.txt_dt = new System.Windows.Forms.TextBox();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.txt_gb = new System.Windows.Forms.TextBox();
            this.txt_gn = new System.Windows.Forms.TextBox();
            this.cmb_Hang = new System.Windows.Forms.ComboBox();
            this.cmb_loai = new System.Windows.Forms.ComboBox();
            this.rbtn_ch = new System.Windows.Forms.RadioButton();
            this.rrbtn_hh = new System.Windows.Forms.RadioButton();
            this.pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_anh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_sp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_chonAnh
            // 
            this.btn_chonAnh.Location = new System.Drawing.Point(12, 227);
            this.btn_chonAnh.Name = "btn_chonAnh";
            this.btn_chonAnh.Size = new System.Drawing.Size(94, 29);
            this.btn_chonAnh.TabIndex = 0;
            this.btn_chonAnh.Text = "Chọn Ảnh";
            this.btn_chonAnh.UseVisualStyleBackColor = true;
            this.btn_chonAnh.Click += new System.EventHandler(this.btn_chonAnh_Click);
            // 
            // pcb_anh
            // 
            this.pcb_anh.Location = new System.Drawing.Point(12, 12);
            this.pcb_anh.Name = "pcb_anh";
            this.pcb_anh.Size = new System.Drawing.Size(224, 209);
            this.pcb_anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_anh.TabIndex = 1;
            this.pcb_anh.TabStop = false;
            // 
            // dgrid_sp
            // 
            this.dgrid_sp.AllowUserToAddRows = false;
            this.dgrid_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_sp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_sp.Location = new System.Drawing.Point(0, 345);
            this.dgrid_sp.Name = "dgrid_sp";
            this.dgrid_sp.RowHeadersWidth = 51;
            this.dgrid_sp.RowTemplate.Height = 29;
            this.dgrid_sp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_sp.Size = new System.Drawing.Size(1185, 197);
            this.dgrid_sp.TabIndex = 2;
            this.dgrid_sp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_sp_CellContentClick);
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(12, 312);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(252, 27);
            this.txt_tk.TabIndex = 3;
            this.txt_tk.Text = "Tìm Kiếm";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(851, 94);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(94, 29);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(851, 162);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 29);
            this.btn_sua.TabIndex = 5;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(851, 230);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(94, 29);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã";
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(282, 85);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(32, 20);
            this.la.TabIndex = 8;
            this.la.Text = "Tên";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(282, 133);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(34, 20);
            this.lable.TabIndex = 9;
            this.lable.Text = "Mùi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dung Tích";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số Lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Trạng Thái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(576, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Loại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(576, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hãng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(576, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Giá Bán";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(577, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Giá Nhập";
            // 
            // txt_masp
            // 
            this.txt_masp.Location = new System.Drawing.Point(361, 37);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(125, 27);
            this.txt_masp.TabIndex = 18;
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(361, 85);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(125, 27);
            this.txt_tensp.TabIndex = 19;
            // 
            // txt_muisp
            // 
            this.txt_muisp.Location = new System.Drawing.Point(361, 133);
            this.txt_muisp.Name = "txt_muisp";
            this.txt_muisp.Size = new System.Drawing.Size(125, 27);
            this.txt_muisp.TabIndex = 20;
            // 
            // txt_dt
            // 
            this.txt_dt.Location = new System.Drawing.Point(361, 183);
            this.txt_dt.Name = "txt_dt";
            this.txt_dt.Size = new System.Drawing.Size(125, 27);
            this.txt_dt.TabIndex = 21;
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(361, 236);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(125, 27);
            this.txt_sl.TabIndex = 22;
            // 
            // txt_gb
            // 
            this.txt_gb.Location = new System.Drawing.Point(653, 90);
            this.txt_gb.Name = "txt_gb";
            this.txt_gb.Size = new System.Drawing.Size(125, 27);
            this.txt_gb.TabIndex = 24;
            // 
            // txt_gn
            // 
            this.txt_gn.Location = new System.Drawing.Point(653, 37);
            this.txt_gn.Name = "txt_gn";
            this.txt_gn.Size = new System.Drawing.Size(125, 27);
            this.txt_gn.TabIndex = 23;
            // 
            // cmb_Hang
            // 
            this.cmb_Hang.FormattingEnabled = true;
            this.cmb_Hang.Location = new System.Drawing.Point(653, 132);
            this.cmb_Hang.Name = "cmb_Hang";
            this.cmb_Hang.Size = new System.Drawing.Size(151, 28);
            this.cmb_Hang.TabIndex = 25;
            // 
            // cmb_loai
            // 
            this.cmb_loai.FormattingEnabled = true;
            this.cmb_loai.Location = new System.Drawing.Point(653, 183);
            this.cmb_loai.Name = "cmb_loai";
            this.cmb_loai.Size = new System.Drawing.Size(151, 28);
            this.cmb_loai.TabIndex = 26;
            // 
            // rbtn_ch
            // 
            this.rbtn_ch.AutoSize = true;
            this.rbtn_ch.Location = new System.Drawing.Point(653, 237);
            this.rbtn_ch.Name = "rbtn_ch";
            this.rbtn_ch.Size = new System.Drawing.Size(93, 24);
            this.rbtn_ch.TabIndex = 27;
            this.rbtn_ch.TabStop = true;
            this.rbtn_ch.Text = "Còn hàng";
            this.rbtn_ch.UseVisualStyleBackColor = true;
            // 
            // rrbtn_hh
            // 
            this.rrbtn_hh.AutoSize = true;
            this.rrbtn_hh.Location = new System.Drawing.Point(656, 273);
            this.rrbtn_hh.Name = "rrbtn_hh";
            this.rrbtn_hh.Size = new System.Drawing.Size(91, 24);
            this.rrbtn_hh.TabIndex = 28;
            this.rrbtn_hh.TabStop = true;
            this.rrbtn_hh.Text = "Hết hàng";
            this.rrbtn_hh.UseVisualStyleBackColor = true;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(963, 48);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(210, 208);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb.TabIndex = 29;
            this.pb.TabStop = false;
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 542);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.rrbtn_hh);
            this.Controls.Add(this.rbtn_ch);
            this.Controls.Add(this.cmb_loai);
            this.Controls.Add(this.cmb_Hang);
            this.Controls.Add(this.txt_gb);
            this.Controls.Add(this.txt_gn);
            this.Controls.Add(this.txt_sl);
            this.Controls.Add(this.txt_dt);
            this.Controls.Add(this.txt_muisp);
            this.Controls.Add(this.txt_tensp);
            this.Controls.Add(this.txt_masp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.la);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.dgrid_sp);
            this.Controls.Add(this.pcb_anh);
            this.Controls.Add(this.btn_chonAnh);
            this.Name = "FrmSanPham";
            this.Text = "FrmSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_anh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_chonAnh;
        private System.Windows.Forms.PictureBox pcb_anh;
        private System.Windows.Forms.DataGridView dgrid_sp;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.TextBox txt_muisp;
        private System.Windows.Forms.TextBox txt_dt;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.TextBox txt_gb;
        private System.Windows.Forms.TextBox txt_gn;
        private System.Windows.Forms.ComboBox cmb_Hang;
        private System.Windows.Forms.ComboBox cmb_loai;
        private System.Windows.Forms.RadioButton rbtn_ch;
        private System.Windows.Forms.RadioButton rrbtn_hh;
        private System.Windows.Forms.PictureBox pb;
    }
}