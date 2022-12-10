namespace _3.PL.Views
{
    partial class FrmKhachHang
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
            this.tbx_MaKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgird_KhachHang = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Datete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.rbtn_Nam = new System.Windows.Forms.RadioButton();
            this.tbx_SoDienThoai = new System.Windows.Forms.TextBox();
            this.tbx_DiaChi = new System.Windows.Forms.TextBox();
            this.tbx_TenKhachHang = new System.Windows.Forms.TextBox();
            this.rbtn_Nu = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgird_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_MaKhachHang
            // 
            this.tbx_MaKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbx_MaKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_MaKhachHang.Location = new System.Drawing.Point(171, 24);
            this.tbx_MaKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_MaKhachHang.Name = "tbx_MaKhachHang";
            this.tbx_MaKhachHang.PlaceholderText = "Mã khách hàng";
            this.tbx_MaKhachHang.Size = new System.Drawing.Size(199, 16);
            this.tbx_MaKhachHang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 2);
            this.label1.TabIndex = 1;
            // 
            // dgird_KhachHang
            // 
            this.dgird_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgird_KhachHang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgird_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgird_KhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgird_KhachHang.Location = new System.Drawing.Point(0, 273);
            this.dgird_KhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgird_KhachHang.Name = "dgird_KhachHang";
            this.dgird_KhachHang.RowHeadersWidth = 51;
            this.dgird_KhachHang.RowTemplate.Height = 29;
            this.dgird_KhachHang.Size = new System.Drawing.Size(899, 165);
            this.dgird_KhachHang.TabIndex = 2;
            this.dgird_KhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgird_KhachHang_CellContentClick);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Add.Location = new System.Drawing.Point(495, 33);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(106, 34);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Datete
            // 
            this.btn_Datete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Datete.Location = new System.Drawing.Point(495, 170);
            this.btn_Datete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Datete.Name = "btn_Datete";
            this.btn_Datete.Size = new System.Drawing.Size(106, 34);
            this.btn_Datete.TabIndex = 4;
            this.btn_Datete.Text = "Xóa";
            this.btn_Datete.UseVisualStyleBackColor = false;
            this.btn_Datete.Click += new System.EventHandler(this.btn_Datete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Update.Location = new System.Drawing.Point(495, 104);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(106, 34);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // rbtn_Nam
            // 
            this.rbtn_Nam.AutoSize = true;
            this.rbtn_Nam.ForeColor = System.Drawing.Color.Gray;
            this.rbtn_Nam.Location = new System.Drawing.Point(260, 236);
            this.rbtn_Nam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_Nam.Name = "rbtn_Nam";
            this.rbtn_Nam.Size = new System.Drawing.Size(51, 19);
            this.rbtn_Nam.TabIndex = 6;
            this.rbtn_Nam.TabStop = true;
            this.rbtn_Nam.Text = "Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // tbx_SoDienThoai
            // 
            this.tbx_SoDienThoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbx_SoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_SoDienThoai.Location = new System.Drawing.Point(171, 180);
            this.tbx_SoDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_SoDienThoai.Name = "tbx_SoDienThoai";
            this.tbx_SoDienThoai.PlaceholderText = "Số điện thoại";
            this.tbx_SoDienThoai.Size = new System.Drawing.Size(199, 16);
            this.tbx_SoDienThoai.TabIndex = 7;
            // 
            // tbx_DiaChi
            // 
            this.tbx_DiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbx_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_DiaChi.Location = new System.Drawing.Point(171, 122);
            this.tbx_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_DiaChi.Name = "tbx_DiaChi";
            this.tbx_DiaChi.PlaceholderText = "Địa chỉ";
            this.tbx_DiaChi.Size = new System.Drawing.Size(199, 16);
            this.tbx_DiaChi.TabIndex = 9;
            // 
            // tbx_TenKhachHang
            // 
            this.tbx_TenKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbx_TenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_TenKhachHang.Location = new System.Drawing.Point(171, 72);
            this.tbx_TenKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_TenKhachHang.Name = "tbx_TenKhachHang";
            this.tbx_TenKhachHang.PlaceholderText = "Tên khách hàng";
            this.tbx_TenKhachHang.Size = new System.Drawing.Size(199, 16);
            this.tbx_TenKhachHang.TabIndex = 11;
            // 
            // rbtn_Nu
            // 
            this.rbtn_Nu.AutoSize = true;
            this.rbtn_Nu.ForeColor = System.Drawing.Color.Gray;
            this.rbtn_Nu.Location = new System.Drawing.Point(329, 236);
            this.rbtn_Nu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_Nu.Name = "rbtn_Nu";
            this.rbtn_Nu.Size = new System.Drawing.Size(41, 19);
            this.rbtn_Nu.TabIndex = 14;
            this.rbtn_Nu.TabStop = true;
            this.rbtn_Nu.Text = "Nu";
            this.rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(171, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 2);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(171, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 2);
            this.label3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(171, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 2);
            this.label4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(171, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(871, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(899, 438);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbtn_Nu);
            this.Controls.Add(this.tbx_TenKhachHang);
            this.Controls.Add(this.tbx_DiaChi);
            this.Controls.Add(this.tbx_SoDienThoai);
            this.Controls.Add(this.rbtn_Nam);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Datete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgird_KhachHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_MaKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgird_KhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_MaKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgird_KhachHang;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Datete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.RadioButton rbtn_Nam;
        private System.Windows.Forms.TextBox tbx_SoDienThoai;
        private System.Windows.Forms.TextBox tbx_DiaChi;
        private System.Windows.Forms.TextBox tbx_TenKhachHang;
        private System.Windows.Forms.RadioButton rbtn_Nu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}