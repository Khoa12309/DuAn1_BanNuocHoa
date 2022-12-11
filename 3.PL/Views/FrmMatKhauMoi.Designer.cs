namespace _3.PL.Views
{
    partial class FrmMatKhauMoi
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
            this.txt_matkhaumoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Closer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_matkhaumoi
            // 
            this.txt_matkhaumoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_matkhaumoi.Location = new System.Drawing.Point(200, 134);
            this.txt_matkhaumoi.Name = "txt_matkhaumoi";
            this.txt_matkhaumoi.Size = new System.Drawing.Size(208, 26);
            this.txt_matkhaumoi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu mới";
            // 
            // lbl_Closer
            // 
            this.lbl_Closer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Closer.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Closer.ForeColor = System.Drawing.Color.Red;
            this.lbl_Closer.Location = new System.Drawing.Point(550, 9);
            this.lbl_Closer.Name = "lbl_Closer";
            this.lbl_Closer.Size = new System.Drawing.Size(21, 23);
            this.lbl_Closer.TabIndex = 3;
            this.lbl_Closer.Text = "X";
            this.lbl_Closer.Click += new System.EventHandler(this.lbl_Closer_Click);
            // 
            // FrmMatKhauMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(573, 320);
            this.Controls.Add(this.lbl_Closer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_matkhaumoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMatKhauMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMatKhauMoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_matkhaumoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Closer;
    }
}