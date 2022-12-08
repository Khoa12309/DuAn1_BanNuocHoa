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
            this.pb = new System.Windows.Forms.PictureBox();
            this.btn_taoqr = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_muisp = new System.Windows.Forms.TextBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.txt_dt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_gn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_gb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_Hang = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_loai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtn_ch = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rrbtn_hh = new System.Windows.Forms.RadioButton();
            this.lable = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_anh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_sp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_chonAnh
            // 
            this.btn_chonAnh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_chonAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_chonAnh.Location = new System.Drawing.Point(61, 253);
            this.btn_chonAnh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_chonAnh.Name = "btn_chonAnh";
            this.btn_chonAnh.Size = new System.Drawing.Size(133, 57);
            this.btn_chonAnh.TabIndex = 0;
            this.btn_chonAnh.Text = "Chọn Ảnh";
            this.btn_chonAnh.UseVisualStyleBackColor = false;
            this.btn_chonAnh.Click += new System.EventHandler(this.btn_chonAnh_Click);
            // 
            // pcb_anh
            // 
            this.pcb_anh.Location = new System.Drawing.Point(22, 25);
            this.pcb_anh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcb_anh.Name = "pcb_anh";
            this.pcb_anh.Size = new System.Drawing.Size(196, 157);
            this.pcb_anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_anh.TabIndex = 1;
            this.pcb_anh.TabStop = false;
            // 
            // dgrid_sp
            // 
            this.dgrid_sp.AllowUserToAddRows = false;
            this.dgrid_sp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_sp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgrid_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_sp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_sp.Location = new System.Drawing.Point(0, 398);
            this.dgrid_sp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_sp.Name = "dgrid_sp";
            this.dgrid_sp.RowHeadersWidth = 51;
            this.dgrid_sp.RowTemplate.Height = 29;
            this.dgrid_sp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_sp.Size = new System.Drawing.Size(1445, 148);
            this.dgrid_sp.TabIndex = 2;
            this.dgrid_sp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_sp_CellContentClick);
            // 
            // txt_tk
            // 
            this.txt_tk.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_tk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tk.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tk.Location = new System.Drawing.Point(13, 11);
            this.txt_tk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.PlaceholderText = "Tìm Kiếm...";
            this.txt_tk.Size = new System.Drawing.Size(262, 32);
            this.txt_tk.TabIndex = 3;
            this.txt_tk.TextChanged += new System.EventHandler(this.txt_tk_TextChanged);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_them.Location = new System.Drawing.Point(189, 256);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(135, 57);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_sua.Location = new System.Drawing.Point(370, 256);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(135, 57);
            this.btn_sua.TabIndex = 5;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_xoa.Location = new System.Drawing.Point(551, 256);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(135, 57);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.Location = new System.Drawing.Point(25, 21);
            this.pb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(196, 157);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb.TabIndex = 29;
            this.pb.TabStop = false;
            // 
            // btn_taoqr
            // 
            this.btn_taoqr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_taoqr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_taoqr.Location = new System.Drawing.Point(115, 256);
            this.btn_taoqr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_taoqr.Name = "btn_taoqr";
            this.btn_taoqr.Size = new System.Drawing.Size(135, 57);
            this.btn_taoqr.TabIndex = 30;
            this.btn_taoqr.Text = "Tạo QR";
            this.btn_taoqr.UseVisualStyleBackColor = false;
            this.btn_taoqr.Click += new System.EventHandler(this.btn_taoqr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.pcb_anh);
            this.groupBox1.Location = new System.Drawing.Point(13, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 209);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.pb);
            this.groupBox2.Location = new System.Drawing.Point(56, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 209);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // txt_muisp
            // 
            this.txt_muisp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_muisp.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_muisp.Location = new System.Drawing.Point(135, 119);
            this.txt_muisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_muisp.Name = "txt_muisp";
            this.txt_muisp.Size = new System.Drawing.Size(292, 29);
            this.txt_muisp.TabIndex = 20;
            // 
            // txt_tensp
            // 
            this.txt_tensp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tensp.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tensp.Location = new System.Drawing.Point(135, 73);
            this.txt_tensp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(292, 29);
            this.txt_tensp.TabIndex = 19;
            // 
            // txt_dt
            // 
            this.txt_dt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_dt.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dt.Location = new System.Drawing.Point(135, 164);
            this.txt_dt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dt.Name = "txt_dt";
            this.txt_dt.Size = new System.Drawing.Size(292, 29);
            this.txt_dt.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(451, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Trạng Thái";
            // 
            // txt_sl
            // 
            this.txt_sl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_sl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_sl.Location = new System.Drawing.Point(132, 212);
            this.txt_sl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(292, 29);
            this.txt_sl.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(451, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Loại";
            // 
            // txt_gn
            // 
            this.txt_gn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_gn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_gn.Location = new System.Drawing.Point(545, 30);
            this.txt_gn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gn.Name = "txt_gn";
            this.txt_gn.Size = new System.Drawing.Size(275, 33);
            this.txt_gn.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(451, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hãng";
            // 
            // txt_gb
            // 
            this.txt_gb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_gb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_gb.Location = new System.Drawing.Point(545, 74);
            this.txt_gb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gb.Name = "txt_gb";
            this.txt_gb.Size = new System.Drawing.Size(275, 33);
            this.txt_gb.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(451, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Giá Bán";
            // 
            // cmb_Hang
            // 
            this.cmb_Hang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Hang.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Hang.FormattingEnabled = true;
            this.cmb_Hang.Location = new System.Drawing.Point(545, 117);
            this.cmb_Hang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Hang.Name = "cmb_Hang";
            this.cmb_Hang.Size = new System.Drawing.Size(275, 33);
            this.cmb_Hang.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(451, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Giá Nhập";
            // 
            // cmb_loai
            // 
            this.cmb_loai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_loai.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_loai.FormattingEnabled = true;
            this.cmb_loai.Location = new System.Drawing.Point(545, 165);
            this.cmb_loai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_loai.Name = "cmb_loai";
            this.cmb_loai.Size = new System.Drawing.Size(275, 33);
            this.cmb_loai.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(30, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số Lượng";
            // 
            // rbtn_ch
            // 
            this.rbtn_ch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_ch.AutoSize = true;
            this.rbtn_ch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_ch.Location = new System.Drawing.Point(580, 208);
            this.rbtn_ch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_ch.Name = "rbtn_ch";
            this.rbtn_ch.Size = new System.Drawing.Size(117, 28);
            this.rbtn_ch.TabIndex = 27;
            this.rbtn_ch.TabStop = true;
            this.rbtn_ch.Text = "Còn hàng";
            this.rbtn_ch.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dung Tích";
            // 
            // rrbtn_hh
            // 
            this.rrbtn_hh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rrbtn_hh.AutoSize = true;
            this.rrbtn_hh.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rrbtn_hh.Location = new System.Drawing.Point(727, 206);
            this.rrbtn_hh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rrbtn_hh.Name = "rrbtn_hh";
            this.rrbtn_hh.Size = new System.Drawing.Size(111, 28);
            this.rrbtn_hh.TabIndex = 28;
            this.rrbtn_hh.TabStop = true;
            this.rrbtn_hh.Text = "Hết hàng";
            this.rrbtn_hh.UseVisualStyleBackColor = true;
            // 
            // lable
            // 
            this.lable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lable.Location = new System.Drawing.Point(59, 123);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(41, 25);
            this.lable.TabIndex = 9;
            this.lable.Text = "Mùi";
            // 
            // la
            // 
            this.la.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.la.AutoSize = true;
            this.la.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.la.Location = new System.Drawing.Point(59, 77);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(43, 25);
            this.la.TabIndex = 8;
            this.la.Text = "Tên";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã";
            // 
            // txt_masp
            // 
            this.txt_masp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_masp.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_masp.Location = new System.Drawing.Point(135, 28);
            this.txt_masp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(292, 29);
            this.txt_masp.TabIndex = 18;
            // 
            // sqlCommandBuilder1
            // 
            this.sqlCommandBuilder1.DataAdapter = null;
            this.sqlCommandBuilder1.QuotePrefix = "[";
            this.sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.txt_tk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 53);
            this.panel1.TabIndex = 33;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.btn_chonAnh);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 345);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_masp);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txt_muisp);
            this.groupBox4.Controls.Add(this.txt_sl);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lable);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txt_tensp);
            this.groupBox4.Controls.Add(this.txt_dt);
            this.groupBox4.Controls.Add(this.btn_sua);
            this.groupBox4.Controls.Add(this.la);
            this.groupBox4.Controls.Add(this.txt_gn);
            this.groupBox4.Controls.Add(this.btn_xoa);
            this.groupBox4.Controls.Add(this.txt_gb);
            this.groupBox4.Controls.Add(this.btn_them);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.rbtn_ch);
            this.groupBox4.Controls.Add(this.cmb_loai);
            this.groupBox4.Controls.Add(this.rrbtn_hh);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cmb_Hang);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(275, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1170, 345);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.btn_taoqr);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.Location = new System.Drawing.Point(1119, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(326, 345);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1445, 546);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgrid_sp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmSanPham";
            this.Text = "FrmSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_anh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_chonAnh;
        private System.Windows.Forms.PictureBox pcb_anh;
        private System.Windows.Forms.DataGridView dgrid_sp;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button btn_taoqr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_muisp;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.TextBox txt_dt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_gn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_gb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_Hang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_loai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtn_ch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rrbtn_hh;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_masp;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}