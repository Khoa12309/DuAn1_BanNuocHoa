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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhuyenMai));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgird_KhuyenMai)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma Khuyen Mai";
            // 
            // tbx_Ma
            // 
            this.tbx_Ma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_Ma.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_Ma.Location = new System.Drawing.Point(178, 12);
            this.tbx_Ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_Ma.Name = "tbx_Ma";
            this.tbx_Ma.Size = new System.Drawing.Size(218, 29);
            this.tbx_Ma.TabIndex = 1;
            // 
            // tbx_GiaTriKM
            // 
            this.tbx_GiaTriKM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_GiaTriKM.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_GiaTriKM.Location = new System.Drawing.Point(178, 90);
            this.tbx_GiaTriKM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_GiaTriKM.Name = "tbx_GiaTriKM";
            this.tbx_GiaTriKM.Size = new System.Drawing.Size(218, 29);
            this.tbx_GiaTriKM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gia tri khuyen mai";
            // 
            // dgird_KhuyenMai
            // 
            this.dgird_KhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgird_KhuyenMai.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgird_KhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgird_KhuyenMai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgird_KhuyenMai.Location = new System.Drawing.Point(0, 379);
            this.dgird_KhuyenMai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgird_KhuyenMai.Name = "dgird_KhuyenMai";
            this.dgird_KhuyenMai.RowHeadersWidth = 51;
            this.dgird_KhuyenMai.RowTemplate.Height = 29;
            this.dgird_KhuyenMai.Size = new System.Drawing.Size(832, 179);
            this.dgird_KhuyenMai.TabIndex = 4;
            this.dgird_KhuyenMai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgird_KhuyenMai_CellContentClick);
            // 
            // dtp_BatDau
            // 
            this.dtp_BatDau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_BatDau.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_BatDau.Location = new System.Drawing.Point(178, 163);
            this.dtp_BatDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_BatDau.Name = "dtp_BatDau";
            this.dtp_BatDau.Size = new System.Drawing.Size(218, 29);
            this.dtp_BatDau.TabIndex = 5;
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpKetThuc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpKetThuc.Location = new System.Drawing.Point(178, 239);
            this.dtpKetThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(218, 29);
            this.dtpKetThuc.TabIndex = 6;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NgayBatDau.AutoSize = true;
            this.NgayBatDau.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NgayBatDau.Location = new System.Drawing.Point(6, 170);
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.Size = new System.Drawing.Size(125, 22);
            this.NgayBatDau.TabIndex = 7;
            this.NgayBatDau.Text = "Ngay bat dau ";
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NgayKetThuc.AutoSize = true;
            this.NgayKetThuc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NgayKetThuc.Location = new System.Drawing.Point(6, 244);
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.Size = new System.Drawing.Size(123, 22);
            this.NgayKetThuc.TabIndex = 8;
            this.NgayKetThuc.Text = "Ngay ket thuc";
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Add.Location = new System.Drawing.Point(81, 39);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(121, 41);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Update.Location = new System.Drawing.Point(81, 239);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(121, 44);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Delete.Location = new System.Drawing.Point(81, 132);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(121, 40);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 55);
            this.panel1.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(0, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Tìm Kiếm...";
            this.textBox1.Size = new System.Drawing.Size(197, 28);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbx_Ma);
            this.groupBox1.Controls.Add(this.NgayKetThuc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NgayBatDau);
            this.groupBox1.Controls.Add(this.tbx_GiaTriKM);
            this.groupBox1.Controls.Add(this.dtp_BatDau);
            this.groupBox1.Controls.Add(this.dtpKetThuc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 324);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Controls.Add(this.btn_Update);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(566, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 324);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(420, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 324);
            this.panel2.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 129);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(832, 558);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgird_KhuyenMai);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKhuyenMai";
            ((System.ComponentModel.ISupportInitialize)(this.dgird_KhuyenMai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}