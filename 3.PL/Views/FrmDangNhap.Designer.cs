namespace _3.PL.Views
{
    partial class FrmDangNhap
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
            this.txt_Tk = new System.Windows.Forms.TextBox();
            this.txt_Mk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            // 
            // txt_Tk
            // 
            this.txt_Tk.Location = new System.Drawing.Point(321, 141);
            this.txt_Tk.Name = "txt_Tk";
            this.txt_Tk.Size = new System.Drawing.Size(125, 27);
            this.txt_Tk.TabIndex = 1;
            this.txt_Tk.TextChanged += new System.EventHandler(this.txt_Tk_TextChanged);
            // 
            // txt_Mk
            // 
            this.txt_Mk.Location = new System.Drawing.Point(321, 193);
            this.txt_Mk.Name = "txt_Mk";
            this.txt_Mk.Size = new System.Drawing.Size(125, 27);
            this.txt_Mk.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật Khẩu ";
            // 
            // btn_dn
            // 
            this.btn_dn.Location = new System.Drawing.Point(335, 227);
            this.btn_dn.Name = "btn_dn";
            this.btn_dn.Size = new System.Drawing.Size(94, 29);
            this.btn_dn.TabIndex = 5;
            this.btn_dn.Text = "Đăng Nhập";
            this.btn_dn.UseVisualStyleBackColor = true;
            this.btn_dn.Click += new System.EventHandler(this.btn_dn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(800, 188);
            this.dataGridView1.TabIndex = 6;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_dn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Mk);
            this.Controls.Add(this.txt_Tk);
            this.Controls.Add(this.label1);
            this.Name = "FrmDangNhap";
            this.Text = "FrmDangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Tk;
        private System.Windows.Forms.TextBox txt_Mk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_dn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}