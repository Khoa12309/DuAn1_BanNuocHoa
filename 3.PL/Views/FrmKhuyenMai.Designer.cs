namespace _3.PL.Views
{
    partial class FrmKhuyenMai
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_Ma = new System.Windows.Forms.TextBox();
            this.tbx_GiaTriKM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgird_KhuyenMai = new System.Windows.Forms.DataGridView();
            this.dtp_BatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.NgayBatDau = new System.Windows.Forms.Label();
            this.NgayKetThuc = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgird_KhuyenMai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma Khuyen Mai";
            // 
            // tbx_Ma
            // 
            this.tbx_Ma.Location = new System.Drawing.Point(225, 23);
            this.tbx_Ma.Name = "tbx_Ma";
            this.tbx_Ma.Size = new System.Drawing.Size(125, 27);
            this.tbx_Ma.TabIndex = 1;
            // 
            // tbx_GiaTriKM
            // 
            this.tbx_GiaTriKM.Location = new System.Drawing.Point(225, 90);
            this.tbx_GiaTriKM.Name = "tbx_GiaTriKM";
            this.tbx_GiaTriKM.Size = new System.Drawing.Size(125, 27);
            this.tbx_GiaTriKM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gia tri khuyen mai";
            // 
            // dgird_KhuyenMai
            // 
            this.dgird_KhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgird_KhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgird_KhuyenMai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgird_KhuyenMai.Location = new System.Drawing.Point(0, 283);
            this.dgird_KhuyenMai.Name = "dgird_KhuyenMai";
            this.dgird_KhuyenMai.RowHeadersWidth = 51;
            this.dgird_KhuyenMai.RowTemplate.Height = 29;
            this.dgird_KhuyenMai.Size = new System.Drawing.Size(1058, 237);
            this.dgird_KhuyenMai.TabIndex = 4;
            this.dgird_KhuyenMai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgird_KhuyenMai_CellContentClick);
            // 
            // dtp_BatDau
            // 
            this.dtp_BatDau.Location = new System.Drawing.Point(225, 159);
            this.dtp_BatDau.Name = "dtp_BatDau";
            this.dtp_BatDau.Size = new System.Drawing.Size(125, 27);
            this.dtp_BatDau.TabIndex = 5;
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Location = new System.Drawing.Point(225, 222);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(125, 27);
            this.dtpKetThuc.TabIndex = 6;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.AutoSize = true;
            this.NgayBatDau.Location = new System.Drawing.Point(116, 166);
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.Size = new System.Drawing.Size(103, 20);
            this.NgayBatDau.TabIndex = 7;
            this.NgayBatDau.Text = "Ngay bat dau ";
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.AutoSize = true;
            this.NgayKetThuc.Location = new System.Drawing.Point(119, 227);
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.Size = new System.Drawing.Size(100, 20);
            this.NgayKetThuc.TabIndex = 8;
            this.NgayKetThuc.Text = "Ngay ket thuc";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(823, 54);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(94, 29);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(823, 218);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(94, 29);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(823, 122);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 29);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // FrmKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 520);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.NgayKetThuc);
            this.Controls.Add(this.NgayBatDau);
            this.Controls.Add(this.dtpKetThuc);
            this.Controls.Add(this.dtp_BatDau);
            this.Controls.Add(this.dgird_KhuyenMai);
            this.Controls.Add(this.tbx_GiaTriKM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_Ma);
            this.Controls.Add(this.label1);
            this.Name = "FrmKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKhuyenMai";
            ((System.ComponentModel.ISupportInitialize)(this.dgird_KhuyenMai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_Ma;
        private System.Windows.Forms.TextBox tbx_GiaTriKM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgird_KhuyenMai;
        private System.Windows.Forms.DateTimePicker dtp_BatDau;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.Label NgayBatDau;
        private System.Windows.Forms.Label NgayKetThuc;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
    }
}