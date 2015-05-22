namespace Giao_diện
{
    partial class Thêm_tài_khoản_kh
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
            this.lblchonkh = new System.Windows.Forms.Label();
            this.dsKhach_hang = new System.Windows.Forms.DataGridView();
            this.Ma_khach_hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioi_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tinh_trang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btChon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhach_hang)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuay_lai
            // 
            this.btQuay_lai.BackColor = System.Drawing.Color.Khaki;
            this.btQuay_lai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuay_lai.Image = global::Giao_diện.Properties.Resources.undo_26;
            this.btQuay_lai.Location = new System.Drawing.Point(653, 399);
            this.btQuay_lai.Name = "btQuay_lai";
            this.btQuay_lai.Size = new System.Drawing.Size(122, 34);
            this.btQuay_lai.TabIndex = 13;
            this.btQuay_lai.Text = "Quay lại";
            this.btQuay_lai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuay_lai.UseVisualStyleBackColor = false;
            this.btQuay_lai.Click += new System.EventHandler(this.btQuay_lai_Click);
            // 
            // lblchonkh
            // 
            this.lblchonkh.AutoSize = true;
            this.lblchonkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchonkh.Location = new System.Drawing.Point(12, 22);
            this.lblchonkh.Name = "lblchonkh";
            this.lblchonkh.Size = new System.Drawing.Size(198, 29);
            this.lblchonkh.TabIndex = 14;
            this.lblchonkh.Text = "Chọn khách hàng";
            // 
            // dsKhach_hang
            // 
            this.dsKhach_hang.AllowUserToAddRows = false;
            this.dsKhach_hang.AllowUserToDeleteRows = false;
            this.dsKhach_hang.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dsKhach_hang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsKhach_hang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_khach_hang,
            this.Ho_ten,
            this.Cmnd,
            this.Gioi_tinh,
            this.Ngay_sinh,
            this.Dia_chi,
            this.Tinh_trang});
            this.dsKhach_hang.Location = new System.Drawing.Point(16, 64);
            this.dsKhach_hang.Name = "dsKhach_hang";
            this.dsKhach_hang.ReadOnly = true;
            this.dsKhach_hang.RowHeadersVisible = false;
            this.dsKhach_hang.Size = new System.Drawing.Size(759, 301);
            this.dsKhach_hang.TabIndex = 20;
            this.dsKhach_hang.SelectionChanged += new System.EventHandler(this.dsKhach_hang_SelectionChanged);
            // 
            // Ma_khach_hang
            // 
            this.Ma_khach_hang.DataPropertyName = "Ma_khach_hang";
            this.Ma_khach_hang.HeaderText = "Mã khách hàng";
            this.Ma_khach_hang.Name = "Ma_khach_hang";
            this.Ma_khach_hang.ReadOnly = true;
            this.Ma_khach_hang.Width = 170;
            // 
            // Ho_ten
            // 
            this.Ho_ten.DataPropertyName = "Ho_ten";
            this.Ho_ten.HeaderText = "Họ tên";
            this.Ho_ten.Name = "Ho_ten";
            this.Ho_ten.ReadOnly = true;
            // 
            // Cmnd
            // 
            this.Cmnd.DataPropertyName = "Cmnd";
            this.Cmnd.HeaderText = "CMND";
            this.Cmnd.Name = "Cmnd";
            this.Cmnd.ReadOnly = true;
            this.Cmnd.Width = 90;
            // 
            // Gioi_tinh
            // 
            this.Gioi_tinh.DataPropertyName = "Gioi_tinh";
            this.Gioi_tinh.HeaderText = "Giới tính";
            this.Gioi_tinh.Name = "Gioi_tinh";
            this.Gioi_tinh.ReadOnly = true;
            this.Gioi_tinh.Width = 110;
            // 
            // Ngay_sinh
            // 
            this.Ngay_sinh.DataPropertyName = "Ngay_sinh";
            this.Ngay_sinh.HeaderText = "Ngày sinh";
            this.Ngay_sinh.Name = "Ngay_sinh";
            this.Ngay_sinh.ReadOnly = true;
            this.Ngay_sinh.Width = 120;
            // 
            // Dia_chi
            // 
            this.Dia_chi.DataPropertyName = "Dia_chi";
            this.Dia_chi.HeaderText = "Địa Chỉ";
            this.Dia_chi.Name = "Dia_chi";
            this.Dia_chi.ReadOnly = true;
            // 
            // Tinh_trang
            // 
            this.Tinh_trang.DataPropertyName = "Tinh_trang";
            this.Tinh_trang.HeaderText = "Tình trạng";
            this.Tinh_trang.Name = "Tinh_trang";
            this.Tinh_trang.ReadOnly = true;
            this.Tinh_trang.Width = 130;
            // 
            // btChon
            // 
            this.btChon.BackColor = System.Drawing.Color.Yellow;
            this.btChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChon.Image = global::Giao_diện.Properties.Resources.pin3_48;
            this.btChon.Location = new System.Drawing.Point(266, 385);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(165, 53);
            this.btChon.TabIndex = 21;
            this.btChon.Text = "Chọn";
            this.btChon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btChon.UseVisualStyleBackColor = false;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // Thêm_tài_khoản_kh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.btChon);
            this.Controls.Add(this.dsKhach_hang);
            this.Controls.Add(this.lblchonkh);
            this.Controls.Add(this.btQuay_lai);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Thêm_tài_khoản_kh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm_tài_khoản_kh";
            this.Load += new System.EventHandler(this.Thêm_tài_khoản_kh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsKhach_hang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuay_lai;
        private System.Windows.Forms.Label lblchonkh;
        private System.Windows.Forms.DataGridView dsKhach_hang;
        private System.Windows.Forms.Button btChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_khach_hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia_chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tinh_trang;
    }
}