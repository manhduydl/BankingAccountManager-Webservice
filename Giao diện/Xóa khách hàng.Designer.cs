namespace Giao_diện
{
    partial class Xóa_khách_hàng
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblhuykh = new System.Windows.Forms.Label();
            this.lblchonkh = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnphuchoi = new System.Windows.Forms.Button();
            this.dsKhach_hang = new System.Windows.Forms.DataGridView();
            this.Ma_khach_hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tinh_trang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioi_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhach_hang)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuay_lai
            // 
            this.btQuay_lai.BackColor = System.Drawing.Color.Khaki;
            this.btQuay_lai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuay_lai.ForeColor = System.Drawing.Color.Black;
            this.btQuay_lai.Image = global::Giao_diện.Properties.Resources.undo_26;
            this.btQuay_lai.Location = new System.Drawing.Point(543, 398);
            this.btQuay_lai.Name = "btQuay_lai";
            this.btQuay_lai.Size = new System.Drawing.Size(125, 40);
            this.btQuay_lai.TabIndex = 15;
            this.btQuay_lai.Text = "Quay lại";
            this.btQuay_lai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuay_lai.UseVisualStyleBackColor = false;
            this.btQuay_lai.Click += new System.EventHandler(this.btQuay_lai_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.lblhuykh);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 62);
            this.panel1.TabIndex = 14;
            // 
            // lblhuykh
            // 
            this.lblhuykh.AutoSize = true;
            this.lblhuykh.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhuykh.ForeColor = System.Drawing.Color.Black;
            this.lblhuykh.Location = new System.Drawing.Point(3, 13);
            this.lblhuykh.Name = "lblhuykh";
            this.lblhuykh.Size = new System.Drawing.Size(263, 39);
            this.lblhuykh.TabIndex = 0;
            this.lblhuykh.Text = "Hủy khách hàng";
            // 
            // lblchonkh
            // 
            this.lblchonkh.AutoSize = true;
            this.lblchonkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchonkh.ForeColor = System.Drawing.Color.Black;
            this.lblchonkh.Location = new System.Drawing.Point(12, 86);
            this.lblchonkh.Name = "lblchonkh";
            this.lblchonkh.Size = new System.Drawing.Size(290, 26);
            this.lblchonkh.TabIndex = 17;
            this.lblchonkh.Text = "Chọn khách hàng muốn hủy:";
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.IndianRed;
            this.btnhuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.ForeColor = System.Drawing.Color.Black;
            this.btnhuy.Image = global::Giao_diện.Properties.Resources.erase_48;
            this.btnhuy.Location = new System.Drawing.Point(274, 383);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(143, 55);
            this.btnhuy.TabIndex = 18;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btnphuchoi
            // 
            this.btnphuchoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnphuchoi.ForeColor = System.Drawing.Color.Black;
            this.btnphuchoi.Location = new System.Drawing.Point(12, 398);
            this.btnphuchoi.Name = "btnphuchoi";
            this.btnphuchoi.Size = new System.Drawing.Size(131, 40);
            this.btnphuchoi.TabIndex = 21;
            this.btnphuchoi.Text = "Phục hồi";
            this.btnphuchoi.UseVisualStyleBackColor = true;
            this.btnphuchoi.Click += new System.EventHandler(this.btPhucHoi_Click);
            // 
            // dsKhach_hang
            // 
            this.dsKhach_hang.AllowUserToAddRows = false;
            this.dsKhach_hang.AllowUserToDeleteRows = false;
            this.dsKhach_hang.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dsKhach_hang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsKhach_hang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_khach_hang,
            this.Tinh_trang,
            this.Ho_ten,
            this.Cmnd,
            this.Gioi_tinh,
            this.Ngay_sinh,
            this.Dia_chi});
            this.dsKhach_hang.Location = new System.Drawing.Point(15, 121);
            this.dsKhach_hang.Name = "dsKhach_hang";
            this.dsKhach_hang.ReadOnly = true;
            this.dsKhach_hang.RowHeadersVisible = false;
            this.dsKhach_hang.Size = new System.Drawing.Size(653, 239);
            this.dsKhach_hang.TabIndex = 22;
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
            // Tinh_trang
            // 
            this.Tinh_trang.DataPropertyName = "Tinh_trang";
            this.Tinh_trang.HeaderText = "Tình trạng";
            this.Tinh_trang.Name = "Tinh_trang";
            this.Tinh_trang.ReadOnly = true;
            this.Tinh_trang.Width = 120;
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
            this.Dia_chi.Width = 110;
            // 
            // Xóa_khách_hàng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.dsKhach_hang);
            this.Controls.Add(this.btnphuchoi);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.lblchonkh);
            this.Controls.Add(this.btQuay_lai);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Xóa_khách_hàng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa_khách_hàng";
            this.Load += new System.EventHandler(this.Xóa_khách_hàng_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhach_hang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuay_lai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblhuykh;
        private System.Windows.Forms.Label lblchonkh;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnphuchoi;
        private System.Windows.Forms.DataGridView dsKhach_hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_khach_hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tinh_trang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia_chi;
    }
}