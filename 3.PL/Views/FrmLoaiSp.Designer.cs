namespace _3.PL.Views
{
    partial class FrmLoaiSp
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
            this.dgird_LoaiSp = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgird_LoaiSp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgird_LoaiSp
            // 
            this.dgird_LoaiSp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgird_LoaiSp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgird_LoaiSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgird_LoaiSp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgird_LoaiSp.Location = new System.Drawing.Point(0, 239);
            this.dgird_LoaiSp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgird_LoaiSp.Name = "dgird_LoaiSp";
            this.dgird_LoaiSp.RowHeadersWidth = 51;
            this.dgird_LoaiSp.RowTemplate.Height = 29;
            this.dgird_LoaiSp.Size = new System.Drawing.Size(835, 204);
            this.dgird_LoaiSp.TabIndex = 2;
            this.dgird_LoaiSp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgird_LoaiSp_CellContentClick);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Them.Location = new System.Drawing.Point(508, 55);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(99, 35);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Delete.Location = new System.Drawing.Point(508, 199);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(99, 36);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Update.Location = new System.Drawing.Point(508, 126);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(99, 35);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_ma
            // 
            this.txt_ma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_ma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ma.Location = new System.Drawing.Point(164, 136);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.PlaceholderText = "Mã loại sản phẩm";
            this.txt_ma.Size = new System.Drawing.Size(192, 16);
            this.txt_ma.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(809, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(164, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 3);
            this.label2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(164, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 3);
            this.label4.TabIndex = 0;
            // 
            // txt_ten
            // 
            this.txt_ten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_ten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ten.Location = new System.Drawing.Point(164, 62);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.PlaceholderText = "Tên loại sản phẩm";
            this.txt_ten.Size = new System.Drawing.Size(192, 16);
            this.txt_ten.TabIndex = 1;
            this.txt_ten.TextChanged += new System.EventHandler(this.txt_ten_TextChanged);
            // 
            // FrmLoaiSp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(835, 443);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgird_LoaiSp);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLoaiSp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoaiSp";
            this.Load += new System.EventHandler(this.FrmLoaiSp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgird_LoaiSp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgird_LoaiSp;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.TextBox txt_ten;
    }
}