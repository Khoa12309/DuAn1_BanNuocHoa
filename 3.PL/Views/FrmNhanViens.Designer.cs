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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgird_TaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgird_TaiKhoan
            // 
            this.dgird_TaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgird_TaiKhoan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgird_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgird_TaiKhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgird_TaiKhoan.Location = new System.Drawing.Point(0, 488);
            this.dgird_TaiKhoan.Name = "dgird_TaiKhoan";
            this.dgird_TaiKhoan.RowHeadersWidth = 51;
            this.dgird_TaiKhoan.RowTemplate.Height = 29;
            this.dgird_TaiKhoan.Size = new System.Drawing.Size(1274, 219);
            this.dgird_TaiKhoan.TabIndex = 0;
            this.dgird_TaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgird_TaiKhoan_CellContentClick);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(1121, 142);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(94, 29);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(1121, 265);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 29);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(1121, 201);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(94, 29);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mật khẩu";
            // 
            // tbx_MaNhanVien
            // 
            this.tbx_MaNhanVien.Location = new System.Drawing.Point(130, 179);
            this.tbx_MaNhanVien.Name = "tbx_MaNhanVien";
            this.tbx_MaNhanVien.Size = new System.Drawing.Size(275, 27);
            this.tbx_MaNhanVien.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã nhân viên";
            // 
            // tbx_TenNhanVien
            // 
            this.tbx_TenNhanVien.Location = new System.Drawing.Point(130, 118);
            this.tbx_TenNhanVien.Name = "tbx_TenNhanVien";
            this.tbx_TenNhanVien.Size = new System.Drawing.Size(275, 27);
            this.tbx_TenNhanVien.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Giới Tính";
            // 
            // tbx_DiaChi
            // 
            this.tbx_DiaChi.Location = new System.Drawing.Point(728, 118);
            this.tbx_DiaChi.Name = "tbx_DiaChi";
            this.tbx_DiaChi.Size = new System.Drawing.Size(233, 27);
            this.tbx_DiaChi.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(662, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(620, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(640, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Trạng thái";
            // 
            // rbtn_DangDiLam
            // 
            this.rbtn_DangDiLam.AutoSize = true;
            this.rbtn_DangDiLam.Location = new System.Drawing.Point(728, 319);
            this.rbtn_DangDiLam.Name = "rbtn_DangDiLam";
            this.rbtn_DangDiLam.Size = new System.Drawing.Size(112, 24);
            this.rbtn_DangDiLam.TabIndex = 20;
            this.rbtn_DangDiLam.TabStop = true;
            this.rbtn_DangDiLam.Text = "Đang đi làm";
            this.rbtn_DangDiLam.UseVisualStyleBackColor = true;
            // 
            // tbx_MK
            // 
            this.tbx_MK.Location = new System.Drawing.Point(130, 316);
            this.tbx_MK.Name = "tbx_MK";
            this.tbx_MK.Size = new System.Drawing.Size(275, 27);
            this.tbx_MK.TabIndex = 7;
            // 
            // tbx_Ten_TK
            // 
            this.tbx_Ten_TK.Location = new System.Drawing.Point(130, 255);
            this.tbx_Ten_TK.Name = "tbx_Ten_TK";
            this.tbx_Ten_TK.Size = new System.Drawing.Size(275, 27);
            this.tbx_Ten_TK.TabIndex = 5;
            // 
            // tbx_SoDienThoai
            // 
            this.tbx_SoDienThoai.Location = new System.Drawing.Point(728, 250);
            this.tbx_SoDienThoai.Name = "tbx_SoDienThoai";
            this.tbx_SoDienThoai.Size = new System.Drawing.Size(233, 27);
            this.tbx_SoDienThoai.TabIndex = 13;
            // 
            // rbtn_DaNghi
            // 
            this.rbtn_DaNghi.AutoSize = true;
            this.rbtn_DaNghi.Location = new System.Drawing.Point(879, 319);
            this.rbtn_DaNghi.Name = "rbtn_DaNghi";
            this.rbtn_DaNghi.Size = new System.Drawing.Size(82, 24);
            this.rbtn_DaNghi.TabIndex = 21;
            this.rbtn_DaNghi.TabStop = true;
            this.rbtn_DaNghi.Text = "Đã nghỉ";
            this.rbtn_DaNghi.UseVisualStyleBackColor = true;
            // 
            // cmb_GioiTinh
            // 
            this.cmb_GioiTinh.FormattingEnabled = true;
            this.cmb_GioiTinh.Location = new System.Drawing.Point(728, 184);
            this.cmb_GioiTinh.Name = "cmb_GioiTinh";
            this.cmb_GioiTinh.Size = new System.Drawing.Size(233, 28);
            this.cmb_GioiTinh.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(654, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Chức vụ";
            // 
            // cmb_ChucVu
            // 
            this.cmb_ChucVu.FormattingEnabled = true;
            this.cmb_ChucVu.Location = new System.Drawing.Point(728, 368);
            this.cmb_ChucVu.Name = "cmb_ChucVu";
            this.cmb_ChucVu.Size = new System.Drawing.Size(233, 28);
            this.cmb_ChucVu.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1121, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 26;
            this.button1.Text = "Re";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 707);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_ChucVu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb_GioiTinh);
            this.Controls.Add(this.rbtn_DaNghi);
            this.Controls.Add(this.rbtn_DangDiLam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_DiaChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_SoDienThoai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbx_MaNhanVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_TenNhanVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_MK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_Ten_TK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgird_TaiKhoan);
            this.Name = "FrmTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgird_TaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button1;
    }
}