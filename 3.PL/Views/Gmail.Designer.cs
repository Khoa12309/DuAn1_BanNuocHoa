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
            this.btn_Gui = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_NguoiGui = new System.Windows.Forms.TextBox();
            this.tbx_NguoiNhan = new System.Windows.Forms.TextBox();
            this.tbx_Pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_NoiDung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_td = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Gui
            // 
            this.btn_Gui.Location = new System.Drawing.Point(337, 387);
            this.btn_Gui.Name = "btn_Gui";
            this.btn_Gui.Size = new System.Drawing.Size(94, 29);
            this.btn_Gui.TabIndex = 0;
            this.btn_Gui.Text = "Gửi email";
            this.btn_Gui.UseVisualStyleBackColor = true;
            this.btn_Gui.Click += new System.EventHandler(this.btn_Gui_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email người gửi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email người nhận:";
            // 
            // tbx_NguoiGui
            // 
            this.tbx_NguoiGui.Location = new System.Drawing.Point(213, 45);
            this.tbx_NguoiGui.Name = "tbx_NguoiGui";
            this.tbx_NguoiGui.Size = new System.Drawing.Size(239, 27);
            this.tbx_NguoiGui.TabIndex = 3;
            // 
            // tbx_NguoiNhan
            // 
            this.tbx_NguoiNhan.Location = new System.Drawing.Point(213, 182);
            this.tbx_NguoiNhan.Name = "tbx_NguoiNhan";
            this.tbx_NguoiNhan.Size = new System.Drawing.Size(239, 27);
            this.tbx_NguoiNhan.TabIndex = 4;
            // 
            // tbx_Pass
            // 
            this.tbx_Pass.Location = new System.Drawing.Point(213, 104);
            this.tbx_Pass.Name = "tbx_Pass";
            this.tbx_Pass.PasswordChar = '*';
            this.tbx_Pass.Size = new System.Drawing.Size(239, 27);
            this.tbx_Pass.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu:";
            // 
            // tbx_NoiDung
            // 
            this.tbx_NoiDung.Location = new System.Drawing.Point(598, 104);
            this.tbx_NoiDung.Multiline = true;
            this.tbx_NoiDung.Name = "tbx_NoiDung";
            this.tbx_NoiDung.Size = new System.Drawing.Size(310, 298);
            this.tbx_NoiDung.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nội dung:";
            // 
            // txt_td
            // 
            this.txt_td.Location = new System.Drawing.Point(657, 38);
            this.txt_td.Name = "txt_td";
            this.txt_td.Size = new System.Drawing.Size(239, 27);
            this.txt_td.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tiêu đề";
            // 
            // Gmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 484);
            this.Controls.Add(this.txt_td);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_NoiDung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_Pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_NguoiNhan);
            this.Controls.Add(this.tbx_NguoiGui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Gui);
            this.Name = "Gmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Gui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_NguoiGui;
        private System.Windows.Forms.TextBox tbx_NguoiNhan;
        private System.Windows.Forms.TextBox tbx_Pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_NoiDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_td;
        private System.Windows.Forms.Label label5;
    }
}