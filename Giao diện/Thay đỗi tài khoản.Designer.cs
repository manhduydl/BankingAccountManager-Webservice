namespace Giao_diện
{
    partial class Thay_đỗi_tài_khoản
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
            this.btQuay_lai = new System.Windows.Forms.Button();
            this.dsTai_khoan = new System.Windows.Forms.DataGridView();
            this.So_tai_khoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_khach_hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tinh_trang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai_tai_khoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnphuchoi = new System.Windows.Forms.Button();
            this.btnkhoa = new System.Windows.Forms.Button();
            this.lbltrangthai = new System.Windows.Forms.Label();
            this.btnlenvip = new System.Windows.Forms.Button();
            this.btnvethuong = new System.Windows.Forms.Button();
            this.lbltinhtrang = new System.Windows.Forms.Label();
            this.lblloaitk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsTai_khoan)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuay_lai
            // 
            this.btQuay_lai.BackColor = System.Drawing.Color.Khaki;
            this.btQuay_lai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuay_lai.Image = global::Giao_diện.Properties.Resources.undo_26;
            this.btQuay_lai.Location = new System.Drawing.Point(614, 400);
            this.btQuay_lai.Name = "btQuay_lai";
            this.btQuay_lai.Size = new System.Drawing.Size(122, 38);
            this.btQuay_lai.TabIndex = 12;
            this.btQuay_lai.Text = "Quay lại";
            this.btQuay_lai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuay_lai.UseVisualStyleBackColor = false;
            this.btQuay_lai.Click += new System.EventHandler(this.btQuay_lai_Click);
            // 
            // dsTai_khoan
            // 
            this.dsTai_khoan.AllowUserToAddRows = false;
            this.dsTai_khoan.AllowUserToDeleteRows = false;
            this.dsTai_khoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsTai_khoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.So_tai_khoan,
            this.So_tien,
            this.Ma_khach_hang,
            this.Tinh_trang,
            this.Loai_tai_khoan});
            this.dsTai_khoan.Location = new System.Drawing.Point(12, 95);
            this.dsTai_khoan.Name = "dsTai_khoan";
            this.dsTai_khoan.ReadOnly = true;
            this.dsTai_khoan.RowHeadersVisible = false;
            this.dsTai_khoan.Size = new System.Drawing.Size(724, 256);
            this.dsTai_khoan.TabIndex = 13;
            this.dsTai_khoan.SelectionChanged += new System.EventHandler(this.dsTai_khoan_SelectionChanged);
            // 
            // So_tai_khoan
            // 
            this.So_tai_khoan.DataPropertyName = "So_tai_khoan";
            this.So_tai_khoan.HeaderText = "Số tài khoản";
            this.So_tai_khoan.Name = "So_tai_khoan";
            this.So_tai_khoan.ReadOnly = true;
            this.So_tai_khoan.Width = 150;
            // 
            // So_tien
            // 
            this.So_tien.DataPropertyName = "So_tien";
            this.So_tien.HeaderText = "Số tiền";
            this.So_tien.Name = "So_tien";
            this.So_tien.ReadOnly = true;
            // 
            // Ma_khach_hang
            // 
            this.Ma_khach_hang.DataPropertyName = "Ma_khach_hang";
            this.Ma_khach_hang.HeaderText = "Mã khách hàng";
            this.Ma_khach_hang.Name = "Ma_khach_hang";
            this.Ma_khach_hang.ReadOnly = true;
            this.Ma_khach_hang.Width = 180;
            // 
            // Tinh_trang
            // 
            this.Tinh_trang.DataPropertyName = "Tinh_trang";
            this.Tinh_trang.HeaderText = "Tình trạng";
            this.Tinh_trang.Name = "Tinh_trang";
            this.Tinh_trang.ReadOnly = true;
            this.Tinh_trang.Width = 130;
            // 
            // Loai_tai_khoan
            // 
            this.Loai_tai_khoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Loai_tai_khoan.DataPropertyName = "Loai_tai_khoan";
            this.Loai_tai_khoan.HeaderText = "Loại tài khoản";
            this.Loai_tai_khoan.Name = "Loai_tai_khoan";
            this.Loai_tai_khoan.ReadOnly = true;
            // 
            // btnphuchoi
            // 
            this.btnphuchoi.BackColor = System.Drawing.Color.OliveDrab;
            this.btnphuchoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnphuchoi.Location = new System.Drawing.Point(12, 400);
            this.btnphuchoi.Name = "btnphuchoi";
            this.btnphuchoi.Size = new System.Drawing.Size(122, 38);
            this.btnphuchoi.TabIndex = 14;
            this.btnphuchoi.Text = "Phục hồi";
            this.btnphuchoi.UseVisualStyleBackColor = false;
            this.btnphuchoi.Click += new System.EventHandler(this.btPhuchoi_Click);
            // 
            // btnkhoa
            // 
            this.btnkhoa.BackColor = System.Drawing.Color.OliveDrab;
            this.btnkhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkhoa.Location = new System.Drawing.Point(140, 400);
            this.btnkhoa.Name = "btnkhoa";
            this.btnkhoa.Size = new System.Drawing.Size(121, 38);
            this.btnkhoa.TabIndex = 15;
            this.btnkhoa.Text = "Khóa";
            this.btnkhoa.UseVisualStyleBackColor = false;
            this.btnkhoa.Click += new System.EventHandler(this.btKhoa_Click);
            // 
            // lbltrangthai
            // 
            this.lbltrangthai.AutoSize = true;
            this.lbltrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrangthai.Location = new System.Drawing.Point(12, 28);
            this.lbltrangthai.Name = "lbltrangthai";
            this.lbltrangthai.Size = new System.Drawing.Size(312, 29);
            this.lbltrangthai.TabIndex = 16;
            this.lbltrangthai.Text = "Thay đỗi trạng thái tài khoản";
            // 
            // btnlenvip
            // 
            this.btnlenvip.BackColor = System.Drawing.Color.OliveDrab;
            this.btnlenvip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlenvip.Location = new System.Drawing.Point(300, 400);
            this.btnlenvip.Name = "btnlenvip";
            this.btnlenvip.Size = new System.Drawing.Size(121, 38);
            this.btnlenvip.TabIndex = 17;
            this.btnlenvip.Text = "Lên vip";
            this.btnlenvip.UseVisualStyleBackColor = false;
            this.btnlenvip.Click += new System.EventHandler(this.btVip_Click);
            // 
            // btnvethuong
            // 
            this.btnvethuong.BackColor = System.Drawing.Color.OliveDrab;
            this.btnvethuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvethuong.Location = new System.Drawing.Point(427, 400);
            this.btnvethuong.Name = "btnvethuong";
            this.btnvethuong.Size = new System.Drawing.Size(121, 38);
            this.btnvethuong.TabIndex = 18;
            this.btnvethuong.Text = "Về thường";
            this.btnvethuong.UseVisualStyleBackColor = false;
            this.btnvethuong.Click += new System.EventHandler(this.btThuong_Click);
            // 
            // lbltinhtrang
            // 
            this.lbltinhtrang.AutoSize = true;
            this.lbltinhtrang.Location = new System.Drawing.Point(90, 363);
            this.lbltinhtrang.Name = "lbltinhtrang";
            this.lbltinhtrang.Size = new System.Drawing.Size(95, 24);
            this.lbltinhtrang.TabIndex = 19;
            this.lbltinhtrang.Text = "Tình trạng";
            // 
            // lblloaitk
            // 
            this.lblloaitk.AutoSize = true;
            this.lblloaitk.Location = new System.Drawing.Point(357, 363);
            this.lblloaitk.Name = "lblloaitk";
            this.lblloaitk.Size = new System.Drawing.Size(125, 24);
            this.lblloaitk.TabIndex = 20;
            this.lblloaitk.Text = "Loại tài khoản";
            // 
            // Thay_đỗi_tài_khoản
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.lblloaitk);
            this.Controls.Add(this.lbltinhtrang);
            this.Controls.Add(this.btnvethuong);
            this.Controls.Add(this.btnlenvip);
            this.Controls.Add(this.lbltrangthai);
            this.Controls.Add(this.btnkhoa);
            this.Controls.Add(this.btnphuchoi);
            this.Controls.Add(this.dsTai_khoan);
            this.Controls.Add(this.btQuay_lai);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Thay_đỗi_tài_khoản";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay_đỗi_tài_khoản";
            this.Load += new System.EventHandler(this.Thay_đỗi_tài_khoản_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTai_khoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuay_lai;
        private System.Windows.Forms.DataGridView dsTai_khoan;
        private System.Windows.Forms.Button btnphuchoi;
        private System.Windows.Forms.Button btnkhoa;
        private System.Windows.Forms.Label lbltrangthai;
        private System.Windows.Forms.Button btnlenvip;
        private System.Windows.Forms.Button btnvethuong;
        private System.Windows.Forms.Label lbltinhtrang;
        private System.Windows.Forms.Label lblloaitk;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_tai_khoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_tien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_khach_hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tinh_trang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai_tai_khoan;
    }
}