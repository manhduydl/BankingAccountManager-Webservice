namespace Giao_diện
{
    partial class Khách_hàng
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
            this.components = new System.ComponentModel.Container();
            this.Ten = new System.Windows.Forms.Label();
            this.STK = new System.Windows.Forms.Label();
            this.STHC = new System.Windows.Forms.Label();
            this.lbLoaiTK = new System.Windows.Forms.Label();
            this.btndoitk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDang_xuat = new System.Windows.Forms.Button();
            this.btnthongke = new System.Windows.Forms.Button();
            this.btNap_tien = new System.Windows.Forms.Button();
            this.btnchuyentien = new System.Windows.Forms.Button();
            this.MaKH = new System.Windows.Forms.Label();
            this.CMND = new System.Windows.Forms.Label();
            this.GT = new System.Windows.Forms.Label();
            this.NS = new System.Windows.Forms.Label();
            this.DC = new System.Windows.Forms.Label();
            this.gbxKh = new System.Windows.Forms.GroupBox();
            this.lblSotien = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.lblCmnd = new System.Windows.Forms.Label();
            this.lblMakh = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lblStk = new System.Windows.Forms.Label();
            this.bindingSource1KH = new System.Windows.Forms.BindingSource(this.components);
            this.gbxKh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1KH)).BeginInit();
            this.SuspendLayout();
            // 
            // Ten
            // 
            this.Ten.Location = new System.Drawing.Point(12, 62);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(183, 24);
            this.Ten.TabIndex = 3;
            this.Ten.Text = "Họ tên:";
            this.Ten.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // STK
            // 
            this.STK.Location = new System.Drawing.Point(6, 38);
            this.STK.Name = "STK";
            this.STK.Size = new System.Drawing.Size(189, 24);
            this.STK.TabIndex = 4;
            this.STK.Text = "Số tài khoản: ";
            this.STK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // STHC
            // 
            this.STHC.Location = new System.Drawing.Point(12, 213);
            this.STHC.Name = "STHC";
            this.STHC.Size = new System.Drawing.Size(183, 24);
            this.STHC.TabIndex = 5;
            this.STHC.Text = "Số tiền hiện có: ";
            this.STHC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLoaiTK
            // 
            this.lbLoaiTK.AutoSize = true;
            this.lbLoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiTK.Location = new System.Drawing.Point(22, 9);
            this.lbLoaiTK.Name = "lbLoaiTK";
            this.lbLoaiTK.Size = new System.Drawing.Size(429, 31);
            this.lbLoaiTK.TabIndex = 8;
            this.lbLoaiTK.Text = "Bạn đang đăng nhập với tài khoản ";
            // 
            // btndoitk
            // 
            this.btndoitk.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btndoitk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndoitk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoitk.Image = global::Giao_diện.Properties.Resources.brush_48;
            this.btndoitk.Location = new System.Drawing.Point(493, 269);
            this.btndoitk.Name = "btndoitk";
            this.btndoitk.Size = new System.Drawing.Size(239, 59);
            this.btndoitk.TabIndex = 9;
            this.btndoitk.Text = "Đổi tài khoản";
            this.btndoitk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndoitk.UseVisualStyleBackColor = false;
            this.btndoitk.Click += new System.EventHandler(this.btDMK_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Giao_diện.Properties.Resources.administrator2_48;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 100);
            this.panel1.TabIndex = 7;
            // 
            // btDang_xuat
            // 
            this.btDang_xuat.BackColor = System.Drawing.Color.Khaki;
            this.btDang_xuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDang_xuat.Image = global::Giao_diện.Properties.Resources.settings3_26;
            this.btDang_xuat.Location = new System.Drawing.Point(588, 395);
            this.btDang_xuat.Name = "btDang_xuat";
            this.btDang_xuat.Size = new System.Drawing.Size(144, 43);
            this.btDang_xuat.TabIndex = 6;
            this.btDang_xuat.Text = "Đăng xuất";
            this.btDang_xuat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btDang_xuat.UseVisualStyleBackColor = false;
            this.btDang_xuat.Click += new System.EventHandler(this.btDang_xuat_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnthongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongke.Image = global::Giao_diện.Properties.Resources.combo_48;
            this.btnthongke.Location = new System.Drawing.Point(493, 69);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(239, 63);
            this.btnthongke.TabIndex = 2;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthongke.UseVisualStyleBackColor = false;
            this.btnthongke.Click += new System.EventHandler(this.button3_Click);
            // 
            // btNap_tien
            // 
            this.btNap_tien.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btNap_tien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNap_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNap_tien.Image = global::Giao_diện.Properties.Resources.moneybox_48;
            this.btNap_tien.Location = new System.Drawing.Point(493, 139);
            this.btNap_tien.Name = "btNap_tien";
            this.btNap_tien.Size = new System.Drawing.Size(239, 57);
            this.btNap_tien.TabIndex = 1;
            this.btNap_tien.Text = "Nạp tiền";
            this.btNap_tien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNap_tien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNap_tien.UseVisualStyleBackColor = false;
            this.btNap_tien.Click += new System.EventHandler(this.btNap_tien_Click);
            // 
            // btnchuyentien
            // 
            this.btnchuyentien.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnchuyentien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchuyentien.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchuyentien.Image = global::Giao_diện.Properties.Resources.money_exchange_48;
            this.btnchuyentien.Location = new System.Drawing.Point(493, 203);
            this.btnchuyentien.Name = "btnchuyentien";
            this.btnchuyentien.Size = new System.Drawing.Size(239, 59);
            this.btnchuyentien.TabIndex = 0;
            this.btnchuyentien.Text = "Chuyển tiền";
            this.btnchuyentien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnchuyentien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnchuyentien.UseVisualStyleBackColor = false;
            this.btnchuyentien.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaKH
            // 
            this.MaKH.Location = new System.Drawing.Point(8, 88);
            this.MaKH.Name = "MaKH";
            this.MaKH.Size = new System.Drawing.Size(187, 24);
            this.MaKH.TabIndex = 10;
            this.MaKH.Text = "Mã khách hàng: ";
            this.MaKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CMND
            // 
            this.CMND.Location = new System.Drawing.Point(10, 113);
            this.CMND.Name = "CMND";
            this.CMND.Size = new System.Drawing.Size(185, 24);
            this.CMND.TabIndex = 11;
            this.CMND.Text = "Cmnd: ";
            this.CMND.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GT
            // 
            this.GT.Location = new System.Drawing.Point(12, 138);
            this.GT.Name = "GT";
            this.GT.Size = new System.Drawing.Size(183, 24);
            this.GT.TabIndex = 12;
            this.GT.Text = "Giới tính: ";
            this.GT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NS
            // 
            this.NS.Location = new System.Drawing.Point(16, 163);
            this.NS.Name = "NS";
            this.NS.Size = new System.Drawing.Size(179, 24);
            this.NS.TabIndex = 13;
            this.NS.Text = "Ngày sinh: ";
            this.NS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DC
            // 
            this.DC.Location = new System.Drawing.Point(20, 188);
            this.DC.Name = "DC";
            this.DC.Size = new System.Drawing.Size(175, 24);
            this.DC.TabIndex = 14;
            this.DC.Text = "Địa chỉ: ";
            this.DC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxKh
            // 
            this.gbxKh.Controls.Add(this.lblSotien);
            this.gbxKh.Controls.Add(this.lblDiachi);
            this.gbxKh.Controls.Add(this.lblNgaysinh);
            this.gbxKh.Controls.Add(this.lblGioitinh);
            this.gbxKh.Controls.Add(this.lblCmnd);
            this.gbxKh.Controls.Add(this.lblMakh);
            this.gbxKh.Controls.Add(this.lblHoten);
            this.gbxKh.Controls.Add(this.lblStk);
            this.gbxKh.Controls.Add(this.STK);
            this.gbxKh.Controls.Add(this.DC);
            this.gbxKh.Controls.Add(this.Ten);
            this.gbxKh.Controls.Add(this.NS);
            this.gbxKh.Controls.Add(this.MaKH);
            this.gbxKh.Controls.Add(this.STHC);
            this.gbxKh.Controls.Add(this.GT);
            this.gbxKh.Controls.Add(this.CMND);
            this.gbxKh.Location = new System.Drawing.Point(12, 186);
            this.gbxKh.Name = "gbxKh";
            this.gbxKh.Size = new System.Drawing.Size(462, 252);
            this.gbxKh.TabIndex = 15;
            this.gbxKh.TabStop = false;
            this.gbxKh.Text = "Thông tin khách hàng";
            // 
            // lblSotien
            // 
            this.lblSotien.AutoSize = true;
            this.lblSotien.Location = new System.Drawing.Point(201, 213);
            this.lblSotien.Name = "lblSotien";
            this.lblSotien.Size = new System.Drawing.Size(40, 24);
            this.lblSotien.TabIndex = 22;
            this.lblSotien.Text = "tien";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(201, 189);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(46, 24);
            this.lblDiachi.TabIndex = 21;
            this.lblDiachi.Text = "dchi";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(201, 163);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(30, 24);
            this.lblNgaysinh.TabIndex = 20;
            this.lblNgaysinh.Text = "ns";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Location = new System.Drawing.Point(201, 138);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(25, 24);
            this.lblGioitinh.TabIndex = 19;
            this.lblGioitinh.Text = "gt";
            // 
            // lblCmnd
            // 
            this.lblCmnd.AutoSize = true;
            this.lblCmnd.Location = new System.Drawing.Point(201, 113);
            this.lblCmnd.Name = "lblCmnd";
            this.lblCmnd.Size = new System.Drawing.Size(58, 24);
            this.lblCmnd.TabIndex = 18;
            this.lblCmnd.Text = "cmnd";
            // 
            // lblMakh
            // 
            this.lblMakh.AutoSize = true;
            this.lblMakh.Location = new System.Drawing.Point(201, 88);
            this.lblMakh.Name = "lblMakh";
            this.lblMakh.Size = new System.Drawing.Size(56, 24);
            this.lblMakh.TabIndex = 17;
            this.lblMakh.Text = "makh";
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Location = new System.Drawing.Point(201, 62);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(58, 24);
            this.lblHoten.TabIndex = 16;
            this.lblHoten.Text = "hoten";
            // 
            // lblStk
            // 
            this.lblStk.AutoSize = true;
            this.lblStk.Location = new System.Drawing.Point(201, 38);
            this.lblStk.Name = "lblStk";
            this.lblStk.Size = new System.Drawing.Size(32, 24);
            this.lblStk.TabIndex = 15;
            this.lblStk.Text = "stk";
            // 
            // Khách_hàng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.gbxKh);
            this.Controls.Add(this.btndoitk);
            this.Controls.Add(this.lbLoaiTK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btDang_xuat);
            this.Controls.Add(this.btnthongke);
            this.Controls.Add(this.btNap_tien);
            this.Controls.Add(this.btnchuyentien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Khách_hàng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách_hàng";
            this.Load += new System.EventHandler(this.Khách_hàng_Load);
            this.gbxKh.ResumeLayout(false);
            this.gbxKh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1KH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnchuyentien;
        private System.Windows.Forms.Button btNap_tien;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.Label Ten;
        private System.Windows.Forms.Label STK;
        private System.Windows.Forms.Label STHC;
        private System.Windows.Forms.Button btDang_xuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbLoaiTK;
        private System.Windows.Forms.Button btndoitk;
        private System.Windows.Forms.Label MaKH;
        private System.Windows.Forms.Label CMND;
        private System.Windows.Forms.Label GT;
        private System.Windows.Forms.Label NS;
        private System.Windows.Forms.Label DC;
        private System.Windows.Forms.GroupBox gbxKh;
        private System.Windows.Forms.BindingSource bindingSource1KH;
        private System.Windows.Forms.Label lblSotien;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label lblCmnd;
        private System.Windows.Forms.Label lblMakh;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Label lblStk;

    }
}