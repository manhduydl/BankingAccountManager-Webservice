namespace Giao_diện
{
    partial class Đỗi_mật_khẫu
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
            this.btQuayLai = new System.Windows.Forms.Button();
            this.lblmkcu = new System.Windows.Forms.Label();
            this.lblmkmoi = new System.Windows.Forms.Label();
            this.lblnhaplai = new System.Windows.Forms.Label();
            this.MKC = new System.Windows.Forms.TextBox();
            this.MKM = new System.Windows.Forms.TextBox();
            this.MKM2 = new System.Windows.Forms.TextBox();
            this.btndoimk = new System.Windows.Forms.Button();
            this.STK = new System.Windows.Forms.Label();
            this.lblTaikhoan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btQuayLai
            // 
            this.btQuayLai.BackColor = System.Drawing.Color.Khaki;
            this.btQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuayLai.Image = global::Giao_diện.Properties.Resources.undo_26;
            this.btQuayLai.Location = new System.Drawing.Point(544, 394);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Size = new System.Drawing.Size(123, 38);
            this.btQuayLai.TabIndex = 4;
            this.btQuayLai.Text = "Quay lại";
            this.btQuayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuayLai.UseVisualStyleBackColor = false;
            this.btQuayLai.Click += new System.EventHandler(this.btQuayLai_Click);
            // 
            // lblmkcu
            // 
            this.lblmkcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmkcu.ForeColor = System.Drawing.Color.White;
            this.lblmkcu.Location = new System.Drawing.Point(78, 115);
            this.lblmkcu.Name = "lblmkcu";
            this.lblmkcu.Size = new System.Drawing.Size(259, 31);
            this.lblmkcu.TabIndex = 5;
            this.lblmkcu.Text = "Mật khẫu cũ:";
            this.lblmkcu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblmkmoi
            // 
            this.lblmkmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmkmoi.ForeColor = System.Drawing.Color.White;
            this.lblmkmoi.Location = new System.Drawing.Point(84, 178);
            this.lblmkmoi.Name = "lblmkmoi";
            this.lblmkmoi.Size = new System.Drawing.Size(253, 31);
            this.lblmkmoi.TabIndex = 6;
            this.lblmkmoi.Text = "Mật khẫu mới:";
            this.lblmkmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblnhaplai
            // 
            this.lblnhaplai.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnhaplai.ForeColor = System.Drawing.Color.White;
            this.lblnhaplai.Location = new System.Drawing.Point(37, 242);
            this.lblnhaplai.Name = "lblnhaplai";
            this.lblnhaplai.Size = new System.Drawing.Size(300, 31);
            this.lblnhaplai.TabIndex = 7;
            this.lblnhaplai.Text = "Nhập lại mật khẩu:";
            this.lblnhaplai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MKC
            // 
            this.MKC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MKC.Location = new System.Drawing.Point(343, 112);
            this.MKC.Name = "MKC";
            this.MKC.PasswordChar = '*';
            this.MKC.Size = new System.Drawing.Size(252, 38);
            this.MKC.TabIndex = 8;
            // 
            // MKM
            // 
            this.MKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MKM.Location = new System.Drawing.Point(343, 178);
            this.MKM.Name = "MKM";
            this.MKM.PasswordChar = '*';
            this.MKM.Size = new System.Drawing.Size(252, 38);
            this.MKM.TabIndex = 9;
            // 
            // MKM2
            // 
            this.MKM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MKM2.Location = new System.Drawing.Point(343, 239);
            this.MKM2.Name = "MKM2";
            this.MKM2.PasswordChar = '*';
            this.MKM2.Size = new System.Drawing.Size(252, 38);
            this.MKM2.TabIndex = 10;
            // 
            // btndoimk
            // 
            this.btndoimk.BackColor = System.Drawing.Color.RoyalBlue;
            this.btndoimk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndoimk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoimk.Location = new System.Drawing.Point(221, 314);
            this.btndoimk.Name = "btndoimk";
            this.btndoimk.Size = new System.Drawing.Size(261, 57);
            this.btndoimk.TabIndex = 11;
            this.btndoimk.Text = "Đổi mật khẩu";
            this.btndoimk.UseVisualStyleBackColor = false;
            this.btndoimk.Click += new System.EventHandler(this.button1_Click);
            // 
            // STK
            // 
            this.STK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STK.ForeColor = System.Drawing.Color.White;
            this.STK.Location = new System.Drawing.Point(84, 55);
            this.STK.Name = "STK";
            this.STK.Size = new System.Drawing.Size(253, 31);
            this.STK.TabIndex = 12;
            this.STK.Text = "Tài khoản:";
            this.STK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaikhoan
            // 
            this.lblTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaikhoan.ForeColor = System.Drawing.Color.White;
            this.lblTaikhoan.Location = new System.Drawing.Point(342, 55);
            this.lblTaikhoan.Name = "lblTaikhoan";
            this.lblTaikhoan.Size = new System.Drawing.Size(253, 31);
            this.lblTaikhoan.TabIndex = 13;
            this.lblTaikhoan.Text = "Tài khoản:";
            this.lblTaikhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Đỗi_mật_khẫu
            // 
            this.AcceptButton = this.btndoimk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.lblTaikhoan);
            this.Controls.Add(this.STK);
            this.Controls.Add(this.btndoimk);
            this.Controls.Add(this.MKM2);
            this.Controls.Add(this.MKM);
            this.Controls.Add(this.MKC);
            this.Controls.Add(this.lblnhaplai);
            this.Controls.Add(this.lblmkmoi);
            this.Controls.Add(this.lblmkcu);
            this.Controls.Add(this.btQuayLai);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Đỗi_mật_khẫu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đỗi_mật_khẫu";
            this.Load += new System.EventHandler(this.Đỗi_mật_khẫu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuayLai;
        private System.Windows.Forms.Label lblmkcu;
        private System.Windows.Forms.Label lblmkmoi;
        private System.Windows.Forms.Label lblnhaplai;
        private System.Windows.Forms.TextBox MKC;
        private System.Windows.Forms.TextBox MKM;
        private System.Windows.Forms.TextBox MKM2;
        private System.Windows.Forms.Button btndoimk;
        private System.Windows.Forms.Label STK;
        private System.Windows.Forms.Label lblTaikhoan;

    }
}