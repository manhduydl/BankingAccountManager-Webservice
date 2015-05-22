namespace Giao_diện
{
    partial class Sữa_khách_hàng
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblthaydoi = new System.Windows.Forms.Label();
            this.pnChon = new System.Windows.Forms.Panel();
            this.btChon = new System.Windows.Forms.Button();
            this.dsKhach_hang = new System.Windows.Forms.DataGridView();
            this.lblchonkh = new System.Windows.Forms.Label();
            this.pnSua = new System.Windows.Forms.Panel();
            this.MKH = new System.Windows.Forms.Label();
            this.tbDiachi = new System.Windows.Forms.TextBox();
            this.tbNgaysinh = new System.Windows.Forms.TextBox();
            this.tbGioitinh = new System.Windows.Forms.TextBox();
            this.tbCmnd = new System.Windows.Forms.TextBox();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblngaysinh = new System.Windows.Forms.Label();
            this.lblgt = new System.Windows.Forms.Label();
            this.lblcmnd = new System.Windows.Forms.Label();
            this.lblmakh = new System.Windows.Forms.Label();
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.btnthaydoi = new System.Windows.Forms.Button();
            this.lblhoten = new System.Windows.Forms.Label();
            this.btQuay_lai = new System.Windows.Forms.Button();
            this.Ma_khach_hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioi_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhach_hang)).BeginInit();
            this.pnSua.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.lblthaydoi);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 62);
            this.panel1.TabIndex = 17;
            // 
            // lblthaydoi
            // 
            this.lblthaydoi.AutoSize = true;
            this.lblthaydoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthaydoi.ForeColor = System.Drawing.Color.Black;
            this.lblthaydoi.Location = new System.Drawing.Point(3, 13);
            this.lblthaydoi.Name = "lblthaydoi";
            this.lblthaydoi.Size = new System.Drawing.Size(472, 39);
            this.lblthaydoi.TabIndex = 0;
            this.lblthaydoi.Text = "Thay đổi thông tin khách hàng";
            // 
            // pnChon
            // 
            this.pnChon.Controls.Add(this.pnSua);
            this.pnChon.Controls.Add(this.btChon);
            this.pnChon.Controls.Add(this.dsKhach_hang);
            this.pnChon.Controls.Add(this.lblchonkh);
            this.pnChon.Location = new System.Drawing.Point(12, 80);
            this.pnChon.Name = "pnChon";
            this.pnChon.Size = new System.Drawing.Size(656, 312);
            this.pnChon.TabIndex = 18;
            // 
            // btChon
            // 
            this.btChon.BackColor = System.Drawing.Color.Yellow;
            this.btChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChon.Image = global::Giao_diện.Properties.Resources.pin3_48;
            this.btChon.Location = new System.Drawing.Point(242, 256);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(165, 53);
            this.btChon.TabIndex = 20;
            this.btChon.Text = "Chọn";
            this.btChon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btChon.UseVisualStyleBackColor = false;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
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
            this.Dia_chi});
            this.dsKhach_hang.Location = new System.Drawing.Point(3, 42);
            this.dsKhach_hang.Name = "dsKhach_hang";
            this.dsKhach_hang.ReadOnly = true;
            this.dsKhach_hang.RowHeadersVisible = false;
            this.dsKhach_hang.Size = new System.Drawing.Size(650, 208);
            this.dsKhach_hang.TabIndex = 19;
            this.dsKhach_hang.SelectionChanged += new System.EventHandler(this.dsKhach_hang_SelectionChanged);
            // 
            // lblchonkh
            // 
            this.lblchonkh.AutoSize = true;
            this.lblchonkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchonkh.Location = new System.Drawing.Point(5, 8);
            this.lblchonkh.Name = "lblchonkh";
            this.lblchonkh.Size = new System.Drawing.Size(331, 26);
            this.lblchonkh.TabIndex = 18;
            this.lblchonkh.Text = "Chọn khách hàng muốn thay đỗi:\r\n";
            // 
            // pnSua
            // 
            this.pnSua.Controls.Add(this.MKH);
            this.pnSua.Controls.Add(this.tbDiachi);
            this.pnSua.Controls.Add(this.tbNgaysinh);
            this.pnSua.Controls.Add(this.tbGioitinh);
            this.pnSua.Controls.Add(this.tbCmnd);
            this.pnSua.Controls.Add(this.lbldiachi);
            this.pnSua.Controls.Add(this.lblngaysinh);
            this.pnSua.Controls.Add(this.lblgt);
            this.pnSua.Controls.Add(this.lblcmnd);
            this.pnSua.Controls.Add(this.lblmakh);
            this.pnSua.Controls.Add(this.tbHoten);
            this.pnSua.Controls.Add(this.btnthaydoi);
            this.pnSua.Controls.Add(this.lblhoten);
            this.pnSua.Location = new System.Drawing.Point(0, 0);
            this.pnSua.Name = "pnSua";
            this.pnSua.Size = new System.Drawing.Size(656, 312);
            this.pnSua.TabIndex = 19;
            this.pnSua.Visible = false;
            // 
            // MKH
            // 
            this.MKH.AutoSize = true;
            this.MKH.Location = new System.Drawing.Point(216, 12);
            this.MKH.Name = "MKH";
            this.MKH.Size = new System.Drawing.Size(0, 24);
            this.MKH.TabIndex = 15;
            // 
            // tbDiachi
            // 
            this.tbDiachi.Location = new System.Drawing.Point(201, 216);
            this.tbDiachi.Name = "tbDiachi";
            this.tbDiachi.Size = new System.Drawing.Size(246, 29);
            this.tbDiachi.TabIndex = 14;
            // 
            // tbNgaysinh
            // 
            this.tbNgaysinh.Location = new System.Drawing.Point(201, 174);
            this.tbNgaysinh.Name = "tbNgaysinh";
            this.tbNgaysinh.Size = new System.Drawing.Size(246, 29);
            this.tbNgaysinh.TabIndex = 13;
            // 
            // tbGioitinh
            // 
            this.tbGioitinh.Location = new System.Drawing.Point(201, 132);
            this.tbGioitinh.Name = "tbGioitinh";
            this.tbGioitinh.Size = new System.Drawing.Size(246, 29);
            this.tbGioitinh.TabIndex = 12;
            // 
            // tbCmnd
            // 
            this.tbCmnd.Location = new System.Drawing.Point(201, 90);
            this.tbCmnd.Name = "tbCmnd";
            this.tbCmnd.Size = new System.Drawing.Size(246, 29);
            this.tbCmnd.TabIndex = 11;
            // 
            // lbldiachi
            // 
            this.lbldiachi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldiachi.Location = new System.Drawing.Point(20, 219);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(171, 24);
            this.lbldiachi.TabIndex = 10;
            this.lbldiachi.Text = "Địa chỉ:";
            this.lbldiachi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblngaysinh
            // 
            this.lblngaysinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblngaysinh.Location = new System.Drawing.Point(18, 177);
            this.lblngaysinh.Name = "lblngaysinh";
            this.lblngaysinh.Size = new System.Drawing.Size(173, 24);
            this.lblngaysinh.TabIndex = 9;
            this.lblngaysinh.Text = "Ngày sinh:";
            this.lblngaysinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblgt
            // 
            this.lblgt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblgt.Location = new System.Drawing.Point(34, 135);
            this.lblgt.Name = "lblgt";
            this.lblgt.Size = new System.Drawing.Size(157, 24);
            this.lblgt.TabIndex = 8;
            this.lblgt.Text = "Giới tính:";
            this.lblgt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblcmnd
            // 
            this.lblcmnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcmnd.Location = new System.Drawing.Point(10, 93);
            this.lblcmnd.Name = "lblcmnd";
            this.lblcmnd.Size = new System.Drawing.Size(181, 24);
            this.lblcmnd.TabIndex = 7;
            this.lblcmnd.Text = "CMND:";
            this.lblcmnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblmakh
            // 
            this.lblmakh.AutoSize = true;
            this.lblmakh.Location = new System.Drawing.Point(46, 12);
            this.lblmakh.Name = "lblmakh";
            this.lblmakh.Size = new System.Drawing.Size(145, 24);
            this.lblmakh.TabIndex = 6;
            this.lblmakh.Text = "Mã khách hàng:";
            // 
            // tbHoten
            // 
            this.tbHoten.BackColor = System.Drawing.Color.White;
            this.tbHoten.Location = new System.Drawing.Point(201, 48);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(246, 29);
            this.tbHoten.TabIndex = 4;
            // 
            // btnthaydoi
            // 
            this.btnthaydoi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnthaydoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthaydoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthaydoi.Image = global::Giao_diện.Properties.Resources.edit_48;
            this.btnthaydoi.Location = new System.Drawing.Point(247, 251);
            this.btnthaydoi.Name = "btnthaydoi";
            this.btnthaydoi.Size = new System.Drawing.Size(171, 57);
            this.btnthaydoi.TabIndex = 3;
            this.btnthaydoi.Text = "Thay đổi";
            this.btnthaydoi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnthaydoi.UseVisualStyleBackColor = false;
            this.btnthaydoi.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblhoten
            // 
            this.lblhoten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblhoten.Location = new System.Drawing.Point(46, 51);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(145, 24);
            this.lblhoten.TabIndex = 0;
            this.lblhoten.Text = "Họ tên:";
            this.lblhoten.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btQuay_lai
            // 
            this.btQuay_lai.BackColor = System.Drawing.Color.Khaki;
            this.btQuay_lai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuay_lai.ForeColor = System.Drawing.Color.Black;
            this.btQuay_lai.Image = global::Giao_diện.Properties.Resources.undo_26;
            this.btQuay_lai.Location = new System.Drawing.Point(547, 398);
            this.btQuay_lai.Name = "btQuay_lai";
            this.btQuay_lai.Size = new System.Drawing.Size(121, 40);
            this.btQuay_lai.TabIndex = 16;
            this.btQuay_lai.Text = "Quay lại";
            this.btQuay_lai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuay_lai.UseVisualStyleBackColor = false;
            this.btQuay_lai.Click += new System.EventHandler(this.btQuay_lai_Click);
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
            // Sữa_khách_hàng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.pnChon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btQuay_lai);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Sữa_khách_hàng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sữa_khách_hàng";
            this.Load += new System.EventHandler(this.Sữa_khách_hàng_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnChon.ResumeLayout(false);
            this.pnChon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhach_hang)).EndInit();
            this.pnSua.ResumeLayout(false);
            this.pnSua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btQuay_lai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblthaydoi;
        private System.Windows.Forms.Panel pnChon;
        private System.Windows.Forms.Button btChon;
        private System.Windows.Forms.DataGridView dsKhach_hang;
        private System.Windows.Forms.Label lblchonkh;
        private System.Windows.Forms.Panel pnSua;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblmakh;
        private System.Windows.Forms.TextBox tbHoten;
        private System.Windows.Forms.Button btnthaydoi;
        private System.Windows.Forms.TextBox tbDiachi;
        private System.Windows.Forms.TextBox tbNgaysinh;
        private System.Windows.Forms.TextBox tbGioitinh;
        private System.Windows.Forms.TextBox tbCmnd;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblngaysinh;
        private System.Windows.Forms.Label lblgt;
        private System.Windows.Forms.Label lblcmnd;
        private System.Windows.Forms.Label MKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_khach_hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia_chi;
    }
}