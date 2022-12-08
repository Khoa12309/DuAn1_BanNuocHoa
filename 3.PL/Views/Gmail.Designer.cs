namespace _3.PL.Views
{
    partial class Gmail
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
            this.tbx_NguoiGui = new System.Windows.Forms.TextBox();
            this.btn_Gui = new System.Windows.Forms.Button();
            this.tbx_NguoiNhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_matKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_NoiDung = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên người gửi";
            // 
            // tbx_NguoiGui
            // 
            this.tbx_NguoiGui.Location = new System.Drawing.Point(159, 76);
            this.tbx_NguoiGui.Name = "tbx_NguoiGui";
            this.tbx_NguoiGui.Size = new System.Drawing.Size(125, 27);
            this.tbx_NguoiGui.TabIndex = 1;
            this.tbx_NguoiGui.Text = "dungndph20833@fpt.edu.vn";
            // 
            // btn_Gui
            // 
            this.btn_Gui.Location = new System.Drawing.Point(148, 338);
            this.btn_Gui.Name = "btn_Gui";
            this.btn_Gui.Size = new System.Drawing.Size(94, 29);
            this.btn_Gui.TabIndex = 2;
            this.btn_Gui.Text = "Gửi";
            this.btn_Gui.UseVisualStyleBackColor = true;
            this.btn_Gui.Click += new System.EventHandler(this.btn_Gui_Click);
            // 
            // tbx_NguoiNhan
            // 
            this.tbx_NguoiNhan.Location = new System.Drawing.Point(159, 195);
            this.tbx_NguoiNhan.Name = "tbx_NguoiNhan";
            this.tbx_NguoiNhan.Size = new System.Drawing.Size(125, 27);
            this.tbx_NguoiNhan.TabIndex = 4;
            this.tbx_NguoiNhan.Text = "khoavxph20877@fpt.edu.vn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "tên người nhận";
            // 
            // tbx_matKhau
            // 
            this.tbx_matKhau.Location = new System.Drawing.Point(159, 133);
            this.tbx_matKhau.Name = "tbx_matKhau";
            this.tbx_matKhau.PasswordChar = '*';
            this.tbx_matKhau.Size = new System.Drawing.Size(125, 27);
            this.tbx_matKhau.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "mật khẩu";
            // 
            // tbx_NoiDung
            // 
            this.tbx_NoiDung.Location = new System.Drawing.Point(557, 79);
            this.tbx_NoiDung.Multiline = true;
            this.tbx_NoiDung.Name = "tbx_NoiDung";
            this.tbx_NoiDung.Size = new System.Drawing.Size(239, 299);
            this.tbx_NoiDung.TabIndex = 8;
            this.tbx_NoiDung.Text = "Hello";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(442, 79);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(71, 20);
            this.c.TabIndex = 7;
            this.c.Text = "Nội dung";
            // 
            // Gmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_NoiDung);
            this.Controls.Add(this.c);
            this.Controls.Add(this.tbx_matKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_NguoiNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Gui);
            this.Controls.Add(this.tbx_NguoiGui);
            this.Controls.Add(this.label1);
            this.Name = "Gmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_NguoiGui;
        private System.Windows.Forms.Button btn_Gui;
        private System.Windows.Forms.TextBox tbx_NguoiNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_matKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_NoiDung;
        private System.Windows.Forms.Label c;
    }
}