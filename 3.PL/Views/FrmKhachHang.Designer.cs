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
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_SoDienThoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_DiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_TenKhachHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtn_Nu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgird_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_MaKhachHang
            // 
            this.tbx_MaKhachHang.Location = new System.Drawing.Point(169, 22);
            this.tbx_MaKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_MaKhachHang.Name = "tbx_MaKhachHang";
            this.tbx_MaKhachHang.Size = new System.Drawing.Size(110, 23);
            this.tbx_MaKhachHang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ma khach hang";
            // 
            // dgird_KhachHang
            // 
            this.dgird_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgird_KhachHang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgird_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgird_KhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgird_KhachHang.Location = new System.Drawing.Point(0, 240);
            this.dgird_KhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgird_KhachHang.Name = "dgird_KhachHang";
            this.dgird_KhachHang.RowHeadersWidth = 51;
            this.dgird_KhachHang.RowTemplate.Height = 29;
            this.dgird_KhachHang.Size = new System.Drawing.Size(974, 165);
            this.dgird_KhachHang.TabIndex = 2;
            this.dgird_KhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgird_KhachHang_CellContentClick);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(828, 59);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(82, 22);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Datete
            // 
            this.btn_Datete.Location = new System.Drawing.Point(828, 159);
            this.btn_Datete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Datete.Name = "btn_Datete";
            this.btn_Datete.Size = new System.Drawing.Size(82, 22);
            this.btn_Datete.TabIndex = 4;
            this.btn_Datete.Text = "Delete";
            this.btn_Datete.UseVisualStyleBackColor = true;
            this.btn_Datete.Click += new System.EventHandler(this.btn_Datete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(828, 107);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(82, 22);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // rbtn_Nam
            // 
            this.rbtn_Nam.AutoSize = true;
            this.rbtn_Nam.Location = new System.Drawing.Point(480, 22);
            this.rbtn_Nam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_Nam.Name = "rbtn_Nam";
            this.rbtn_Nam.Size = new System.Drawing.Size(51, 19);
            this.rbtn_Nam.TabIndex = 6;
            this.rbtn_Nam.TabStop = true;
            this.rbtn_Nam.Text = "Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "So dien thoai";
            // 
            // tbx_SoDienThoai
            // 
            this.tbx_SoDienThoai.Location = new System.Drawing.Point(171, 180);
            this.tbx_SoDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_SoDienThoai.Name = "tbx_SoDienThoai";
            this.tbx_SoDienThoai.Size = new System.Drawing.Size(110, 23);
            this.tbx_SoDienThoai.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dia chi";
            // 
            // tbx_DiaChi
            // 
            this.tbx_DiaChi.Location = new System.Drawing.Point(171, 122);
            this.tbx_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_DiaChi.Name = "tbx_DiaChi";
            this.tbx_DiaChi.Size = new System.Drawing.Size(110, 23);
            this.tbx_DiaChi.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ten khach hang";
            // 
            // tbx_TenKhachHang
            // 
            this.tbx_TenKhachHang.Location = new System.Drawing.Point(171, 72);
            this.tbx_TenKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_TenKhachHang.Name = "tbx_TenKhachHang";
            this.tbx_TenKhachHang.Size = new System.Drawing.Size(110, 23);
            this.tbx_TenKhachHang.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gioi tinh";
            // 
            // rbtn_Nu
            // 
            this.rbtn_Nu.AutoSize = true;
            this.rbtn_Nu.Location = new System.Drawing.Point(480, 59);
            this.rbtn_Nu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_Nu.Name = "rbtn_Nu";
            this.rbtn_Nu.Size = new System.Drawing.Size(41, 19);
            this.rbtn_Nu.TabIndex = 14;
            this.rbtn_Nu.TabStop = true;
            this.rbtn_Nu.Text = "Nu";
            this.rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 405);
            this.Controls.Add(this.rbtn_Nu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_TenKhachHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_DiaChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_SoDienThoai);
            this.Controls.Add(this.rbtn_Nam);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Datete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgird_KhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_MaKhachHang);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_SoDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_DiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_TenKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtn_Nu;
    }
}