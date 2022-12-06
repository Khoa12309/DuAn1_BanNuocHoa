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
            this.tbx_Ten_TK = new System.Windows.Forms.TextBox();
            this.tbx_MK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgird_TaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgird_TaiKhoan
            // 
            this.dgird_TaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgird_TaiKhoan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgird_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgird_TaiKhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgird_TaiKhoan.Location = new System.Drawing.Point(0, 231);
            this.dgird_TaiKhoan.Name = "dgird_TaiKhoan";
            this.dgird_TaiKhoan.RowHeadersWidth = 51;
            this.dgird_TaiKhoan.RowTemplate.Height = 29;
            this.dgird_TaiKhoan.Size = new System.Drawing.Size(884, 219);
            this.dgird_TaiKhoan.TabIndex = 0;
            this.dgird_TaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgird_TaiKhoan_CellContentClick);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(575, 37);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(94, 29);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(575, 160);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 29);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(575, 96);
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
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ten tai khoan";
            // 
            // tbx_Ten_TK
            // 
            this.tbx_Ten_TK.Location = new System.Drawing.Point(142, 37);
            this.tbx_Ten_TK.Name = "tbx_Ten_TK";
            this.tbx_Ten_TK.Size = new System.Drawing.Size(125, 27);
            this.tbx_Ten_TK.TabIndex = 5;
            // 
            // tbx_MK
            // 
            this.tbx_MK.Location = new System.Drawing.Point(142, 98);
            this.tbx_MK.Name = "tbx_MK";
            this.tbx_MK.Size = new System.Drawing.Size(125, 27);
            this.tbx_MK.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mat khau";
            // 
            // FrmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
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
            this.Text = "FrmTaiKhoan";
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
        private System.Windows.Forms.TextBox tbx_Ten_TK;
        private System.Windows.Forms.TextBox tbx_MK;
        private System.Windows.Forms.Label label2;
    }
}