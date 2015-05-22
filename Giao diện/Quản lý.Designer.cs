namespace Giao_diện
{
    partial class Quản_lý
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Chuyen_tienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btChuyen = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btQuay_lai = new System.Windows.Forms.Button();
            this.btTatCa = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblngaybd = new System.Windows.Forms.Label();
            this.lblngaykt = new System.Windows.Forms.Label();
            this.btntim = new System.Windows.Forms.Button();
            this.NBT = new System.Windows.Forms.Label();
            this.NKT = new System.Windows.Forms.Label();
            this.lbltip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chuyen_tienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Chuyen_tienBindingSource
            // 
            this.Chuyen_tienBindingSource.DataSource = typeof(DTO.Chuyen_tien);
            // 
            // btChuyen
            // 
            this.btChuyen.BackColor = System.Drawing.Color.LightGreen;
            this.btChuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChuyen.Location = new System.Drawing.Point(258, 12);
            this.btChuyen.Name = "btChuyen";
            this.btChuyen.Size = new System.Drawing.Size(130, 40);
            this.btChuyen.TabIndex = 2;
            this.btChuyen.Text = "Chuyển";
            this.btChuyen.UseVisualStyleBackColor = false;
            this.btChuyen.Click += new System.EventHandler(this.btChuyen_Click);
            // 
            // btNhan
            // 
            this.btNhan.BackColor = System.Drawing.Color.LightGreen;
            this.btNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhan.Location = new System.Drawing.Point(397, 12);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(130, 40);
            this.btNhan.TabIndex = 3;
            this.btNhan.Text = "Nhận";
            this.btNhan.UseVisualStyleBackColor = false;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Giao_diện.Properties.Resources.combo_48;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 82);
            this.panel1.TabIndex = 4;
            // 
            // btQuay_lai
            // 
            this.btQuay_lai.BackColor = System.Drawing.Color.Khaki;
            this.btQuay_lai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuay_lai.Image = global::Giao_diện.Properties.Resources.undo_26;
            this.btQuay_lai.Location = new System.Drawing.Point(634, 427);
            this.btQuay_lai.Name = "btQuay_lai";
            this.btQuay_lai.Size = new System.Drawing.Size(124, 39);
            this.btQuay_lai.TabIndex = 1;
            this.btQuay_lai.Text = "Quay lại";
            this.btQuay_lai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuay_lai.UseVisualStyleBackColor = false;
            this.btQuay_lai.Click += new System.EventHandler(this.btQuay_lai_Click);
            // 
            // btTatCa
            // 
            this.btTatCa.BackColor = System.Drawing.Color.LightGreen;
            this.btTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTatCa.Location = new System.Drawing.Point(119, 12);
            this.btTatCa.Name = "btTatCa";
            this.btTatCa.Size = new System.Drawing.Size(130, 40);
            this.btTatCa.TabIndex = 6;
            this.btTatCa.Text = "Tất cả";
            this.btTatCa.UseVisualStyleBackColor = false;
            this.btTatCa.Click += new System.EventHandler(this.btTatCa_Click);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Chuyen_tienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Giao_diện.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 185);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(746, 217);
            this.reportViewer1.TabIndex = 7;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(532, 11);
            this.monthCalendar1.MaxSelectionCount = 100;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblngaybd
            // 
            this.lblngaybd.Location = new System.Drawing.Point(21, 109);
            this.lblngaybd.Name = "lblngaybd";
            this.lblngaybd.Size = new System.Drawing.Size(127, 24);
            this.lblngaybd.TabIndex = 11;
            this.lblngaybd.Text = "Ngày bắt đầu:";
            this.lblngaybd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblngaykt
            // 
            this.lblngaykt.Location = new System.Drawing.Point(21, 149);
            this.lblngaykt.Name = "lblngaykt";
            this.lblngaykt.Size = new System.Drawing.Size(129, 24);
            this.lblngaykt.TabIndex = 12;
            this.lblngaykt.Text = "Ngày kết thúc:";
            this.lblngaykt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btntim
            // 
            this.btntim.BackColor = System.Drawing.Color.LightGreen;
            this.btntim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntim.Location = new System.Drawing.Point(224, 58);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(195, 39);
            this.btntim.TabIndex = 13;
            this.btntim.Text = "Tìm theo ngày";
            this.btntim.UseVisualStyleBackColor = false;
            this.btntim.Click += new System.EventHandler(this.button1_Click);
            // 
            // NBT
            // 
            this.NBT.AutoSize = true;
            this.NBT.Location = new System.Drawing.Point(156, 109);
            this.NBT.Name = "NBT";
            this.NBT.Size = new System.Drawing.Size(0, 24);
            this.NBT.TabIndex = 14;
            // 
            // NKT
            // 
            this.NKT.AutoSize = true;
            this.NKT.Location = new System.Drawing.Point(156, 149);
            this.NKT.Name = "NKT";
            this.NKT.Size = new System.Drawing.Size(0, 24);
            this.NKT.TabIndex = 15;
            // 
            // lbltip
            // 
            this.lbltip.AutoSize = true;
            this.lbltip.Location = new System.Drawing.Point(14, 418);
            this.lbltip.Name = "lbltip";
            this.lbltip.Size = new System.Drawing.Size(510, 24);
            this.lbltip.TabIndex = 16;
            this.lbltip.Text = "* Lấy ngày bằng cách chọn trong bảng ( có thể chọn nhiều)";
            // 
            // Quản_lý
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(771, 478);
            this.Controls.Add(this.lbltip);
            this.Controls.Add(this.NKT);
            this.Controls.Add(this.NBT);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.lblngaykt);
            this.Controls.Add(this.lblngaybd);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btTatCa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btChuyen);
            this.Controls.Add(this.btQuay_lai);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Quản_lý";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản_lý";
            this.Load += new System.EventHandler(this.Quản_lý_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chuyen_tienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuay_lai;
        private System.Windows.Forms.Button btChuyen;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btTatCa;
        private System.Windows.Forms.BindingSource Chuyen_tienBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblngaybd;
        private System.Windows.Forms.Label lblngaykt;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Label NBT;
        private System.Windows.Forms.Label NKT;
        private System.Windows.Forms.Label lbltip;
    }
}