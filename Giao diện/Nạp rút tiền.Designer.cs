namespace Giao_diện
{
    partial class Nạp_rút_tiền
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
            this.lblnaprut = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btRut = new System.Windows.Forms.Button();
            this.btNap = new System.Windows.Forms.Button();
            this.lblsotien = new System.Windows.Forms.Label();
            this.lblstk = new System.Windows.Forms.Label();
            this.btChon = new System.Windows.Forms.Button();
            this.dsTai_khoan = new System.Windows.Forms.DataGridView();
            this.So_tai_khoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_khach_hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tinh_trang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai_tai_khoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btTDTT = new System.Windows.Forms.Button();
            this.lblsthc = new System.Windows.Forms.Label();
            this.lblst = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTai_khoan)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuay_lai
            // 
            this.btQuay_lai.BackColor = System.Drawing.Color.Khaki;
            this.btQuay_lai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuay_lai.Image = global::Giao_diện.Properties.Resources.undo_26;
            this.btQuay_lai.Location = new System.Drawing.Point(546, 404);
            this.btQuay_lai.Name = "btQuay_lai";
            this.btQuay_lai.Size = new System.Drawing.Size(122, 34);
            this.btQuay_lai.TabIndex = 12;
            this.btQuay_lai.Text = "Quay lại";
            this.btQuay_lai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuay_lai.UseVisualStyleBackColor = false;
            this.btQuay_lai.Click += new System.EventHandler(this.btQuay_lai_Click);
            // 
            // lblnaprut
            // 
            this.lblnaprut.AutoSize = true;
            this.lblnaprut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnaprut.Location = new System.Drawing.Point(12, 23);
            this.lblnaprut.Name = "lblnaprut";
            this.lblnaprut.Size = new System.Drawing.Size(154, 31);
            this.lblnaprut.TabIndex = 15;
            this.lblnaprut.Text = "Nạp rút tiền";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btChon);
            this.panel1.Controls.Add(this.dsTai_khoan);
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 331);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel2.Controls.Add(this.lblst);
            this.panel2.Controls.Add(this.lblsthc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btRut);
            this.panel2.Controls.Add(this.btNap);
            this.panel2.Controls.Add(this.lblsotien);
            this.panel2.Controls.Add(this.lblstk);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 331);
            this.panel2.TabIndex = 16;
            this.panel2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 29);
            this.textBox1.TabIndex = 4;
            // 
            // btRut
            // 
            this.btRut.BackColor = System.Drawing.Color.Olive;
            this.btRut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRut.Location = new System.Drawing.Point(348, 206);
            this.btRut.Name = "btRut";
            this.btRut.Size = new System.Drawing.Size(104, 53);
            this.btRut.TabIndex = 3;
            this.btRut.Text = "Rút";
            this.btRut.UseVisualStyleBackColor = false;
            this.btRut.Click += new System.EventHandler(this.btRut_Click);
            // 
            // btNap
            // 
            this.btNap.BackColor = System.Drawing.Color.Olive;
            this.btNap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNap.Location = new System.Drawing.Point(184, 206);
            this.btNap.Name = "btNap";
            this.btNap.Size = new System.Drawing.Size(95, 53);
            this.btNap.TabIndex = 2;
            this.btNap.Text = "Nạp";
            this.btNap.UseVisualStyleBackColor = false;
            this.btNap.Click += new System.EventHandler(this.btNap_Click);
            // 
            // lblsotien
            // 
            this.lblsotien.Location = new System.Drawing.Point(39, 106);
            this.lblsotien.Name = "lblsotien";
            this.lblsotien.Size = new System.Drawing.Size(136, 24);
            this.lblsotien.TabIndex = 1;
            this.lblsotien.Text = "Số tiền";
            this.lblsotien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblstk
            // 
            this.lblstk.Location = new System.Drawing.Point(43, 57);
            this.lblstk.Name = "lblstk";
            this.lblstk.Size = new System.Drawing.Size(132, 24);
            this.lblstk.TabIndex = 0;
            this.lblstk.Text = "Số tài khoản";
            this.lblstk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btChon
            // 
            this.btChon.BackColor = System.Drawing.Color.Olive;
            this.btChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChon.Location = new System.Drawing.Point(231, 278);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(168, 39);
            this.btChon.TabIndex = 15;
            this.btChon.Text = "Chọn tài khoản";
            this.btChon.UseVisualStyleBackColor = false;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
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
            this.dsTai_khoan.Location = new System.Drawing.Point(18, 3);
            this.dsTai_khoan.Name = "dsTai_khoan";
            this.dsTai_khoan.ReadOnly = true;
            this.dsTai_khoan.RowHeadersVisible = false;
            this.dsTai_khoan.Size = new System.Drawing.Size(616, 256);
            this.dsTai_khoan.TabIndex = 14;
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
            this.Tinh_trang.Width = 128;
            // 
            // Loai_tai_khoan
            // 
            this.Loai_tai_khoan.DataPropertyName = "Loai_tai_khoan";
            this.Loai_tai_khoan.HeaderText = "Loại tài khoản";
            this.Loai_tai_khoan.Name = "Loai_tai_khoan";
            this.Loai_tai_khoan.ReadOnly = true;
            this.Loai_tai_khoan.Width = 180;
            // 
            // btTDTT
            // 
            this.btTDTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTDTT.Location = new System.Drawing.Point(325, 404);
            this.btTDTT.Name = "btTDTT";
            this.btTDTT.Size = new System.Drawing.Size(185, 34);
            this.btTDTT.TabIndex = 17;
            this.btTDTT.Text = "Thay đỗi trạng thái";
            this.btTDTT.UseVisualStyleBackColor = true;
            this.btTDTT.Click += new System.EventHandler(this.btTDTT_Click);
            // 
            // lblsthc
            // 
            this.lblsthc.AutoSize = true;
            this.lblsthc.Location = new System.Drawing.Point(184, 153);
            this.lblsthc.Name = "lblsthc";
            this.lblsthc.Size = new System.Drawing.Size(60, 24);
            this.lblsthc.TabIndex = 6;
            this.lblsthc.Text = "label1";
            // 
            // lblst
            // 
            this.lblst.Location = new System.Drawing.Point(18, 153);
            this.lblst.Name = "lblst";
            this.lblst.Size = new System.Drawing.Size(157, 24);
            this.lblst.TabIndex = 7;
            this.lblst.Text = "Số tiền hiện có:\r\n";
            this.lblst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Nạp_rút_tiền
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.btTDTT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblnaprut);
            this.Controls.Add(this.btQuay_lai);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Nạp_rút_tiền";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nạp_rút_tiền";
            this.Load += new System.EventHandler(this.Nạp_rút_tiền_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTai_khoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuay_lai;
        private System.Windows.Forms.Label lblnaprut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btChon;
        private System.Windows.Forms.DataGridView dsTai_khoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btRut;
        private System.Windows.Forms.Button btNap;
        private System.Windows.Forms.Label lblsotien;
        private System.Windows.Forms.Label lblstk;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_tai_khoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_tien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_khach_hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tinh_trang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai_tai_khoan;
        private System.Windows.Forms.Button btTDTT;
        private System.Windows.Forms.Label lblsthc;
        private System.Windows.Forms.Label lblst;
    }
}