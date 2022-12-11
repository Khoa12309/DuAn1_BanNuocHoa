namespace _3.PL.Views
{
    partial class FrmTaiKhoan
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
            this.dgird_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_MaNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_TenNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_DiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbtn_DangDiLam = new System.Windows.Forms.RadioButton();
            this.tbx_MK = new System.Windows.Forms.TextBox();
            this.tbx_Ten_TK = new System.Windows.Forms.TextBox();
            this.tbx_SoDienThoai = new System.Windows.Forms.TextBox();
            this.rbtn_DaNghi = new System.Windows.Forms.RadioButton();
            this.cmb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_ChucVu = new System.Windows.Forms.ComboBox();
            this.btn_ca = new System.Windows.Forms.Button();
            this.pb_ca = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgird_TaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ca)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgird_TaiKhoan
            // 
            this.dgird_TaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgird_TaiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgird_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgird_TaiKhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgird_TaiKhoan.Location = new System.Drawing.Point(0, 293);
            this.dgird_TaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgird_TaiKhoan.Name = "dgird_TaiKhoan";
            this.dgird_TaiKhoan.RowHeadersWidth = 51;
            this.dgird_TaiKhoan.RowTemplate.Height = 29;
            this.dgird_TaiKhoan.Size = new System.Drawing.Size(1412, 237);
            this.dgird_TaiKhoan.TabIndex = 0;
            this.dgird_TaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgird_TaiKhoan_CellContentClick);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Add.Location = new System.Drawing.Point(12, 213);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(110, 37);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Delete.Location = new System.Drawing.Point(304, 213);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(110, 37);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Update.Location = new System.Drawing.Point(157, 213);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(110, 37);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên tài Khoản";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mật khẩu";
            // 
            // tbx_MaNhanVien
            // 
            this.tbx_MaNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_MaNhanVien.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_MaNhanVien.Location = new System.Drawing.Point(149, 30);
            this.tbx_MaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_MaNhanVien.Name = "tbx_MaNhanVien";
            this.tbx_MaNhanVien.Size = new System.Drawing.Size(205, 29);
            this.tbx_MaNhanVien.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã nhân viên";
            // 
            // tbx_TenNhanVien
            // 
            this.tbx_TenNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_TenNhanVien.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_TenNhanVien.Location = new System.Drawing.Point(149, -23);
            this.tbx_TenNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_TenNhanVien.Name = "tbx_TenNhanVien";
            this.tbx_TenNhanVien.Size = new System.Drawing.Size(205, 29);
            this.tbx_TenNhanVien.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, -15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên nhân viên";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(47, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Giới Tính";
            // 
            // tbx_DiaChi
            // 
            this.tbx_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_DiaChi.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_DiaChi.Location = new System.Drawing.Point(188, -23);
            this.tbx_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_DiaChi.Name = "tbx_DiaChi";
            this.tbx_DiaChi.Size = new System.Drawing.Size(244, 29);
            this.tbx_DiaChi.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(50, -15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(47, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(47, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Trạng thái";
            // 
            // rbtn_DangDiLam
            // 
            this.rbtn_DangDiLam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_DangDiLam.AutoSize = true;
            this.rbtn_DangDiLam.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_DangDiLam.Location = new System.Drawing.Point(188, 123);
            this.rbtn_DangDiLam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_DangDiLam.Name = "rbtn_DangDiLam";
            this.rbtn_DangDiLam.Size = new System.Drawing.Size(128, 26);
            this.rbtn_DangDiLam.TabIndex = 20;
            this.rbtn_DangDiLam.TabStop = true;
            this.rbtn_DangDiLam.Text = "Đang đi làm";
            this.rbtn_DangDiLam.UseVisualStyleBackColor = true;
            // 
            // tbx_MK
            // 
            this.tbx_MK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_MK.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_MK.Location = new System.Drawing.Point(149, 162);
            this.tbx_MK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_MK.Name = "tbx_MK";
            this.tbx_MK.Size = new System.Drawing.Size(205, 29);
            this.tbx_MK.TabIndex = 7;
            // 
            // tbx_Ten_TK
            // 
            this.tbx_Ten_TK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_Ten_TK.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_Ten_TK.Location = new System.Drawing.Point(149, 98);
            this.tbx_Ten_TK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_Ten_TK.Name = "tbx_Ten_TK";
            this.tbx_Ten_TK.Size = new System.Drawing.Size(205, 29);
            this.tbx_Ten_TK.TabIndex = 5;
            // 
            // tbx_SoDienThoai
            // 
            this.tbx_SoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_SoDienThoai.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_SoDienThoai.Location = new System.Drawing.Point(188, 78);
            this.tbx_SoDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_SoDienThoai.Name = "tbx_SoDienThoai";
            this.tbx_SoDienThoai.Size = new System.Drawing.Size(244, 29);
            this.tbx_SoDienThoai.TabIndex = 13;
            // 
            // rbtn_DaNghi
            // 
            this.rbtn_DaNghi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_DaNghi.AutoSize = true;
            this.rbtn_DaNghi.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_DaNghi.Location = new System.Drawing.Point(326, 123);
            this.rbtn_DaNghi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_DaNghi.Name = "rbtn_DaNghi";
            this.rbtn_DaNghi.Size = new System.Drawing.Size(92, 26);
            this.rbtn_DaNghi.TabIndex = 21;
            this.rbtn_DaNghi.TabStop = true;
            this.rbtn_DaNghi.Text = "Đã nghỉ";
            this.rbtn_DaNghi.UseVisualStyleBackColor = true;
            // 
            // cmb_GioiTinh
            // 
            this.cmb_GioiTinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_GioiTinh.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_GioiTinh.FormattingEnabled = true;
            this.cmb_GioiTinh.Location = new System.Drawing.Point(188, 34);
            this.cmb_GioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_GioiTinh.Name = "cmb_GioiTinh";
            this.cmb_GioiTinh.Size = new System.Drawing.Size(244, 30);
            this.cmb_GioiTinh.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(50, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 22);
            this.label9.TabIndex = 24;
            this.label9.Text = "Chức vụ";
            // 
            // cmb_ChucVu
            // 
            this.cmb_ChucVu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_ChucVu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_ChucVu.FormattingEnabled = true;
            this.cmb_ChucVu.Location = new System.Drawing.Point(188, 159);
            this.cmb_ChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_ChucVu.Name = "cmb_ChucVu";
            this.cmb_ChucVu.Size = new System.Drawing.Size(244, 30);
            this.cmb_ChucVu.TabIndex = 25;
            // 
            // btn_ca
            // 
            this.btn_ca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ca.Location = new System.Drawing.Point(197, 213);
            this.btn_ca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ca.Name = "btn_ca";
            this.btn_ca.Size = new System.Drawing.Size(110, 37);
            this.btn_ca.TabIndex = 26;
            this.btn_ca.Text = "Chọn ảnh";
            this.btn_ca.UseVisualStyleBackColor = false;
            this.btn_ca.Click += new System.EventHandler(this.btn_ca_Click);
            // 
            // pb_ca
            // 
            this.pb_ca.Location = new System.Drawing.Point(27, 27);
            this.pb_ca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_ca.Name = "pb_ca";
            this.pb_ca.Size = new System.Drawing.Size(282, 144);
            this.pb_ca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ca.TabIndex = 27;
            this.pb_ca.TabStop = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(50, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 22);
            this.label10.TabIndex = 29;
            this.label10.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_email.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.Location = new System.Drawing.Point(188, 205);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(258, 29);
            this.txt_email.TabIndex = 28;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TimKiem.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TimKiem.Location = new System.Drawing.Point(3, 11);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PlaceholderText = "Tìm Kiếm...";
            this.txt_TimKiem.Size = new System.Drawing.Size(236, 28);
            this.txt_TimKiem.TabIndex = 30;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.pb_ca);
            this.groupBox1.Location = new System.Drawing.Point(84, -33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 195);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.txt_TimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 57);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbx_TenNhanVien);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Controls.Add(this.btn_Update);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbx_Ten_TK);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbx_MK);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbx_MaNhanVien);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 236);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.tbx_DiaChi);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbx_SoDienThoai);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_email);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.rbtn_DangDiLam);
            this.groupBox3.Controls.Add(this.cmb_ChucVu);
            this.groupBox3.Controls.Add(this.rbtn_DaNghi);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cmb_GioiTinh);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(921, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 236);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.btn_ca);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(420, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(501, 236);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            // 
            // FrmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1412, 530);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgird_TaiKhoan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.FrmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgird_TaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ca)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgird_TaiKhoan;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_MaNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_TenNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_DiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbtn_DangDiLam;
        private System.Windows.Forms.TextBox tbx_MK;
        private System.Windows.Forms.TextBox tbx_Ten_TK;
        private System.Windows.Forms.TextBox tbx_SoDienThoai;
        private System.Windows.Forms.RadioButton rbtn_DaNghi;
        private System.Windows.Forms.ComboBox cmb_GioiTinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_ChucVu;
        private System.Windows.Forms.Button btn_ca;
        private System.Windows.Forms.PictureBox pb_ca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}