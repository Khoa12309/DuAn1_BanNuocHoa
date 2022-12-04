namespace _3.PL.Views
{
    partial class FrmHangSp
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_Tensp = new System.Windows.Forms.TextBox();
            this.tbx_MaSp = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten sp";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(1036, 35);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 29);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Them";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(197, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(833, 188);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ma sp";
            // 
            // tbx_Tensp
            // 
            this.tbx_Tensp.Location = new System.Drawing.Point(183, 37);
            this.tbx_Tensp.Name = "tbx_Tensp";
            this.tbx_Tensp.Size = new System.Drawing.Size(184, 27);
            this.tbx_Tensp.TabIndex = 4;
            // 
            // tbx_MaSp
            // 
            this.tbx_MaSp.Location = new System.Drawing.Point(183, 93);
            this.tbx_MaSp.Name = "tbx_MaSp";
            this.tbx_MaSp.Size = new System.Drawing.Size(184, 27);
            this.tbx_MaSp.TabIndex = 7;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(1036, 137);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 29);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xoa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(1036, 84);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 29);
            this.btn_Sua.TabIndex = 9;
            this.btn_Sua.Text = "Sua";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // FrmHangSp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 493);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.tbx_MaSp);
            this.Controls.Add(this.tbx_Tensp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label1);
            this.Name = "FrmHangSp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHangSp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_Tensp;
        private System.Windows.Forms.TextBox tbx_MaSp;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
    }
}